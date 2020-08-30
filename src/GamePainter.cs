using System.Drawing;

namespace StarScreen
{
	class GamePainter : IPainter
	{
		private readonly Brush _brBack = new SolidBrush(Color.Black);
		private readonly StarsControl _game;
		private readonly Rectangle _rcClient;

		public GamePainter(StarsControl game, Rectangle rcClient)
		{
			_game = game;
			_rcClient = rcClient;
		}

		public void Draw(Graphics g)
		{
			g.FillRectangle(_brBack, _rcClient);
			foreach (var star in _game.Stars)
			{
				if (star != null) star.Draw(g);
			}
			foreach (var conection in _game.Conections)
			{
				if (conection != null) conection.Draw(g);
			}
		}
	}
}