using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace MainMenuFramework.Controls
{
	public class Button : Component
	{
		private readonly Texture2D _texture;
		private readonly SpriteFont _font;
		private readonly Vector2 _fontPosition;
		private readonly Color _fontColor = Color.White;
		private readonly string _text;
		private Rectangle _boundingBox;

		public event EventHandler Click;

		public Button(Texture2D texture, SpriteFont font, Vector2 position, string text)
		{
			_texture = texture;
			_font = font;
			_text = text;
			_fontPosition = new Vector2(_boundingBox.X + (_boundingBox.Width / 2) - (_font.MeasureString(_text).X / 2), _boundingBox.Y + (_boundingBox.Height / 2) - (_font.MeasureString(_text).Y / 2));
			_boundingBox = new Rectangle((int)position.X, (int)position.Y, _texture.Width, _texture.Height);
		}

		public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(_texture, _boundingBox, Color.White);
			spriteBatch.DrawString(_font, _text, _fontPosition, _fontColor);
		}

		public override void Update(GameTime gameTime)
		{
			TouchPanel.GetState()
				.Where(t => t.State == TouchLocationState.Pressed)
				.ToList()
				.ForEach(t => HandlePressed(t.Position));
		}

		private void HandlePressed(Vector2 position)
		{
			var touch = new Rectangle((int)position.X, (int)position.Y, _boundingBox.Width, _boundingBox.Height);

			if (_boundingBox.Intersects(touch))
				Click?.Invoke(this, new EventArgs());
		}
	}
}