using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Fake3DOpenWorld
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        List<Sprite> sprites;
        Color color;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            color = Color.White;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            sprites = new List<Sprite>() {
                new Sprite(Content.Load<Texture2D>("Environment/F3D_Sky"), 0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight),
                new Sprite(Content.Load<Texture2D>("Environment/F3D_Clouds"), 0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight)
            };
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Transparent);
            _spriteBatch.Begin();
            foreach (Sprite sprite in sprites)
            {
                _spriteBatch.Draw(sprite.Texture, new Rectangle(sprite.X,sprite.Y,sprite.Width,sprite.Height), color);
            }
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
