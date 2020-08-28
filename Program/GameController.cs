using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace StarScreen
{
	class GameController
	{
		private object _lock = new object();
		private StarsControl _game;
		private IPainter _gamePainter;
		private bool _Paused;
		private IDrawingBuffer _DrawingBuffer;
		private FPS _fps = new FPS();
		private StarsSettings _starsSettings = new StarsSettings();

		internal Control TargetControl;
		private Thread _t;
		private bool _IsRunning;

		internal double GetFps() => _fps.Value;

		public GameController()
		{
			_starsSettings.Load();
		}

		internal void TogglePaused()
		{
			lock (_lock)
			{
				_Paused = !_Paused;
			}
		}
		private bool Paused
		{
			get
			{
				lock (_lock) return _Paused;
			}
		}
		private bool IsRunning
		{
			get
			{
				lock (_lock) return _IsRunning;
			}
			set
			{
				lock (_lock) _IsRunning = value;
			}
		}
		internal void RecreateGame(Rectangle rcClient)
		{
			var game = new StarsControl(rcClient.Width, rcClient.Height, _starsSettings);
			var gamePainter = new GamePainter(game, rcClient);

			AssignComponents(game, gamePainter, rcClient);
		}
		private void AssignComponents(StarsControl game, GamePainter gamePainter, Rectangle rcClient)
		{
			lock (_lock)
			{
				_game?.Dispose();
				_game = game;
				_gamePainter = gamePainter;

				_DrawingBuffer?.Dispose();
				_DrawingBuffer = CreateDrawing1(rcClient);
			}
		}

		private IDrawingBuffer CreateDrawing1(Rectangle rcClient)
		{
			return new DrawingBuffer(TargetControl.CreateGraphics(), rcClient);
		}
		internal void Start()
		{
			_t = new Thread(GameLoop);
			_t.IsBackground = true;

			IsRunning = true;
			_t.Start();
		}
		internal void Stop()
		{
			IsRunning = false;
			_t.Join(TimeSpan.FromSeconds(20)); // wait thread to finish
		}
		private void GameLoop()
		{
			while (IsRunning)
			{
				if (!Paused)
				{
					lock (_lock)
					{
						_game.Step();
					}

					DrawGame();

					_fps.Increment();
				}
				Thread.Sleep(1000 / 30);
			}
		}
		internal void DrawGame()
		{
			lock (_lock)
			{
				using (var gTarget = TargetControl.CreateGraphics())
				{
					_DrawingBuffer.Draw(_gamePainter);
					_DrawingBuffer.RenderTo(gTarget);
				}
			}
		}
	}
}
