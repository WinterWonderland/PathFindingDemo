using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PathFindingDemo
{
   class Tile
   {
      public enum TileType
      {
         None,
         Start,
         End,
         Black,
         White,
         Green,
         Red,
         Blue
      }

      public const int Width = 16;
      public const int Height = 16;

      private static Texture2D tileBlack;
      private static Texture2D tileGreen;
      private static Texture2D tileRed;
      private static Texture2D tileWhite;
      private static Texture2D tileStart;
      private static Texture2D tileEnd;
      private static Texture2D tileBlue;

      public int BoardPositionX;
      public int BoardPositionY;
      public TileType Type;

      public Tile previousTile = null;
      
      public Tile(int boardPositionX, int boardPositionY, TileType type)
      {
         BoardPositionX = boardPositionX;
         BoardPositionY = boardPositionY;
         Type = type;
      }

      public static void LoadContent(ContentManager content)
      {
         tileBlack = content.Load<Texture2D>("TileBlack");
         tileGreen = content.Load<Texture2D>("TileGreen");
         tileRed = content.Load<Texture2D>("TileRed");
         tileWhite = content.Load<Texture2D>("TileWhite");
         tileStart = content.Load<Texture2D>("TileStart");
         tileEnd = content.Load<Texture2D>("TileEnd");
         tileBlue = content.Load<Texture2D>("TileBlue");
      }

      public void Draw(GameTime gameTime, GraphicsDeviceManager graphics, SpriteBatch spriteBatch)
      {
         spriteBatch.Begin();

         Texture2D texture;

         if (Type == TileType.Start)
         {
            texture = tileStart;
         }
         else if (Type == TileType.End)
         {
            texture = tileEnd;
         }
         else if (Type == TileType.Black)
         {
            texture = tileBlack;
         }
         else if (Type == TileType.White)
         {
            texture = tileWhite;
         }
         else if (Type == TileType.Green)
         {
            texture = tileGreen;
         }
         else if (Type == TileType.Red)
         {
            texture = tileRed;
         }
         else if (Type == TileType.Blue)
         {
            texture = tileBlue;
         }
         else
         {
            texture = null;
         }

         spriteBatch.Draw(texture, new Rectangle(BoardPositionX * Width, BoardPositionY * Height, Width, Height), Color.White);

         spriteBatch.End();
      }
   }
}
