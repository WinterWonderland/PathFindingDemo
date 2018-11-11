using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PathFindingDemo
{
   /// <summary>
   /// This is the main type for your game
   /// </summary>
   public class PathFindingDemo : Microsoft.Xna.Framework.Game
   {
      GraphicsDeviceManager graphics;
      SpriteBatch spriteBatch;

      public Board gameBoard = new Board();

      private IntPtr DrawSurface;
      private System.Windows.Forms.Form ParentForm;
      private System.Windows.Forms.PictureBox SurfacePictureBox;
      public System.Windows.Forms.Control gameForm;

      public PathFindingDemo(IntPtr drawSurface, System.Windows.Forms.Form parentForm, System.Windows.Forms.PictureBox surfacePictureBox)
      {
         gameForm = System.Windows.Forms.Control.FromHandle(this.Window.Handle);
         gameForm.VisibleChanged += new EventHandler(gameForm_VisibleChanged);

         graphics = new GraphicsDeviceManager(this);
         Content.RootDirectory = "Content";

         DrawSurface = drawSurface;
         ParentForm = parentForm;
         SurfacePictureBox = surfacePictureBox;

         graphics.PreparingDeviceSettings += new EventHandler<PreparingDeviceSettingsEventArgs>(graphics_PreparingDeviceSettings);

         Mouse.WindowHandle = drawSurface;

         graphics.PreferredBackBufferWidth = 1024;
         graphics.PreferredBackBufferHeight = 768;
      }

      private void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
      {
         e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = DrawSurface;
      }

      private void gameForm_VisibleChanged(object sender, EventArgs e)
      {
         if (gameForm.Visible)
         {
            gameForm.Visible = false;
         }
      }

      /// <summary>
      /// Allows the game to perform any initialization it needs to before starting to run.
      /// This is where it can query for any required services and load any non-graphic
      /// related content.  Calling base.Initialize will enumerate through any components
      /// and initialize them as well.
      /// </summary>
      protected override void Initialize()
      {
         // TODO: Add your initialization logic here
         IsMouseVisible = true;
         IsFixedTimeStep = false;

         base.Initialize();
      }

      /// <summary>
      /// LoadContent will be called once per game and is the place to load
      /// all of your content.
      /// </summary>
      protected override void LoadContent()
      {
         // Create a new SpriteBatch, which can be used to draw textures.
         spriteBatch = new SpriteBatch(GraphicsDevice);

         // TODO: use this.Content to load your game content here
         Tile.LoadContent(Content);
         gameBoard.LoadContent(Content);
      }

      /// <summary>
      /// UnloadContent will be called once per game and is the place to unload
      /// all content.
      /// </summary>
      protected override void UnloadContent()
      {
         // TODO: Unload any non ContentManager content here
      }

      /// <summary>
      /// Allows the game to run logic such as updating the world,
      /// checking for collisions, gathering input, and playing audio.
      /// </summary>
      /// <param name="gameTime">Provides a snapshot of timing values.</param>
      protected override void Update(GameTime gameTime)
      {
         // Allows the game to exit
         if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
            this.Exit();

         // TODO: Add your update logic here

         gameBoard.Update(gameTime);
         base.Update(gameTime);
      }

      /// <summary>
      /// This is called when the game should draw itself.
      /// </summary>
      /// <param name="gameTime">Provides a snapshot of timing values.</param>
      protected override void Draw(GameTime gameTime)
      {
         GraphicsDevice.Clear(Color.CornflowerBlue);

         // TODO: Add your drawing code here
         gameBoard.Draw(gameTime, graphics, spriteBatch);

         base.Draw(gameTime);
      }
   }
}
