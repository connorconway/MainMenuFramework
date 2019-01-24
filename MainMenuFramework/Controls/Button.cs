using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace MainMenuFramework.Controls
{
	public class Button : IUpdatable, IDrawable
	{
		private readonly Texture2D _texture;
	    private readonly Text _text;
	    private Rectangle _boundingBox;

	    public event EventHandler Click;

		public Button(Texture2D texture, Vector2 position)
		{
			_texture = texture;
			_boundingBox = new Rectangle((int)position.X, (int)position.Y, _texture.Width, _texture.Height);
		}

	    public Button(Texture2D texture, Vector2 position, Text text) : this(texture, position)
	    {
	        _text = text;
	        _text.MoveToCenter(_boundingBox);
	    }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(_texture, _boundingBox, Color.White);
			_text?.Draw(gameTime, spriteBatch);
		}

		public void Update(GameTime gameTime)
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