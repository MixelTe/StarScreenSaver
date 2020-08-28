using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace StarScreen
{
	class StarsControl: IDisposable
	{
		private readonly int _Density = 100 * 100 / 1;
		private readonly int _MaxDistance = 100;
		private readonly bool _CreateConections = true;
		private readonly int _MinStar = 6;
		private readonly int _MaxStar = 12;
		private readonly int _MinGrowSpeed = 6;
		private readonly int _MaxGrowSpeed = 10;
		private readonly int _MinLifeTime = 50;
		private readonly int _MaxLifeTime = 200;
		//private readonly ColorARGB[] _Colors = { new ColorARGB(Color.White), new ColorARGB(Color.Yellow) };

		private readonly int _Height;
		private readonly int _Width;
		private readonly int _MaxStarsCount;
		private bool _FirstStartRemoved = false;
		public Star[] Stars;
		public Conection[] Conections;
		private readonly Random _Rnd = new Random();

		public StarsControl(int width, int height)
		{
			_Height = height;
			_Width = width;

			_MaxStarsCount = _Height * _Width / _Density;
			Stars = new Star[_MaxStarsCount];
			Conections = new Conection[_MaxStarsCount * _MaxStarsCount];
		}
		public StarsControl(int width, int height, StarsSettings settings)
		{
			_Density = settings.Density;
			_MaxDistance = settings.MaxDistance;
			 _CreateConections = settings.CreateConections;
			_MinStar = settings.MinStarSize;
			_MaxStar = settings.MaxStarSize;
			_MinGrowSpeed = settings.MinGrowSpeed;
			_MaxGrowSpeed = settings.MaxGrowSpeed;
			_MinLifeTime = settings.MinLifeTime;
			_MaxLifeTime = settings.MaxLifeTime;

			_Height = height;
			_Width = width;

			_MaxStarsCount = _Height * _Width / _Density;
			Stars = new Star[_MaxStarsCount];
			Conections = new Conection[_MaxStarsCount * _MaxStarsCount];
		}
		public void Step()
		{
			var starAdded = false;
			for (int i = 0; i < Stars.Length; i++)
			{
				var star = Stars[i];
				if (star != null)
				{
					if (star.Step())
					{
						star.RemoveConections(Stars);
						star.Dispose();
						Stars[i] = null;
						_FirstStartRemoved = true;
					}
				}
				else
				{
					if (!starAdded || _FirstStartRemoved)
					{
						//var color = _Colors[_Rnd.Next(_Colors.Length)];

						Stars[i] = new Star(
							_Rnd.Next(_Width),
							_Rnd.Next(_Height),
							_Rnd.Next(_MinStar, _MaxStar),
							_Rnd.Next(_MinGrowSpeed, _MaxGrowSpeed),
							_Rnd.Next(_MinLifeTime, _MaxLifeTime),
							CreateColor());
						if (_CreateConections)
						{
							Stars[i].CreateConections(Stars, _MaxStarsCount, _MaxDistance);
						}
						starAdded = true;
					}
				}
			}
		}
		private ColorARGB CreateColor()
		{
			var color = new ColorARGB();
			switch (_Rnd.Next(3))
			{
				case 0:
					color.R = 255;
					color.G = 255;
					color.B = _Rnd.Next(256);
					break;
				case 1:
					color.R = _Rnd.Next(256);
					color.G = 255;
					color.B = 255;
					break;
				case 2:
					var c = _Rnd.Next(256);
					color.R = c;
					color.G = c;
					color.B = 255;
					break;

				default: throw new Exception("switch default");
			}
			return color;
		}

		public void Dispose()
		{
			foreach (var star in Stars)
			{
				if (star != null) star.Dispose();
			}
		}
	}

	class Star : IDisposable
	{

		private readonly int _MinL = 100;

		private readonly int _X;
		private readonly int _Y;
		private readonly int _D;
		private int _L;
		private readonly PathGradientBrush _Brush;
		private readonly ColorARGB _Color;
		private Conection[] _Conections = { };

		private bool _LGrow = true;
		private readonly int _LGrowSpeed = 8;
		private readonly int _LifeTime;
		private int _LifeTimeCur;

		public Star(int x, int y, int d, int growSpeed, int lifeTime, ColorARGB color)
		{
			_X = x;
			_Y = y;
			_D = d;
			_L = 0;
			_LGrowSpeed = growSpeed;
			_Color = color;
			_LifeTime = lifeTime;

			var path = new GraphicsPath();
			path.AddEllipse(_X, _Y, _D, _D);
			_Brush = new PathGradientBrush(path);
			_Brush.SurroundColors = new[] { Color.Transparent };
		}
		public void CreateConections(Star[] stars, int maxStarsCount, int maxDistance)
		{
			_Conections = new Conection[maxStarsCount];
			var point = GetPoint();
			for (int i = 0; i < stars.Length; i++)
			{
				var star = stars[i];
				if (star != null && star != this)
				{
					if (!star.PointExist(point))
					{
						var p = star.GetPoint();
						if (LessDistance(point, p, maxDistance))
						{
							_Conections[i] = new Conection(point, p, new ColorARGB(Color.White));
						}
					}
				}
			}
		}
		public void RemoveConections(Star[] stars)
		{
			var point = GetPoint();
			for (int i = 0; i < stars.Length; i++)
			{
				var star = stars[i];
				if (star != null && star != this)
				{
					star.RemoveConection(point);
				}
			}
		}
		public bool Step()
		{
			if (_LifeTimeCur < _LifeTime)
			{
				if (_LGrow) _L += _LGrowSpeed;
				else _L -= _LGrowSpeed;
				if (_L >= 255)
				{
					_LGrow = false;
					_L = 255;
				}
				if (_L <= _MinL) _LGrow = true;
			}
			else
			{
				_L--;
				_L = Math.Max(_L, 0);
			}

			var ConectionsCount = 0;
			for (int i = 0; i < _Conections.Length; i++)
			{
				var conection = _Conections[i];
				if (conection != null)
				{
					ConectionsCount++;
					if (conection.Step(_LifeTimeCur > _LifeTime))
					{
						conection.Dispose();
						_Conections[i] = null;
					};
				}
			}

			_LifeTimeCur++;

			return _LifeTimeCur > _LifeTime && _L == 0 && ConectionsCount == 0;
		}
		public void Draw(Graphics g)
		{
			foreach (var conection in _Conections)
			{
				if (conection != null) conection.Draw(g);
			}
			_Color.A = _L;
			_Brush.CenterColor = _Color.GetColor();
			g.FillEllipse(_Brush, _X, _Y, _D, _D);
		}

		private bool PointExist(Point point)
		{
			var exist = false;
			foreach (var conection in _Conections)
			{
				if (conection != null && conection.GetPoint2() == point) exist = true;
			}
			return exist;
		}
		private void RemoveConection(Point point)
		{
			foreach (var conection in _Conections)
			{
				if (conection != null && conection.GetPoint2() == point)
				{
					conection.Hide();
				}
			}
		}
		private Point GetPoint()
		{
			return new Point(_X + _D / 2, _Y + _D / 2);
		}
		private bool LessDistance(Point point1, Point point2, int distance)
		{
			return (Square(point1.X - point2.X) + Square(point1.Y - point2.Y)) < Square(distance);
		}
		private int Square(int num) => num * num;

		public void Dispose()
		{
			_Brush?.Dispose();
			foreach (var conection in _Conections)
			{
				if (conection != null) conection.Dispose();
			}
		}
	}
	class Conection : IDisposable
	{
		private readonly int _W = 1;
		private readonly int _MaxL = 40;
		private readonly int _LGrowSpeed = 1;

		private readonly Point _Point1;
		private readonly Point _Point2;
		private int _L;
		private readonly Pen _Pen;
		private readonly ColorARGB _Color;
		private bool _Hide;
		public void Hide() => _Hide = true;


		public Conection(Point point1, Point point2, ColorARGB color)
		{
			_Point1 = point1;
			_Point2 = point2;
			_Color = color;

			_Pen = new Pen(_Color.GetColor());
			_Pen.Width = _W;
		}
		public bool Step(bool hide)
		{
			if (_Hide || hide)
			{
				_Hide = true;
				_L -= _LGrowSpeed;
				_L = Math.Max(_L, 0);
			}
			else
			{
				if (_L < _MaxL)
				{
					_L += _LGrowSpeed;
					_L = Math.Min(_L, _MaxL);
				}
			}
			return _Hide && _L == 0;
		}
		public void Draw(Graphics g)
		{
			_Color.A = _L;
			_Pen.Color = _Color.GetColor();
			g.DrawLine(_Pen, _Point1, _Point2);
		}
		public Point GetPoint2()
		{
			return _Point2;
		}

		public void Dispose()
		{
			_Pen?.Dispose();
		}
	}
}