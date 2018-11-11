using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PathFindingDemo
{
   public partial class Form_Main : Form
   {
      public PathFindingDemo pathFindingDemo;

      public Form_Main()
      {
         InitializeComponent();
      }

      public void Init()
      {
         pathFindingDemo.gameBoard.Finished += new EventHandler(gameFinished);
         pathFindingDemo.gameBoard.ActualStepChanged += new EventHandler(actualStepChanged);

         button2_Click(button_Init, new EventArgs());
      }

      private void gameFinished(object sender, EventArgs e)
      {
         if (radioButton_Greedy_Search.Checked)
         {
            label_SolutionLength_Greedy_Search.Text = pathFindingDemo.gameBoard.SolutionLength.ToString();
         }

         if (radioButton_A_Star.Checked)
         {
            label_SolutionLength_A_Star.Text = pathFindingDemo.gameBoard.SolutionLength.ToString();
         }

         if (radioButton_Breadth_First.Checked)
         {
            label_SolutionLength_Breadth_First.Text = pathFindingDemo.gameBoard.SolutionLength.ToString();
         }

         if (radioButton_Depth_First.Checked)
         {
            label_SolutionLength_Depth_First.Text = pathFindingDemo.gameBoard.SolutionLength.ToString();
         }
      }

      private void actualStepChanged(object sender, EventArgs e)
      {
         if (radioButton_Greedy_Search.Checked)
         {
            label_Steps_Greedy_Search.Text = pathFindingDemo.gameBoard.a_Star.ActualStep.ToString();
         }

         if (radioButton_A_Star.Checked)
         {
            label_Steps_A_Star.Text = pathFindingDemo.gameBoard.a_Star.ActualStep.ToString();
         }

         if (radioButton_Breadth_First.Checked)
         {
            label_Steps_Breadth_First.Text = pathFindingDemo.gameBoard.a_Star.ActualStep.ToString();
         }

         if (radioButton_Depth_First.Checked)
         {
            label_Steps_Depth_First.Text = pathFindingDemo.gameBoard.a_Star.ActualStep.ToString();
         }
      }

      private void numericUpDown_UpdatesPerSeconds_ValueChanged(object sender, EventArgs e)
      {
         pathFindingDemo.gameBoard.UpdatesPerSeconds = (float)numericUpDown_UpdatesPerSeconds.Value;
      }

      private void button1_Click(object sender, EventArgs e)
      {

         if (radioButton_Greedy_Search.Checked)
         {
            label_Steps_Greedy_Search.Text = "0";
            label_SolutionLength_Greedy_Search.Text = "0";
         }

         if (radioButton_A_Star.Checked)
         {
            label_Steps_A_Star.Text = "0";
            label_SolutionLength_A_Star.Text = "0";
         }

         if (radioButton_Breadth_First.Checked)
         {
            label_Steps_Breadth_First.Text = "0";
            label_SolutionLength_Breadth_First.Text = "0";
         }

         if (radioButton_Depth_First.Checked)
         {
            label_Steps_Depth_First.Text = "0";
            label_SolutionLength_Depth_First.Text = "0";
         }

         pathFindingDemo.gameBoard.Run();
         button_Init.Focus();
      }

      private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
      {
         ((Form)pathFindingDemo.gameForm).Close();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         pathFindingDemo.gameBoard.Initialize();
         label_Steps_Greedy_Search.Text = "0";
         label_Steps_A_Star.Text = "0";
         label_Steps_Breadth_First.Text = "0";
         label_Steps_Depth_First.Text = "0";
         label_SolutionLength_Greedy_Search.Text = "0";
         label_SolutionLength_A_Star.Text = "0";
         label_SolutionLength_Breadth_First.Text = "0";
         label_SolutionLength_Depth_First.Text = "0";

         button_Run.Focus();
      }

      private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {
         pathFindingDemo.gameBoard.blackTilesPercentage = (float)numericUpDown1.Value;
         button2_Click(button_Init, new EventArgs());
      }

      private void radioButton_Short_Click(object sender, EventArgs e)
      {
         Board.searchAlgorithm = TreeNode_Base.SearchAlgorithm.A_Star;
      }

      private void radioButton_Fast_Click(object sender, EventArgs e)
      {
         Board.searchAlgorithm = TreeNode_Base.SearchAlgorithm.Greedy_Search;
      }

      private void radioButton_Breadth_First_Click(object sender, EventArgs e)
      {
         Board.searchAlgorithm = TreeNode_Base.SearchAlgorithm.Breadth_First;
      }

      private void radioButton_Depth_First_Click(object sender, EventArgs e)
      {
         Board.searchAlgorithm = TreeNode_Base.SearchAlgorithm.Depth_First;
      }
   }
}
