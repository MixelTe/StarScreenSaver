using System;
using System.Drawing;

namespace StarScreen
{
	interface IDrawingBuffer : IDisposable
	{
		void Draw(IPainter painter);
		void RenderTo(Graphics target);
	}
	internal interface IPainter
	{
		void Draw(Graphics g);
	}
}