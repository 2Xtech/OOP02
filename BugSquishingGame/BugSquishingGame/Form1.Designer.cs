namespace BugSquishingGame
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelScoreCounter = new System.Windows.Forms.Label();
            this.labelGameTime = new System.Windows.Forms.Label();
            this.panelBugSpawn = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerGameTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBlood = new System.Windows.Forms.PictureBox();
            this.pictureBoxBug = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBugSpawn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBug)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Khaki;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelScoreCounter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelGameTime, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelScoreCounter
            // 
            this.labelScoreCounter.AutoSize = true;
            this.labelScoreCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelScoreCounter.Location = new System.Drawing.Point(3, 0);
            this.labelScoreCounter.Name = "labelScoreCounter";
            this.labelScoreCounter.Size = new System.Drawing.Size(394, 52);
            this.labelScoreCounter.TabIndex = 0;
            this.labelScoreCounter.Text = "SCORE: 0";
            this.labelScoreCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGameTime
            // 
            this.labelGameTime.AutoSize = true;
            this.labelGameTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGameTime.Location = new System.Drawing.Point(403, 0);
            this.labelGameTime.Name = "labelGameTime";
            this.labelGameTime.Size = new System.Drawing.Size(394, 52);
            this.labelGameTime.TabIndex = 1;
            this.labelGameTime.Text = "TIME LEFT: 00";
            this.labelGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBugSpawn
            // 
            this.panelBugSpawn.BackgroundImage = global::BugSquishingGame.Properties.Resources.BackgroundTexture;
            this.panelBugSpawn.Controls.Add(this.buttonStart);
            this.panelBugSpawn.Controls.Add(this.pictureBoxBlood);
            this.panelBugSpawn.Controls.Add(this.pictureBoxBug);
            this.panelBugSpawn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBugSpawn.Location = new System.Drawing.Point(0, 52);
            this.panelBugSpawn.Name = "panelBugSpawn";
            this.panelBugSpawn.Size = new System.Drawing.Size(800, 398);
            this.panelBugSpawn.TabIndex = 1;
            this.panelBugSpawn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBugSpawn_Paint);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(338, 137);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(116, 84);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerGameTime
            // 
            this.timerGameTime.Interval = 1000;
            this.timerGameTime.Tick += new System.EventHandler(this.TimerGameTime_Tick);
            // 
            // pictureBoxBlood
            // 
            this.pictureBoxBlood.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBlood.Image = global::BugSquishingGame.Properties.Resources.Blood;
            this.pictureBoxBlood.Location = new System.Drawing.Point(542, 163);
            this.pictureBoxBlood.Name = "pictureBoxBlood";
            this.pictureBoxBlood.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxBlood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBlood.TabIndex = 1;
            this.pictureBoxBlood.TabStop = false;
            this.pictureBoxBlood.Visible = false;
            // 
            // pictureBoxBug
            // 
            this.pictureBoxBug.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBug.Location = new System.Drawing.Point(374, 177);
            this.pictureBoxBug.Name = "pictureBoxBug";
            this.pictureBoxBug.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxBug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBug.TabIndex = 0;
            this.pictureBoxBug.TabStop = false;
            this.pictureBoxBug.Visible = false;
            this.pictureBoxBug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBug_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBugSpawn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Bug Squash Game - Subeet Singh";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBugSpawn.ResumeLayout(false);
            this.panelBugSpawn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelScoreCounter;
        private System.Windows.Forms.Label labelGameTime;
        private System.Windows.Forms.Panel panelBugSpawn;
        private System.Windows.Forms.PictureBox pictureBoxBug;
        private System.Windows.Forms.Timer timerGameTime;
        private System.Windows.Forms.PictureBox pictureBoxBlood;
        private System.Windows.Forms.Button buttonStart;
    }
}

