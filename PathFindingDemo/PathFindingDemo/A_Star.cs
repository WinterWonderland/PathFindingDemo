using System.Collections.Generic;
using System;

namespace PathFindingDemo
{
   public class A_Star
   {
      public enum Result
      {
         SolutionFound,
         NoSolution,
         StepDone
      }

      private List<TreeNode_Base> openNodeList = new List<TreeNode_Base>();
      private TreeNode_Base startNode;
      private TreeNode_Base endNode;

      public TreeNode_Base StartNode
      {
         get
         {
            return startNode;
         }

         set
         {
            startNode = value;

            if (!openNodeList.Contains(StartNode))
            {
               openNodeList.Add(StartNode);
               StartNode.ActualState = TreeNode_Base.State.Open;
            }
         }
      }

      public TreeNode_Base EndNode
      {
         get
         {
            return endNode;
         }

         set
         {
            endNode = value;
         }
      }

      public void Clear()
      {
         openNodeList.Clear();
         ActualStep = 0;
      }

      private int actualStep = 0;

      public int ActualStep
      {
         get
         {
            return actualStep;
         }

         private set
         {
            actualStep = value;
            OnActualStepChanged(this, new EventArgs());
         }
      }

      public event EventHandler ActualStepChanged;

      protected virtual void OnActualStepChanged(object sender, EventArgs e)
      {
         if (ActualStepChanged != null)
         {
            ActualStepChanged(sender, e);
         }
      }

      public Result RunStep()
      {
         ActualStep++;

         if (openNodeList.Count == 0)
         {
            return Result.NoSolution;
         }

         openNodeList.Sort();

         TreeNode_Base actualNodeToExpand = openNodeList[0];
         openNodeList.Remove(actualNodeToExpand);
         actualNodeToExpand.ActualState = TreeNode_Base.State.Closed;

         if (actualNodeToExpand == EndNode)
         {
            return Result.SolutionFound;
         }

         foreach (TreeNode_Base node in actualNodeToExpand.GetAllConnectedNodes())
         {
            node.PreviousNode = actualNodeToExpand;
            node.ActualState = TreeNode_Base.State.Open;
            node.PreviousCosts = node.PreviousNode.PreviousCosts + TreeNode_Base.StepCost;

            if (!openNodeList.Contains(node))
            {
               openNodeList.Add(node);
            }
         }

         return Result.StepDone;
      }
   }
}