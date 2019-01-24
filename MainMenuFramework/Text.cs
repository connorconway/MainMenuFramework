using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MainMenuFramework
{
    public class Text : IDrawable
    {
        private readonly SpriteFont _font;
        private readonly string _text;
        private readonly Color _color = Color.White;
        private Vector2 _position;

        public Text(SpriteFont font, string text, Vector2 position)
        {
            _font = font;
            _text = text;   
            _position = position;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
			spriteBatch.DrawString(_font, _text, _position, _color);
        }

        public void MoveToCenter(Rectangle rectangle)
        {
            _position = new Vector2(
                rectangle.X + rectangle.Width / 2 - _font.MeasureString(_text).X / 2, 
                rectangle.Y + rectangle.Height / 2 - _font.MeasureString(_text).Y / 2);
        }
    }
}