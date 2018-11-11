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
   public class Board
   {
      public static TreeNode_Base.SearchAlgorithm searchAlgorithm = TreeNode_Base.SearchAlgorithm.Breadth_First;

      public const int Width = 1024;
      public const int Heigth = 768;

      public const int TileCountWidth = Width / Tile.Width;
      public const int TileCountHeigth = Heigth / Tile.Height;
      public const int TileCountComplete = (TileCountWidth - 2) * (TileCountHeigth - 2);

      public float blackTilesPercentage
      {
         set
         {
            blackTilesFactor = value / 100;
         }
      }

      public float blackTilesFactor = 30.0f / 100;

      private float UpdateIntervalInSeconds = 0.0f;

      public float UpdatesPerSeconds
      {
         set
         {
            UpdateIntervalInSeconds = (1 / value);
         }
      }

      private static Tile[,] tileMap = new Tile[TileCountWidth, TileCountHeigth];
      private Tile tileStart;
      private Tile tileEnd;

      public A_Star a_Star;

      private Random random = new Random();

      SpriteFont font;

      public void LoadContent(ContentManager content)
      {
         font = content.Load<SpriteFont>("SpriteFont1");
      }

      private bool isInitialized = false;
      private bool isStartet = false;

      public void Initialize()
      {
         isStartet = false;
         isInitialized = true;
         run = false;
         
         for (int x = 0; x < TileCountWidth; x++)
         {
            // Initialize board with empty fields
            for (int y = 0; y < TileCountHeigth; y++)
            {
               tileMap[x, y] = new Tile(x, y, Tile.TileType.None);

               // Make black boarder

               if ((x == 0) || (y == 0) || (x == (TileCountWidth - 1)) || (y == (TileCountHeigth - 1)))
               {
                  tileMap[x, y].Type = Tile.TileType.Black;
               }
            }
         }

         int TileCountEmpty = TileCountComplete;

         // Set end field
         tileEnd = setTileRandomPosition(Tile.TileType.End);
         TileCountEmpty--;

         // Set start field
         tileStart = setTileRandomPosition(Tile.TileType.Start);
         TileCountEmpty--;

         // Set black fields
         int blackTilesCount = (int)(TileCountEmpty * blackTilesFactor);

         for (int i = 0; i < blackTilesCount; i++)
         {
            setTileRandomPosition(Tile.TileType.Black);
            TileCountEmpty--;
         }

         // Set white fields
         for (int i = 0; i < TileCountEmpty; i++)
         {
            fillBoardWithTiles(Tile.TileType.White);
            TileCountEmpty--;
         }
      }

      public EventHandler ActualStepChanged;

      protected void OnActualStepChanged(object sender, EventArgs e)
      {
         if (ActualStepChanged != null)
         {
            ActualStepChanged(sender, e);
         }
      }

      private Tile setTileRandomPosition(Tile.TileType type)
      {
         while (true)
         {
            int x = random.Next(0, TileCountWidth);
            int y = random.Next(0, TileCountHeigth);

            if (tileMap[x, y].Type == Tile.TileType.None)
            {
               tileMap[x, y].Type = type;
               return tileMap[x, y]; 
            }
         }
      }

      private void fillBoardWithTiles(Tile.TileType type)
      {
         for (int x = 0; x < TileCountWidth; x++)
         {
            for (int y = 0; y < TileCountHeigth; y++)
            {
               if (tileMap[x, y].Type == Tile.TileType.None)
               {
                  tileMap[x, y].Type = type;
               }
            }
         }
      }

      private static TreeNode_Base CreateTreeNode(int x, int y, A_Star a_Star_Reference)
      {
         switch (searchAlgorithm)
         {
            case TreeNode_Base.SearchAlgorithm.Greedy_Search:
               return new TreeNode_Greedy_Search(x, y, a_Star_Reference, searchAlgorithm);

            case TreeNode_Base.SearchAlgorithm.A_Star:
               return new TreeNode_A_Star(x, y, a_Star_Reference, searchAlgorithm);

            case TreeNode_Base.SearchAlgorithm.Breadth_First:
               return new TreeNode_Breadth_First(x, y, a_Star_Reference, searchAlgorithm);

            case TreeNode_Base.SearchAlgorithm.Depth_First:
               return new TreeNode_Depth_First(x, y, a_Star_Reference, searchAlgorithm);
               
            default:
               throw new NotSupportedException();
         }
      }

      public static List<TreeNode_Base> GetAllConnectedWhiteTiles(TreeNode_Base_Board tile)
      {
          List<TreeNode_Base> nodeList = new List<TreeNode_Base>();

         if (tile.X > 0)
         {
            if (tileMap[tile.X - 1, tile.Y].Type == Tile.TileType.White)
            {
               nodeList.Add(CreateTreeNode(tile.X - 1, tile.Y, tile.A_Star_Class_Reference));
            }

            if (tileMap[tile.X - 1, tile.Y].Type == Tile.TileType.End)
            {
               nodeList.Add(tile.A_Star_Class_Reference.EndNode);
            }
         }

         if (tile.X < (TileCountWidth - 1))
         {
            if (tileMap[tile.X + 1, tile.Y].Type == Tile.TileType.White)
            {
               nodeList.Add(CreateTreeNode(tile.X + 1, tile.Y, tile.A_Star_Class_Reference));
            }

            if (tileMap[tile.X + 1, tile.Y].Type == Tile.TileType.End)
            {
               nodeList.Add(tile.A_Star_Class_Reference.EndNode);
            }
         }

         if (tile.Y > 0)
         {
            if (tileMap[tile.X, tile.Y - 1].Type == Tile.TileType.White)
            {
               nodeList.Add(CreateTreeNode(tile.X, tile.Y - 1, tile.A_Star_Class_Reference));
            }

            if (tileMap[tile.X, tile.Y - 1].Type == Tile.TileType.End)
            {
               nodeList.Add(tile.A_Star_Class_Reference.EndNode);
            }
         }

         if (tile.Y < (TileCountHeigth - 1))
         {
            if (tileMap[tile.X, tile.Y + 1].Type == Tile.TileType.White)
            {
               nodeList.Add(CreateTreeNode(tile.X, tile.Y + 1, tile.A_Star_Class_Reference));
            }

            if (tileMap[tile.X, tile.Y + 1].Type == Tile.TileType.End)
            {
               nodeList.Add(tile.A_Star_Class_Reference.EndNode);
            }
         }

         foreach (TreeNode_Base_Board node in nodeList)
         {
            node.ActualStateChanged += new EventHandler(TileTypeChanged);
         }

         return nodeList;
      }

      private double gameTime_TotalSekonds_SinceLastGameStep = 0;
      private bool endReached = false;
      private bool solutionFound = false;

      private bool run = false;

      public void Run()
      {
         if (run == false)
         {
            a_Star = new A_Star();
            a_Star.ActualStepChanged += new EventHandler(OnActualStepChanged);
            a_Star.EndNode = CreateTreeNode(tileEnd.BoardPositionX, tileEnd.BoardPositionY, a_Star);
            a_Star.StartNode = CreateTreeNode(tileStart.BoardPositionX, tileStart.BoardPositionY, a_Star);

            solutionFound = false;
            endReached = false;
            SolutionLength = 0;

            foreach (Tile tile in tileMap)
            {
               if (tile.Type == Tile.TileType.Red || tile.Type == Tile.TileType.Blue || tile.Type == Tile.TileType.Green)
               {
                  tile.Type = Tile.TileType.White;
               }
            }

            run = true;
            isStartet = true;
         }
      }

      private int solutionLength = 0;

      public int SolutionLength
      {
         get
         {
            return solutionLength;
         }

         private set
         {
            solutionLength = value;
         }
      }

      public void Update(GameTime gameTime)
      {
         gameTime_TotalSekonds_SinceLastGameStep += gameTime.ElapsedGameTime.TotalSeconds;

         if (isInitialized)
         {
            if (run)
            {
               if (gameTime_TotalSekonds_SinceLastGameStep >= UpdateIntervalInSeconds)
               {
                  gameTime_TotalSekonds_SinceLastGameStep = 0;

                  if (!endReached)
                  {
                     A_Star.Result result = a_Star.RunStep();

                     switch (result)
                     {
                        case A_Star.Result.NoSolution:
                           endReached = true;
                           break;

                        case A_Star.Result.SolutionFound:
                           endReached = true;
                           solutionFound = true;

                           bool startfound = false;
                           TreeNode_Base_Board actualNode = (TreeNode_Base_Board)a_Star.EndNode;

                           while (!startfound)
                           {
                              SolutionLength++;
                              actualNode = (TreeNode_Base_Board)actualNode.PreviousNode;

                              if (actualNode == a_Star.StartNode)
                              {
                                 startfound = true;
                              }
                              else
                              {
                                 tileMap[actualNode.X, actualNode.Y].Type = Tile.TileType.Blue;
                              }
                           }

                           break;

                        case A_Star.Result.StepDone:
                           break;
                     }
                  }
                  else
                  {
                     run = false;
                     OnFinished(this, new EventArgs());
                  }
               }
            }
         }
      }

      public event EventHandler Finished;

      protected void OnFinished(object sender, EventArgs e)
      {
         if (Finished != null)
         {
            Finished(sender, e);
         }
      }

      public void Draw(GameTime gameTime, GraphicsDeviceManager graphics, SpriteBatch spriteBatch)
      {
         if (isInitialized)
         {
            for (int x = 0; x < TileCountWidth; x++)
            {
               for (int y = 0; y < TileCountHeigth; y++)
               {
                  tileMap[x, y].Draw(gameTime, graphics, spriteBatch);
               }
            }

            if (endReached)
            {
               if (isStartet)
               {
                  Color fontColor = Color.Blue;//Color.FromNonPremultiplied(0, 162, 232, 255);
                  string s;
                  Vector2 stringDimensions;
                  spriteBatch.Begin();
               
                  if (!solutionFound)
                  {
                     s = "No path available";
                     stringDimensions = font.MeasureString(s);
                     spriteBatch.DrawString(font, s, new Vector2((Width - stringDimensions.X) / 2, (Heigth / 3) - stringDimensions.Y / 2), fontColor);
                  }
                  else
                  {
                     s = "Path found";
                     stringDimensions = font.MeasureString(s);
                     spriteBatch.DrawString(font, s, new Vector2((Width - stringDimensions.X) / 2, (Heigth / 3) - stringDimensions.Y / 2), fontColor);
                  }

                  spriteBatch.End();
               }
            }
         }
      }

      public static void TileTypeChanged(object sender, EventArgs e)
      {
         TreeNode_Base_Board node = (TreeNode_Base_Board)sender;

         if (node != node.A_Star_Class_Reference.EndNode)
         {
            if (node.ActualState == TreeNode_Base.State.Open)
            {
               tileMap[node.X, node.Y].Type = Tile.TileType.Red;
            }
            else if (node.ActualState == TreeNode_Base.State.Closed)
            {
               tileMap[node.X, node.Y].Type = Tile.TileType.Green;
            }
         }
      }
   }
}
