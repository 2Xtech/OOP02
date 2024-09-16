namespace Lab1_Subeet_Singh
{
    partial class FormDogYearsConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDogYearsConverter));
            panel1 = new Panel();
            buttonCalculate = new Button();
            textBoxDogAgeDogYears = new TextBox();
            numericUpDownDogAgeHumanYears = new NumericUpDown();
            labelDogAgeDogYears = new Label();
            labelDogAgeHumanYears = new Label();
            toolTipTips = new ToolTip(components);
            toolTipError = new ToolTip(components);
            buttonReset = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDogAgeHumanYears).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonReset);
            panel1.Controls.Add(buttonCalculate);
            panel1.Controls.Add(textBoxDogAgeDogYears);
            panel1.Controls.Add(numericUpDownDogAgeHumanYears);
            panel1.Controls.Add(labelDogAgeDogYears);
            panel1.Controls.Add(labelDogAgeHumanYears);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 236);
            panel1.TabIndex = 2;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(285, 164);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(152, 52);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Calculate";
            toolTipTips.SetToolTip(buttonCalculate, "Click to Calculate");
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxDogAgeDogYears
            // 
            textBoxDogAgeDogYears.Location = new Point(357, 97);
            textBoxDogAgeDogYears.Name = "textBoxDogAgeDogYears";
            textBoxDogAgeDogYears.ReadOnly = true;
            textBoxDogAgeDogYears.Size = new Size(80, 44);
            textBoxDogAgeDogYears.TabIndex = 3;
            toolTipTips.SetToolTip(textBoxDogAgeDogYears, "Age of your dog in dog years");
            // 
            // numericUpDownDogAgeHumanYears
            // 
            numericUpDownDogAgeHumanYears.ImeMode = ImeMode.NoControl;
            numericUpDownDogAgeHumanYears.Location = new Point(357, 40);
            numericUpDownDogAgeHumanYears.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            numericUpDownDogAgeHumanYears.Name = "numericUpDownDogAgeHumanYears";
            numericUpDownDogAgeHumanYears.Size = new Size(80, 44);
            numericUpDownDogAgeHumanYears.TabIndex = 2;
            toolTipTips.SetToolTip(numericUpDownDogAgeHumanYears, "Enter the age of your dog in human years");
            // 
            // labelDogAgeDogYears
            // 
            labelDogAgeDogYears.AutoSize = true;
            labelDogAgeDogYears.Location = new Point(74, 104);
            labelDogAgeDogYears.Name = "labelDogAgeDogYears";
            labelDogAgeDogYears.Size = new Size(277, 37);
            labelDogAgeDogYears.TabIndex = 1;
            labelDogAgeDogYears.Text = "Dog age in dog years:";
            // 
            // labelDogAgeHumanYears
            // 
            labelDogAgeHumanYears.AutoSize = true;
            labelDogAgeHumanYears.Location = new Point(34, 47);
            labelDogAgeHumanYears.Name = "labelDogAgeHumanYears";
            labelDogAgeHumanYears.Size = new Size(317, 37);
            labelDogAgeHumanYears.TabIndex = 0;
            labelDogAgeHumanYears.Text = "Dog age in human years:";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(34, 164);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(109, 52);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // FormDogYearsConverter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 236);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDogYearsConverter";
            Text = "Dog Age Converter - Subeet Singh";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDogAgeHumanYears).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown numericUpDownDogAgeHumanYears;
        private Label labelDogAgeDogYears;
        private Label labelDogAgeHumanYears;
        private TextBox textBoxDogAgeDogYears;
        private Button buttonCalculate;
        private ToolTip toolTipTips;
        private ToolTip toolTipError;
        private Button buttonReset;
    }
}
