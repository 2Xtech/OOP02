namespace FormTest
{
    partial class ICE_0
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
            label1 = new Label();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ink Free", 25.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(237, 70);
            label1.Name = "label1";
            label1.Size = new Size(387, 53);
            label1.TabIndex = 0;
            label1.Text = "HELLO C# WORLD";
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(376, 140);
            button1.Name = "button1";
            button1.Size = new Size(129, 65);
            button1.TabIndex = 1;
            button1.Text = "YO";
            toolTip1.SetToolTip(button1, "bgrrsgh");
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // toolTip1
            // 
            toolTip1.BackColor = Color.Gray;
            toolTip1.ForeColor = Color.Ivory;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Ink Free", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(237, 282);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Your Name goes here";
            textBox1.Size = new Size(268, 36);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(511, 282);
            button2.Name = "button2";
            button2.Size = new Size(95, 36);
            button2.TabIndex = 3;
            button2.Text = "GREET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Ink Free", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(376, 367);
            label2.Name = "label2";
            label2.Size = new Size(0, 46);
            label2.TabIndex = 4;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            label2.Click += label2_Click_1;
            // 
            // ICE_0
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(869, 475);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ICE_0";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ICE_0-Subeet Singh";
            toolTip1.SetToolTip(this, "lol");
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ToolTip toolTip1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
    }
}
