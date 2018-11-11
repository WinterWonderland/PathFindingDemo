namespace PathFindingDemo
{
   partial class Form_Main
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.numericUpDown_UpdatesPerSeconds = new System.Windows.Forms.NumericUpDown();
         this.label1 = new System.Windows.Forms.Label();
         this.button_Run = new System.Windows.Forms.Button();
         this.button_Init = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label_Steps_Greedy_Search = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.label4 = new System.Windows.Forms.Label();
         this.radioButton_Greedy_Search = new System.Windows.Forms.RadioButton();
         this.radioButton_A_Star = new System.Windows.Forms.RadioButton();
         this.label_Steps_A_Star = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label_SolutionLength_A_Star = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label_SolutionLength_Greedy_Search = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label_SolutionLength_Depth_First = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label_SolutionLength_Breadth_First = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.label_Steps_Depth_First = new System.Windows.Forms.Label();
         this.label13 = new System.Windows.Forms.Label();
         this.radioButton_Depth_First = new System.Windows.Forms.RadioButton();
         this.radioButton_Breadth_First = new System.Windows.Forms.RadioButton();
         this.label_Steps_Breadth_First = new System.Windows.Forms.Label();
         this.label15 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UpdatesPerSeconds)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(12, 81);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(1024, 768);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // numericUpDown_UpdatesPerSeconds
         // 
         this.numericUpDown_UpdatesPerSeconds.DecimalPlaces = 1;
         this.numericUpDown_UpdatesPerSeconds.Location = new System.Drawing.Point(262, 45);
         this.numericUpDown_UpdatesPerSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
         this.numericUpDown_UpdatesPerSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
         this.numericUpDown_UpdatesPerSeconds.Name = "numericUpDown_UpdatesPerSeconds";
         this.numericUpDown_UpdatesPerSeconds.Size = new System.Drawing.Size(54, 20);
         this.numericUpDown_UpdatesPerSeconds.TabIndex = 4;
         this.numericUpDown_UpdatesPerSeconds.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
         this.numericUpDown_UpdatesPerSeconds.ValueChanged += new System.EventHandler(this.numericUpDown_UpdatesPerSeconds_ValueChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(148, 47);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(108, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Updates per Second:";
         // 
         // button_Run
         // 
         this.button_Run.Location = new System.Drawing.Point(93, 12);
         this.button_Run.Name = "button_Run";
         this.button_Run.Size = new System.Drawing.Size(75, 23);
         this.button_Run.TabIndex = 2;
         this.button_Run.Text = "Run";
         this.button_Run.UseVisualStyleBackColor = true;
         this.button_Run.Click += new System.EventHandler(this.button1_Click);
         // 
         // button_Init
         // 
         this.button_Init.Location = new System.Drawing.Point(12, 12);
         this.button_Init.Name = "button_Init";
         this.button_Init.Size = new System.Drawing.Size(75, 23);
         this.button_Init.TabIndex = 1;
         this.button_Init.Text = "Init";
         this.button_Init.UseVisualStyleBackColor = true;
         this.button_Init.Click += new System.EventHandler(this.button2_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(793, 14);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(64, 13);
         this.label2.TabIndex = 5;
         this.label2.Text = "Steps done:";
         // 
         // label_Steps_Greedy_Search
         // 
         this.label_Steps_Greedy_Search.AutoSize = true;
         this.label_Steps_Greedy_Search.Location = new System.Drawing.Point(863, 14);
         this.label_Steps_Greedy_Search.Name = "label_Steps_Greedy_Search";
         this.label_Steps_Greedy_Search.Size = new System.Drawing.Size(13, 13);
         this.label_Steps_Greedy_Search.TabIndex = 6;
         this.label_Steps_Greedy_Search.Text = "0";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 47);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(52, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "Wall tiles:";
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.DecimalPlaces = 1;
         this.numericUpDown1.Location = new System.Drawing.Point(70, 45);
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
         this.numericUpDown1.TabIndex = 3;
         this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
         this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(127, 47);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(15, 13);
         this.label4.TabIndex = 9;
         this.label4.Text = "%";
         // 
         // radioButton_Greedy_Search
         // 
         this.radioButton_Greedy_Search.AutoSize = true;
         this.radioButton_Greedy_Search.Location = new System.Drawing.Point(693, 12);
         this.radioButton_Greedy_Search.Name = "radioButton_Greedy_Search";
         this.radioButton_Greedy_Search.Size = new System.Drawing.Size(99, 17);
         this.radioButton_Greedy_Search.TabIndex = 10;
         this.radioButton_Greedy_Search.Text = "Greedy_Search";
         this.radioButton_Greedy_Search.UseVisualStyleBackColor = true;
         this.radioButton_Greedy_Search.Click += new System.EventHandler(this.radioButton_Fast_Click);
         // 
         // radioButton_A_Star
         // 
         this.radioButton_A_Star.AutoSize = true;
         this.radioButton_A_Star.Location = new System.Drawing.Point(693, 45);
         this.radioButton_A_Star.Name = "radioButton_A_Star";
         this.radioButton_A_Star.Size = new System.Drawing.Size(57, 17);
         this.radioButton_A_Star.TabIndex = 11;
         this.radioButton_A_Star.Text = "A_Star";
         this.radioButton_A_Star.UseVisualStyleBackColor = true;
         this.radioButton_A_Star.Click += new System.EventHandler(this.radioButton_Short_Click);
         // 
         // label_Steps_A_Star
         // 
         this.label_Steps_A_Star.AutoSize = true;
         this.label_Steps_A_Star.Location = new System.Drawing.Point(863, 47);
         this.label_Steps_A_Star.Name = "label_Steps_A_Star";
         this.label_Steps_A_Star.Size = new System.Drawing.Size(13, 13);
         this.label_Steps_A_Star.TabIndex = 13;
         this.label_Steps_A_Star.Text = "0";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(793, 47);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(64, 13);
         this.label6.TabIndex = 12;
         this.label6.Text = "Steps done:";
         // 
         // label_SolutionLength_A_Star
         // 
         this.label_SolutionLength_A_Star.AutoSize = true;
         this.label_SolutionLength_A_Star.Location = new System.Drawing.Point(979, 47);
         this.label_SolutionLength_A_Star.Name = "label_SolutionLength_A_Star";
         this.label_SolutionLength_A_Star.Size = new System.Drawing.Size(13, 13);
         this.label_SolutionLength_A_Star.TabIndex = 17;
         this.label_SolutionLength_A_Star.Text = "0";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(893, 47);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(80, 13);
         this.label7.TabIndex = 16;
         this.label7.Text = "Solution length:";
         // 
         // label_SolutionLength_Greedy_Search
         // 
         this.label_SolutionLength_Greedy_Search.AutoSize = true;
         this.label_SolutionLength_Greedy_Search.Location = new System.Drawing.Point(979, 14);
         this.label_SolutionLength_Greedy_Search.Name = "label_SolutionLength_Greedy_Search";
         this.label_SolutionLength_Greedy_Search.Size = new System.Drawing.Size(13, 13);
         this.label_SolutionLength_Greedy_Search.TabIndex = 15;
         this.label_SolutionLength_Greedy_Search.Text = "0";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(893, 14);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(80, 13);
         this.label9.TabIndex = 14;
         this.label9.Text = "Solution length:";
         // 
         // label_SolutionLength_Depth_First
         // 
         this.label_SolutionLength_Depth_First.AutoSize = true;
         this.label_SolutionLength_Depth_First.Location = new System.Drawing.Point(642, 49);
         this.label_SolutionLength_Depth_First.Name = "label_SolutionLength_Depth_First";
         this.label_SolutionLength_Depth_First.Size = new System.Drawing.Size(13, 13);
         this.label_SolutionLength_Depth_First.TabIndex = 27;
         this.label_SolutionLength_Depth_First.Text = "0";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(556, 49);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(80, 13);
         this.label8.TabIndex = 26;
         this.label8.Text = "Solution length:";
         // 
         // label_SolutionLength_Breadth_First
         // 
         this.label_SolutionLength_Breadth_First.AutoSize = true;
         this.label_SolutionLength_Breadth_First.Location = new System.Drawing.Point(642, 16);
         this.label_SolutionLength_Breadth_First.Name = "label_SolutionLength_Breadth_First";
         this.label_SolutionLength_Breadth_First.Size = new System.Drawing.Size(13, 13);
         this.label_SolutionLength_Breadth_First.TabIndex = 25;
         this.label_SolutionLength_Breadth_First.Text = "0";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(556, 16);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(80, 13);
         this.label11.TabIndex = 24;
         this.label11.Text = "Solution length:";
         // 
         // label_Steps_Depth_First
         // 
         this.label_Steps_Depth_First.AutoSize = true;
         this.label_Steps_Depth_First.Location = new System.Drawing.Point(526, 49);
         this.label_Steps_Depth_First.Name = "label_Steps_Depth_First";
         this.label_Steps_Depth_First.Size = new System.Drawing.Size(13, 13);
         this.label_Steps_Depth_First.TabIndex = 23;
         this.label_Steps_Depth_First.Text = "0";
         // 
         // label13
         // 
         this.label13.AutoSize = true;
         this.label13.Location = new System.Drawing.Point(456, 49);
         this.label13.Name = "label13";
         this.label13.Size = new System.Drawing.Size(64, 13);
         this.label13.TabIndex = 22;
         this.label13.Text = "Steps done:";
         // 
         // radioButton_Depth_First
         // 
         this.radioButton_Depth_First.AutoSize = true;
         this.radioButton_Depth_First.Location = new System.Drawing.Point(356, 47);
         this.radioButton_Depth_First.Name = "radioButton_Depth_First";
         this.radioButton_Depth_First.Size = new System.Drawing.Size(79, 17);
         this.radioButton_Depth_First.TabIndex = 21;
         this.radioButton_Depth_First.Text = "Depth_First";
         this.radioButton_Depth_First.UseVisualStyleBackColor = true;
         this.radioButton_Depth_First.Click += new System.EventHandler(this.radioButton_Depth_First_Click);
         // 
         // radioButton_Breadth_First
         // 
         this.radioButton_Breadth_First.AutoSize = true;
         this.radioButton_Breadth_First.Checked = true;
         this.radioButton_Breadth_First.Location = new System.Drawing.Point(356, 14);
         this.radioButton_Breadth_First.Name = "radioButton_Breadth_First";
         this.radioButton_Breadth_First.Size = new System.Drawing.Size(87, 17);
         this.radioButton_Breadth_First.TabIndex = 20;
         this.radioButton_Breadth_First.TabStop = true;
         this.radioButton_Breadth_First.Text = "Breadth_First";
         this.radioButton_Breadth_First.UseVisualStyleBackColor = true;
         this.radioButton_Breadth_First.Click += new System.EventHandler(this.radioButton_Breadth_First_Click);
         // 
         // label_Steps_Breadth_First
         // 
         this.label_Steps_Breadth_First.AutoSize = true;
         this.label_Steps_Breadth_First.Location = new System.Drawing.Point(526, 16);
         this.label_Steps_Breadth_First.Name = "label_Steps_Breadth_First";
         this.label_Steps_Breadth_First.Size = new System.Drawing.Size(13, 13);
         this.label_Steps_Breadth_First.TabIndex = 19;
         this.label_Steps_Breadth_First.Text = "0";
         // 
         // label15
         // 
         this.label15.AutoSize = true;
         this.label15.Location = new System.Drawing.Point(456, 16);
         this.label15.Name = "label15";
         this.label15.Size = new System.Drawing.Size(64, 13);
         this.label15.TabIndex = 18;
         this.label15.Text = "Steps done:";
         // 
         // Form_Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1048, 865);
         this.Controls.Add(this.label_SolutionLength_Depth_First);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label_SolutionLength_Breadth_First);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.label_Steps_Depth_First);
         this.Controls.Add(this.label13);
         this.Controls.Add(this.radioButton_Depth_First);
         this.Controls.Add(this.radioButton_Breadth_First);
         this.Controls.Add(this.label_Steps_Breadth_First);
         this.Controls.Add(this.label15);
         this.Controls.Add(this.label_SolutionLength_A_Star);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label_SolutionLength_Greedy_Search);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label_Steps_A_Star);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.radioButton_A_Star);
         this.Controls.Add(this.radioButton_Greedy_Search);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.numericUpDown1);
         this.Controls.Add(this.label_Steps_Greedy_Search);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.button_Init);
         this.Controls.Add(this.button_Run);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.numericUpDown_UpdatesPerSeconds);
         this.Controls.Add(this.pictureBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Name = "Form_Main";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Pathfinding Demo";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_UpdatesPerSeconds)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      public System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.NumericUpDown numericUpDown_UpdatesPerSeconds;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button_Run;
      private System.Windows.Forms.Button button_Init;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label_Steps_Greedy_Search;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.RadioButton radioButton_Greedy_Search;
      private System.Windows.Forms.RadioButton radioButton_A_Star;
      private System.Windows.Forms.Label label_Steps_A_Star;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label_SolutionLength_A_Star;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label_SolutionLength_Greedy_Search;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label_SolutionLength_Depth_First;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label_SolutionLength_Breadth_First;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label_Steps_Depth_First;
      private System.Windows.Forms.Label label13;
      private System.Windows.Forms.RadioButton radioButton_Depth_First;
      private System.Windows.Forms.RadioButton radioButton_Breadth_First;
      private System.Windows.Forms.Label label_Steps_Breadth_First;
      private System.Windows.Forms.Label label15;

   }
}