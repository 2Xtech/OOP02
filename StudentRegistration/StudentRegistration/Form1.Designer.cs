namespace StudentRegistration
{
    partial class StudentRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistrationForm));
            splitContainer1 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelStudentNumber = new Label();
            labelName = new Label();
            maskedTextBoxStudentNumber = new MaskedTextBox();
            numericUpDownDurationSemester = new NumericUpDown();
            textBoxName = new TextBox();
            labelProgram = new Label();
            labelDurationSemester = new Label();
            comboBoxProgram = new ComboBox();
            buttonRegister = new Button();
            toolTipTips = new ToolTip(components);
            toolTipError = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationSemester).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonRegister);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(791, 385);
            splitContainer1.SplitterDistance = 254;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelStudentNumber, 0, 0);
            tableLayoutPanel1.Controls.Add(labelName, 0, 1);
            tableLayoutPanel1.Controls.Add(maskedTextBoxStudentNumber, 1, 0);
            tableLayoutPanel1.Controls.Add(numericUpDownDurationSemester, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxName, 1, 1);
            tableLayoutPanel1.Controls.Add(labelProgram, 0, 2);
            tableLayoutPanel1.Controls.Add(labelDurationSemester, 0, 3);
            tableLayoutPanel1.Controls.Add(comboBoxProgram, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.87406F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.87406F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.3082714F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.0676689F));
            tableLayoutPanel1.Size = new Size(791, 254);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelStudentNumber
            // 
            labelStudentNumber.Anchor = AnchorStyles.Right;
            labelStudentNumber.AutoSize = true;
            labelStudentNumber.Location = new Point(157, 12);
            labelStudentNumber.Name = "labelStudentNumber";
            labelStudentNumber.Size = new Size(235, 38);
            labelStudentNumber.TabIndex = 0;
            labelStudentNumber.Text = "Student Number:";
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Location = new Point(292, 75);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 38);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // maskedTextBoxStudentNumber
            // 
            maskedTextBoxStudentNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxStudentNumber.Location = new Point(398, 10);
            maskedTextBoxStudentNumber.Mask = "\\1\\0\\0000000";
            maskedTextBoxStudentNumber.Name = "maskedTextBoxStudentNumber";
            maskedTextBoxStudentNumber.Size = new Size(390, 43);
            maskedTextBoxStudentNumber.TabIndex = 1;
            toolTipTips.SetToolTip(maskedTextBoxStudentNumber, "Your 9 digit student number");
            maskedTextBoxStudentNumber.ValidatingType = typeof(DateTime);
            maskedTextBoxStudentNumber.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // numericUpDownDurationSemester
            // 
            numericUpDownDurationSemester.Anchor = AnchorStyles.Left;
            numericUpDownDurationSemester.AutoSize = true;
            numericUpDownDurationSemester.Location = new Point(398, 198);
            numericUpDownDurationSemester.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDurationSemester.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDurationSemester.Name = "numericUpDownDurationSemester";
            numericUpDownDurationSemester.ReadOnly = true;
            numericUpDownDurationSemester.Size = new Size(69, 43);
            numericUpDownDurationSemester.TabIndex = 4;
            toolTipTips.SetToolTip(numericUpDownDurationSemester, "select how many semesters is your program");
            numericUpDownDurationSemester.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(398, 73);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(390, 43);
            textBoxName.TabIndex = 2;
            toolTipTips.SetToolTip(textBoxName, "Your Name");
            // 
            // labelProgram
            // 
            labelProgram.Anchor = AnchorStyles.Right;
            labelProgram.AutoSize = true;
            labelProgram.Location = new Point(258, 136);
            labelProgram.Name = "labelProgram";
            labelProgram.Size = new Size(134, 38);
            labelProgram.TabIndex = 2;
            labelProgram.Text = "Program:";
            // 
            // labelDurationSemester
            // 
            labelDurationSemester.Anchor = AnchorStyles.Right;
            labelDurationSemester.AutoSize = true;
            labelDurationSemester.Location = new Point(100, 200);
            labelDurationSemester.Name = "labelDurationSemester";
            labelDurationSemester.Size = new Size(292, 38);
            labelDurationSemester.TabIndex = 3;
            labelDurationSemester.Text = "Duration in Semester:";
            // 
            // comboBoxProgram
            // 
            comboBoxProgram.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProgram.FormattingEnabled = true;
            comboBoxProgram.Items.AddRange(new object[] { "Computer Programming", "Computer Systems", "Game Development" });
            comboBoxProgram.Location = new Point(398, 141);
            comboBoxProgram.Name = "comboBoxProgram";
            comboBoxProgram.Size = new Size(390, 45);
            comboBoxProgram.TabIndex = 3;
            toolTipTips.SetToolTip(comboBoxProgram, "program you're enrolled in");
            comboBoxProgram.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.None;
            buttonRegister.AutoSize = true;
            buttonRegister.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.Location = new Point(292, 40);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(160, 56);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Register";
            toolTipTips.SetToolTip(buttonRegister, "Click to register!");
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // toolTipError
            // 
            toolTipError.ToolTipIcon = ToolTipIcon.Error;
            // 
            // StudentRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 385);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StudentRegistrationForm";
            Text = "SubeetSingh-ICE1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDurationSemester).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelStudentNumber;
        private Label labelName;
        private Label labelDurationSemester;
        private Label labelProgram;
        private MaskedTextBox maskedTextBoxStudentNumber;
        private ComboBox comboBoxProgram;
        private NumericUpDown numericUpDownDurationSemester;
        private Button buttonRegister;
        private TextBox textBoxName;
        private ToolTip toolTipTips;
        private ToolTip toolTipError;
    }
}
