using System;
using System.Collections.Generic;

namespace PathFindingDemo
{
   public class TreeNode_Breadth_First : TreeNode_Base_Board
   {
      public TreeNode_Breadth_First(int x, int y, A_Star a_Star_Class_Reference, SearchAlgorithm searchAlgorithm)
         : base(x, y, a_Star_Class_Reference, searchAlgorithm)
      {
      }

      protected override int CompareTreeNodes(TreeNode_Base secondNode)
      {
         if (PreviousCosts < secondNode.PreviousCosts)
         {
            return -1;
         }
         else
         {
            if (PreviousCosts > secondNode.PreviousCosts)
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