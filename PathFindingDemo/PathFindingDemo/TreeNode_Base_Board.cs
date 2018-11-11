using System;
using System.Collections.Generic;

namespace PathFindingDemo
{
   public abstract class TreeNode_Base_Board : TreeNode_Base
   {
      public TreeNode_Base_Board(int x, int y, A_Star a_Star_Class_Reference, SearchAlgorithm searchAlgorithm)
         : base(a_Star_Class_Reference, searchAlgorithm)
      {
         X = x;
         Y = y;
      }

      private int x = 0;
      private int y = 0;

      public int X
      {
         get
         {
            return x;
         }
         
         private set
         {
            x = value;
         }
      }

      public int Y
      {
         get
         {
            return y;
         }

         private set
         {
            y = value;
         }
      }

      protected override int CalculateEstimatedCosts()
      {
         TreeNode_Base_Board endNode = (TreeNode_Base_Board)A_Star_Class_Reference.EndNode;
         int estimatedCosts = (Math.Abs(endNode.X - X) + Math.Abs(endNode.Y - Y));
         return estimatedCosts;
      }

      public override List<TreeNode_Base> GetAllConnectedNodes()
      {
         return Board.GetAllConnectedWhiteTiles(this);
      }

      //protected abstract int CompareTreeNodes(TreeNode_Base secondNode);
   }
}