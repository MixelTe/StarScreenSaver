using System.Drawing;

namespace StarScreen
{
	class ColorARGB
	{
		public int R;
		public int G;
		public int B;
		public int A;

		public ColorARGB()
		{

		}
		public ColorARGB(int a, int r, int g, int b)
		{
			A = a;
			R = r;
			G = g;
			B = b;
		}
		public ColorARGB(Color color)
		{
			A = color.A;
			R = color.R;
			G = color.G;
			B = color.B;
		}

		public Color GetColor()
		{
			return Color.FromArgb(A, R, G, B);
		}
	}
}