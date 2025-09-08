using System;
using System.Net.Http;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace alienufo_game;
public class DrawSprite
{

    public Texture2D spriteTexture2D;
    public Vector2 spriteTexturePosition = new Vector2(50, 50);

    //Content Manager to load our textures
    

    public void DrawTheSprite(ContentManager content)
    {

        spriteTexture2D = content.Load<Texture2D>("bush_sprite");

    }


    public void Draw(SpriteBatch spriteBatch)
    {

        spriteBatch.Draw(spriteTexture2D, spriteTexturePosition, Color.White);
 
    }

    
}
