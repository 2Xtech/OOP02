namespace Generations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBoxGeneration = new PictureBox();
            labelGenerationMotto = new Label();
            labelGenerationName = new Label();
            label2 = new Label();
            buttonShowResult = new Button();
            buttonClear = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGeneration).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonShowResult);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBoxGeneration);
            panel2.Controls.Add(labelGenerationMotto);
            panel2.Controls.Add(labelGenerationName);
            panel2.Location = new Point(147, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 187);
            panel2.TabIndex = 5;
            // 
            // pictureBoxGeneration
            // 
            pictureBoxGeneration.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxGeneration.Location = new Point(151, 60);
            pictureBoxGeneration.Name = "pictureBoxGeneration";
            pictureBoxGeneration.Size = new Size(125, 62);
            pictureBoxGeneration.TabIndex = 3;
            pictureBoxGeneration.TabStop = false;
            // 
            // labelGenerationMotto
            // 
            labelGenerationMotto.Anchor = AnchorStyles.Bottom;
            labelGenerationMotto.AutoSize = true;
            labelGenerationMotto.Location = new Point(159, 151);
            labelGenerationMotto.Name = "labelGenerationMotto";
            labelGenerationMotto.Size = new Size(79, 26);
            labelGenerationMotto.TabIndex = 2;
            labelGenerationMotto.Text = "Motto";
            labelGenerationMotto.TextAlign = ContentAlignment.MiddleCenter;
            labelGenerationMotto.Click += label5_Click;
            // 
            // labelGenerationName
            // 
            labelGenerationName.Anchor = AnchorStyles.Top;
            labelGenerationName.AutoSize = true;
            labelGenerationName.Location = new Point(159, 18);
            labelGenerationName.Name = "labelGenerationName";
            labelGenerationName.Size = new Size(117, 26);
            labelGenerationName.TabIndex = 0;
            labelGenerationName.Text = "genName";
            labelGenerationName.TextAlign = ContentAlignment.MiddleCenter;
            labelGenerationName.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 172);
            label2.Name = "label2";
            label2.Size = new Size(225, 26);
            label2.TabIndex = 4;
            label2.Text = "Your generation is";
            // 
            // buttonShowResult
            // 
            buttonShowResult.Location = new Point(410, 116);
            buttonShowResult.Name = "buttonShowResult";
            buttonShowResult.Size = new Size(170, 40);
            buttonShowResult.TabIndex = 3;
            buttonShowResult.Text = "Show Result";
            buttonShowResult.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(147, 116);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(114, 40);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 75);
            dateTimePicker1.MaxDate = new DateTime(2024, 9, 16, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(433, 35);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2024, 9, 16, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 33);
            label1.Name = "label1";
            label1.Size = new Size(232, 26);
            label1.TabIndex = 0;
            label1.Text = "Pick your birthdate";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Generations-Subeet";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGeneration).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonClear;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBoxGeneration;
        private Label labelGenerationMotto;
        private Label labelGenerationName;
        private Label label2;
        private Button buttonShowResult;
    }
}
