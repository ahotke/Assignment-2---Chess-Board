using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Assignment_2___Chess_Board
{
    public class Game1 : Game
    {
        Texture2D darkWood, lightWood;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = 640;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            darkWood = Content.Load<Texture2D>("darkwood");
            lightWood = Content.Load<Texture2D>("lightwood");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            for (int a = 0; a < 5; a++)
            {
                for (int i = 0; i < 9; i++)
                {
                    _spriteBatch.Draw(lightWood, new Rectangle(0 + i * 160, 0 + a * 160, 80, 80), Color.White);
                    _spriteBatch.Draw(darkWood, new Rectangle(80 + i * 160, 0 + a * 160, 80, 80), Color.White);
                    _spriteBatch.Draw(lightWood, new Rectangle(80 + i * 160, 80 + a * 160, 80, 80), Color.White);
                    _spriteBatch.Draw(darkWood, new Rectangle(0 + i * 160, 80 + a * 160, 80, 80), Color.White);
                }
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
