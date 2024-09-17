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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBoxGeneration = new PictureBox();
            labelGenerationMotto = new Label();
            labelGenerationName = new Label();
            labelGen = new Label();
            buttonShowResult = new Button();
            buttonClear = new Button();
            dateTimePickerBirthDate = new DateTimePicker();
            labelBirthdate = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGeneration).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelGen);
            panel1.Controls.Add(buttonShowResult);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(dateTimePickerBirthDate);
            panel1.Controls.Add(labelBirthdate);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 524);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBoxGeneration);
            panel2.Controls.Add(labelGenerationMotto);
            panel2.Controls.Add(labelGenerationName);
            panel2.Location = new Point(12, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 311);
            panel2.TabIndex = 5;
            // 
            // pictureBoxGeneration
            // 
            pictureBoxGeneration.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxGeneration.Location = new Point(149, 86);
            pictureBoxGeneration.Name = "pictureBoxGeneration";
            pictureBoxGeneration.Size = new Size(128, 128);
            pictureBoxGeneration.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGeneration.TabIndex = 3;
            pictureBoxGeneration.TabStop = false;
            // 
            // labelGenerationMotto
            // 
            labelGenerationMotto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelGenerationMotto.AutoSize = true;
            labelGenerationMotto.Font = new Font("Lucida Bright", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGenerationMotto.Location = new Point(21, 251);
            labelGenerationMotto.Name = "labelGenerationMotto";
            labelGenerationMotto.Size = new Size(0, 20);
            labelGenerationMotto.TabIndex = 2;
            labelGenerationMotto.TextAlign = ContentAlignment.MiddleCenter;
            labelGenerationMotto.Click += label5_Click;
            // 
            // labelGenerationName
            // 
            labelGenerationName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelGenerationName.AutoSize = true;
            labelGenerationName.Location = new Point(149, 9);
            labelGenerationName.Name = "labelGenerationName";
            labelGenerationName.Size = new Size(0, 26);
            labelGenerationName.TabIndex = 0;
            labelGenerationName.TextAlign = ContentAlignment.MiddleCenter;
            labelGenerationName.Click += label3_Click;
            // 
            // labelGen
            // 
            labelGen.AutoSize = true;
            labelGen.Location = new Point(12, 172);
            labelGen.Name = "labelGen";
            labelGen.Size = new Size(225, 26);
            labelGen.TabIndex = 4;
            labelGen.Text = "Your generation is";
            // 
            // buttonShowResult
            // 
            buttonShowResult.Location = new Point(275, 116);
            buttonShowResult.Name = "buttonShowResult";
            buttonShowResult.Size = new Size(170, 40);
            buttonShowResult.TabIndex = 3;
            buttonShowResult.Text = "Show Result";
            toolTip1.SetToolTip(buttonShowResult, "Click to display the results");
            buttonShowResult.UseVisualStyleBackColor = true;
            buttonShowResult.Click += buttonShowResult_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(12, 116);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(114, 40);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Clear";
            toolTip1.SetToolTip(buttonClear, "Click to reset the date");
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(12, 56);
            dateTimePickerBirthDate.MaxDate = new DateTime(2024, 9, 16, 0, 0, 0, 0);
            dateTimePickerBirthDate.MinDate = new DateTime(1928, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(433, 35);
            dateTimePickerBirthDate.TabIndex = 1;
            toolTip1.SetToolTip(dateTimePickerBirthDate, "pick your birthdate");
            dateTimePickerBirthDate.Value = new DateTime(2024, 9, 16, 0, 0, 0, 0);
            // 
            // labelBirthdate
            // 
            labelBirthdate.AutoSize = true;
            labelBirthdate.Location = new Point(12, 9);
            labelBirthdate.Name = "labelBirthdate";
            labelBirthdate.Size = new Size(232, 26);
            labelBirthdate.TabIndex = 0;
            labelBirthdate.Text = "Pick your birthdate";
            labelBirthdate.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 524);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private DateTimePicker dateTimePickerBirthDate;
        private Label labelBirthdate;
        private Panel panel2;
        private PictureBox pictureBoxGeneration;
        private Label labelGenerationMotto;
        private Label labelGenerationName;
        private Label labelGen;
        private Button buttonShowResult;
        private ToolTip toolTip1;
    }
}
