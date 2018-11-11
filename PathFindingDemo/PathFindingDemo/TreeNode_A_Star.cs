using System;
using System.Collections.Generic;

namespace PathFindingDemo
{
   public class TreeNode_A_Star : TreeNode_Base_Board
   {
      public TreeNode_A_Star(int x, int y, A_Star a_Star_Class_Reference, SearchAlgorithm searchAlgorithm)
         : base(x, y, a_Star_Class_Reference, searchAlgorithm)
      {
      }

      protected override int CompareTreeNodes(TreeNode_Base secondNode)
      {
         if (TotalCosts < secondNode.TotalCosts)
         {
            return -1;
         }
         else if (TotalCosts > secondNode.TotalCosts)
         {
            return 1;
         }
         else
         {
            if (EstimatedCosts < secondNode.EstimatedCosts)
            {
               return -1;
            }
            else if (EstimatedCosts > secondNode.EstimatedCosts)
            {
               return 1;
            }
            else
            {
               return 0;
            }
         }
      }
   }
}