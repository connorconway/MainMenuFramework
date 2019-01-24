using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MainMenuFramework
{
	public interface IDrawable
	{
		void Draw(GameTime gameTime, SpriteBatch spriteBatch);
	}
}