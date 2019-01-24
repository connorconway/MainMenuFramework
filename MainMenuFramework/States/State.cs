using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MainMenuFramework.States
{
	public abstract class State
	{
		protected ContentManager Content;
		protected GraphicsDevice Graphics;
		protected Game Game;

	    protected State(Game game, GraphicsDevice graphics, ContentManager content)
		{
			Game = game;
			Graphics = graphics;
			Content = content;
		}

	    public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
	    public abstract void Update(GameTime gameTime);
	    public abstract void PostUpdate(GameTime gameTime);
	}
}