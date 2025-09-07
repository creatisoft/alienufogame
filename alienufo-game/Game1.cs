/*
    Alien Ufo Game
    Created by: Christopher Moya.
    X: @creatisoft | website: https://creatisoft.com
*/
using System;
using System.Net.Http;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace alienufo_game;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    
    Texture2D alienSprite;
    Texture2D ufoSprite;
    Vector2 alienPosition;
    Vector2 ufoPosition;

    Rectangle alienRect;
    Rectangle ufoRect;

    SpriteFont gameText;

    public bool collectedUfo = false;

    public Game1()
    {

        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

    }

    protected override void Initialize()
    {

        // TODO: Add your initialization logic here
        
        alienPosition = Vector2.Zero;
        ufoPosition = new Vector2(400, 250);

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        alienSprite = Content.Load<Texture2D>("alien_sprite");
        ufoSprite = Content.Load<Texture2D>("ufo_sprite");

        alienRect = new Rectangle((int)alienPosition.X, (int)alienPosition.Y, (int)alienSprite.Width, (int)alienSprite.Height);
        ufoRect = new Rectangle((int)ufoPosition.X, (int)ufoPosition.Y, (int)ufoSprite.Width, (int)ufoSprite.Height);

        gameText = Content.Load<SpriteFont>("myfont");

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        KeyboardState kState = Keyboard.GetState();

        if (kState.IsKeyDown(Keys.Right))
        {
            Console.WriteLine("key is pressed");
            alienPosition.X = alienPosition.X + 2.0f;
        }

        if (kState.IsKeyDown(Keys.Left))
        {
            Console.WriteLine("key is pressed");
            alienPosition.X = alienPosition.X - 2.0f;
        }
        if (kState.IsKeyDown(Keys.Up))
        {
            Console.WriteLine("key is pressed");
            alienPosition.Y = alienPosition.Y - 2.0f;
        }
        if (kState.IsKeyDown(Keys.Down))
        {
            Console.WriteLine("key is pressed");
            alienPosition.Y = alienPosition.Y + 2.0f;
        }


        alienRect = new Rectangle((int)alienPosition.X, (int)alienPosition.Y, (int)alienSprite.Width, (int)alienSprite.Height);

        if (alienRect.Intersects(ufoRect))
        {
            Console.WriteLine("Alien has hit the ufo");
            collectedUfo = true;
            
        }


        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        _spriteBatch.Begin();

        _spriteBatch.Draw(alienSprite, alienPosition , Color.White);

        if (collectedUfo == false)
        {
            _spriteBatch.Draw(ufoSprite, ufoPosition, Color.White);
        }
        _spriteBatch.DrawString(gameText, "Welcome to alien ufo game!", new Vector2(100, 100), Color.White);

        _spriteBatch.End();


        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
