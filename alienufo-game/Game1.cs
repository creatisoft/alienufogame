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

    //bush sprite test
    DrawSprite dSprite;

    Texture2D alienSprite;
    Texture2D ufoSprite;
    Vector2 alienPosition;
    Vector2 ufoPosition;

    Rectangle alienRect;
    Rectangle ufoRect;

    SpriteFont gameText;
    SpriteFont gameScoreText;

    public bool collectedUfo = false;
    public int gamePoints = 0;

    public Game1()
    {

        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        //add title, and turn off resizing. 
        Window.Title = "Alien UFO Game by Christopher M.";
        Window.AllowUserResizing = false;

    }

    protected override void Initialize()
    {

        // TODO: Add your initialization logic here

        //create new dsprite object
        
        alienPosition = Vector2.Zero;
        ufoPosition = new Vector2(400, 250);
        dSprite = new DrawSprite();
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
        gameScoreText = Content.Load<SpriteFont>("myfont");


        //draw the dsprite
        //use content in the parameters. 
        dSprite.DrawTheSprite(Content);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        KeyboardState kState = Keyboard.GetState();

        if (kState.IsKeyDown(Keys.Right))
        {
            Console.WriteLine("right is pressed");
            alienPosition.X = alienPosition.X + 2.0f;
        }

        if (kState.IsKeyDown(Keys.Left))
        {
            Console.WriteLine("left is pressed");
            alienPosition.X = alienPosition.X - 2.0f;
        }
        if (kState.IsKeyDown(Keys.Up))
        {
            Console.WriteLine("up is pressed");
            alienPosition.Y = alienPosition.Y - 2.0f;
        }
        if (kState.IsKeyDown(Keys.Down))
        {
            Console.WriteLine("down is pressed");
            alienPosition.Y = alienPosition.Y + 2.0f;
        }

        dSprite.Update(gameTime);


        alienRect = new Rectangle((int)alienPosition.X, (int)alienPosition.Y, (int)alienSprite.Width, (int)alienSprite.Height);

        if (alienRect.Intersects(ufoRect))
        {

            Console.WriteLine("Alien has picked up the UFO");
            ufoRect = Rectangle.Empty;
            gamePoints = gamePoints + 1;
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
        _spriteBatch.DrawString(gameText, "Welcome to alien ufo game!", new Vector2(300, 0), Color.White);
        _spriteBatch.DrawString(gameScoreText, $"Score: {gamePoints}", new Vector2(300, 18), Color.White);

        dSprite.Draw(_spriteBatch);

        _spriteBatch.End();


        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
