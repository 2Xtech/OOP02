namespace Lab2_TicTacToe
{
    partial class Form1
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
            this.panelDetails = new System.Windows.Forms.Panel();
            this.groupBoxWinner = new System.Windows.Forms.GroupBox();
            this.labelWinner = new System.Windows.Forms.Label();
            this.groupBoxScore = new System.Windows.Forms.GroupBox();
            this.textBoxOScore = new System.Windows.Forms.TextBox();
            this.textBoxXScore = new System.Windows.Forms.TextBox();
            this.groupBoxPlayerNames = new System.Windows.Forms.GroupBox();
            this.textBoxPlayerO = new System.Windows.Forms.TextBox();
            this.textBoxPlayerX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxGameArea = new System.Windows.Forms.GroupBox();
            this.buttonNextRound = new System.Windows.Forms.Button();
            this.tableLayoutPanelGame = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTurn = new System.Windows.Forms.Label();
            this.panelDetails.SuspendLayout();
            this.groupBoxWinner.SuspendLayout();
            this.groupBoxScore.SuspendLayout();
            this.groupBoxPlayerNames.SuspendLayout();
            this.groupBoxGameArea.SuspendLayout();
            this.tableLayoutPanelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.groupBoxWinner);
            this.panelDetails.Controls.Add(this.groupBoxScore);
            this.panelDetails.Controls.Add(this.groupBoxPlayerNames);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Padding = new System.Windows.Forms.Padding(5);
            this.panelDetails.Size = new System.Drawing.Size(619, 134);
            this.panelDetails.TabIndex = 0;
            // 
            // groupBoxWinner
            // 
            this.groupBoxWinner.Controls.Add(this.labelWinner);
            this.groupBoxWinner.Location = new System.Drawing.Point(536, 4);
            this.groupBoxWinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxWinner.Name = "groupBoxWinner";
            this.groupBoxWinner.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxWinner.Size = new System.Drawing.Size(80, 127);
            this.groupBoxWinner.TabIndex = 2;
            this.groupBoxWinner.TabStop = false;
            this.groupBoxWinner.Text = "Winner";
            // 
            // labelWinner
            // 
            this.labelWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWinner.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinner.Location = new System.Drawing.Point(5, 24);
            this.labelWinner.Margin = new System.Windows.Forms.Padding(5);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(70, 98);
            this.labelWinner.TabIndex = 0;
            this.labelWinner.Text = "-";
            this.labelWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxScore
            // 
            this.groupBoxScore.Controls.Add(this.textBoxOScore);
            this.groupBoxScore.Controls.Add(this.textBoxXScore);
            this.groupBoxScore.Location = new System.Drawing.Point(448, 4);
            this.groupBoxScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxScore.Name = "groupBoxScore";
            this.groupBoxScore.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxScore.Size = new System.Drawing.Size(81, 127);
            this.groupBoxScore.TabIndex = 1;
            this.groupBoxScore.TabStop = false;
            this.groupBoxScore.Text = "Score";
            // 
            // textBoxOScore
            // 
            this.textBoxOScore.Location = new System.Drawing.Point(22, 81);
            this.textBoxOScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOScore.Name = "textBoxOScore";
            this.textBoxOScore.ReadOnly = true;
            this.textBoxOScore.Size = new System.Drawing.Size(51, 26);
            this.textBoxOScore.TabIndex = 1;
            this.textBoxOScore.Text = "0";
            // 
            // textBoxXScore
            // 
            this.textBoxXScore.Location = new System.Drawing.Point(22, 34);
            this.textBoxXScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxXScore.Name = "textBoxXScore";
            this.textBoxXScore.ReadOnly = true;
            this.textBoxXScore.Size = new System.Drawing.Size(51, 26);
            this.textBoxXScore.TabIndex = 0;
            this.textBoxXScore.Text = "0";
            // 
            // groupBoxPlayerNames
            // 
            this.groupBoxPlayerNames.Controls.Add(this.textBoxPlayerO);
            this.groupBoxPlayerNames.Controls.Add(this.textBoxPlayerX);
            this.groupBoxPlayerNames.Controls.Add(this.label2);
            this.groupBoxPlayerNames.Controls.Add(this.label1);
            this.groupBoxPlayerNames.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPlayerNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPlayerNames.Name = "groupBoxPlayerNames";
            this.groupBoxPlayerNames.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxPlayerNames.Size = new System.Drawing.Size(238, 134);
            this.groupBoxPlayerNames.TabIndex = 0;
            this.groupBoxPlayerNames.TabStop = false;
            this.groupBoxPlayerNames.Text = "Player Names";
            // 
            // textBoxPlayerO
            // 
            this.textBoxPlayerO.Location = new System.Drawing.Point(82, 81);
            this.textBoxPlayerO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlayerO.Name = "textBoxPlayerO";
            this.textBoxPlayerO.Size = new System.Drawing.Size(112, 26);
            this.textBoxPlayerO.TabIndex = 3;
            this.textBoxPlayerO.Leave += new System.EventHandler(this.textBoxPlayer_TextChanged);
            // 
            // textBoxPlayerX
            // 
            this.textBoxPlayerX.Location = new System.Drawing.Point(82, 34);
            this.textBoxPlayerX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPlayerX.Name = "textBoxPlayerX";
            this.textBoxPlayerX.Size = new System.Drawing.Size(112, 26);
            this.textBoxPlayerX.TabIndex = 2;
            this.textBoxPlayerX.Leave += new System.EventHandler(this.textBoxPlayer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "O";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // groupBoxGameArea
            // 
            this.groupBoxGameArea.Controls.Add(this.buttonNextRound);
            this.groupBoxGameArea.Controls.Add(this.tableLayoutPanelGame);
            this.groupBoxGameArea.Controls.Add(this.labelTurn);
            this.groupBoxGameArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGameArea.Location = new System.Drawing.Point(0, 134);
            this.groupBoxGameArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxGameArea.Name = "groupBoxGameArea";
            this.groupBoxGameArea.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxGameArea.Size = new System.Drawing.Size(619, 400);
            this.groupBoxGameArea.TabIndex = 1;
            this.groupBoxGameArea.TabStop = false;
            this.groupBoxGameArea.Text = "Game Area";
            // 
            // buttonNextRound
            // 
            this.buttonNextRound.BackColor = System.Drawing.Color.Tomato;
            this.buttonNextRound.ForeColor = System.Drawing.Color.White;
            this.buttonNextRound.Location = new System.Drawing.Point(238, 45);
            this.buttonNextRound.Name = "buttonNextRound";
            this.buttonNextRound.Size = new System.Drawing.Size(137, 54);
            this.buttonNextRound.TabIndex = 2;
            this.buttonNextRound.Text = "Next Round";
            this.buttonNextRound.UseVisualStyleBackColor = false;
            this.buttonNextRound.Visible = false;
            this.buttonNextRound.Click += new System.EventHandler(this.buttonNextRound_Click);
            // 
            // tableLayoutPanelGame
            // 
            this.tableLayoutPanelGame.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanelGame.ColumnCount = 3;
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanelGame.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanelGame.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanelGame.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanelGame.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanelGame.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanelGame.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanelGame.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanelGame.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanelGame.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanelGame.Location = new System.Drawing.Point(135, 68);
            this.tableLayoutPanelGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelGame.Name = "tableLayoutPanelGame";
            this.tableLayoutPanelGame.RowCount = 3;
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGame.Size = new System.Drawing.Size(341, 304);
            this.tableLayoutPanelGame.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(230, 207);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 90);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(118, 207);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(103, 90);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(6, 207);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 90);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(230, 107);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 89);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(118, 107);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 89);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(6, 107);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 89);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(230, 7);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 89);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(118, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 89);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 89);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // labelTurn
            // 
            this.labelTurn.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTurn.Location = new System.Drawing.Point(3, 23);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(613, 19);
            this.labelTurn.TabIndex = 0;
            this.labelTurn.Text = "Good Luck!!";
            this.labelTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(619, 534);
            this.Controls.Add(this.groupBoxGameArea);
            this.Controls.Add(this.panelDetails);
            this.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Lab2_TicTacToe - Subeet Singh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDetails.ResumeLayout(false);
            this.groupBoxWinner.ResumeLayout(false);
            this.groupBoxScore.ResumeLayout(false);
            this.groupBoxScore.PerformLayout();
            this.groupBoxPlayerNames.ResumeLayout(false);
            this.groupBoxPlayerNames.PerformLayout();
            this.groupBoxGameArea.ResumeLayout(false);
            this.tableLayoutPanelGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.GroupBox groupBoxPlayerNames;
        private System.Windows.Forms.GroupBox groupBoxWinner;
        private System.Windows.Forms.GroupBox groupBoxScore;
        private System.Windows.Forms.GroupBox groupBoxGameArea;
        private System.Windows.Forms.TextBox textBoxPlayerO;
        private System.Windows.Forms.TextBox textBoxPlayerX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGame;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxOScore;
        private System.Windows.Forms.TextBox textBoxXScore;
        private System.Windows.Forms.Label labelWinner;
        private System.Windows.Forms.Button buttonNextRound;
    }
}

