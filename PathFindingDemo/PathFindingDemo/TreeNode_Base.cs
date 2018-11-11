using System;
using System.Collections.Generic;

namespace PathFindingDemo
{
   public abstract class TreeNode_Base : IComparable
   {
      public enum SearchAlgorithm
      {
         Greedy_Search,
         A_Star,
         Breadth_First,
         Depth_First
      }

      private SearchAlgorithm searchAlgorithm = SearchAlgorithm.Greedy_Search;

      public TreeNode_Base(A_Star a_Star_Class_Reference, SearchAlgorithm searchAlgorithm)
      {
         A_Star_Class_Reference = a_Star_Class_Reference;
         this.searchAlgorithm = searchAlgorithm;
      }

      public enum State
      {
         NotUsed,
         Open,
         Closed,
      }

      public A_Star A_Star_Class_Reference;

      private int previousCosts = 0;
      private int estimatedCosts = 0;
      private int totalCosts;

      public const int StepCost = 1;

      public int PreviousCosts
      {
         set
         {
            previousCosts = value;
         }

         get
         {
            return previousCosts;
         }
      }

      public int EstimatedCosts
      {
         set
         {
            estimatedCosts = value;
         }

         get
         {
            return estimatedCosts;
         }
      }

      public int TotalCosts
      {
         get
         {
            return (PreviousCosts + EstimatedCosts);
         }
      }

      private TreeNode_Base previousNode;

      public TreeNode_Base PreviousNode
      {
         set
         {
            previousNode = value;
         }

         get
         {
            return previousNode;
         }
      }

      private State actualState = State.NotUsed;

      public State ActualState
      {
         set
         {
            actualState = value;
            
            if (ActualState == State.Open)
            {
               EstimatedCosts = CalculateEstimatedCosts();
            }

            OnActualStateChanged(this, new EventArgs());
         }

         get
         {
            return actualState;
         }
      }

      public event EventHandler ActualStateChanged;

      protected virtual void OnActualStateChanged(object sender, EventArgs e)
      {
         if (ActualStateChanged != null)
         {
            ActualStateChanged(sender, e);
         }
      }

      int IComparable.CompareTo(object obj)
      {
         return CompareTreeNodes((TreeNode_Base)obj);
      }

      protected abstract int CompareTreeNodes(TreeNode_Base secondNode);
      protected abstract int CalculateEstimatedCosts();
      public abstract List<TreeNode_Base> GetAllConnectedNodes();
   }
}