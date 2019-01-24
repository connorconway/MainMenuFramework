/*using System;
using System.Collections.Generic;
using MainMenuFramework.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MainMenuFramework.States
{
	public class MenuState : State
	{
		private readonly List<IDrawable> _components;

		public MenuState(Game game, GraphicsDevice graphics, ContentManager content) : base(game, graphics, content)
		{
			var buttonTexture = Content.Load<Texture2D>("Controls/button");
			var buttonFont = Content.Load<SpriteFont>("Fonts/MainMenu");
			;
			var newButton = new Button(buttonTexture, buttonFont, new Vector2(300, 200), "Quit Game");

			var newGameButton = new Button(buttonTexture, buttonFont, new Vector2(400, 300), "New Game");

			newButton.Click += QuitGameClicked;
			newGameButton.Click += NewGameClicked;
            _components = new List<IDrawable>() { newButton, newGameButton };
		}

		private void NewGameClicked(object sender, EventArgs e)
		{
			//_game.ChangeState(new GameState(_game, _graphics, _content));
		}

		private void QuitGameClicked(object sender, EventArgs e)
		{
			Game.Exit();
		}

		public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
		{
			spriteBatch.Begin();
			_components.ForEach(c => c.Draw(gameTime, spriteBatch));
			spriteBatch.End();
		}

		public override void PostUpdate(GameTime gameTime)
		{
			// Remove sprites, etc.
		}

		public override void Update(GameTime gameTime)
		{
			_components.ForEach(c => c.Update(gameTime));
		}
	}
}*/