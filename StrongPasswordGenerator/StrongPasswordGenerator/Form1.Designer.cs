namespace StrongPasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRandomPassword = new System.Windows.Forms.Button();
            this.checkBoxViewPassword = new System.Windows.Forms.CheckBox();
            this.progressBarPasswordStrength = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanelRequirements = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.flowLayoutPanelRequirements.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelButtons, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBarPasswordStrength, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelRequirements, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(674, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password strength:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(674, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Requirements:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(3, 60);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(674, 34);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.buttonRandomPassword);
            this.flowLayoutPanelButtons.Controls.Add(this.checkBoxViewPassword);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(3, 117);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(674, 51);
            this.flowLayoutPanelButtons.TabIndex = 4;
            // 
            // buttonRandomPassword
            // 
            this.buttonRandomPassword.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonRandomPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRandomPassword.BackgroundImage")));
            this.buttonRandomPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRandomPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRandomPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRandomPassword.FlatAppearance.BorderSize = 0;
            this.buttonRandomPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRandomPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRandomPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRandomPassword.Location = new System.Drawing.Point(3, 3);
            this.buttonRandomPassword.Name = "buttonRandomPassword";
            this.buttonRandomPassword.Size = new System.Drawing.Size(75, 51);
            this.buttonRandomPassword.TabIndex = 0;
            this.buttonRandomPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonRandomPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonRandomPassword.UseVisualStyleBackColor = false;
            this.buttonRandomPassword.Click += new System.EventHandler(this.buttonRandomPassword_Click);
            // 
            // checkBoxViewPassword
            // 
            this.checkBoxViewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBoxViewPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxViewPassword.BackgroundImage = global::StrongPasswordGenerator.Properties.Resources.Hidden;
            this.checkBoxViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBoxViewPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxViewPassword.FlatAppearance.BorderSize = 0;
            this.checkBoxViewPassword.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.checkBoxViewPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.checkBoxViewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.checkBoxViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxViewPassword.Location = new System.Drawing.Point(84, 3);
            this.checkBoxViewPassword.Name = "checkBoxViewPassword";
            this.checkBoxViewPassword.Size = new System.Drawing.Size(69, 51);
            this.checkBoxViewPassword.TabIndex = 1;
            this.checkBoxViewPassword.UseVisualStyleBackColor = true;
            this.checkBoxViewPassword.CheckStateChanged += new System.EventHandler(this.checkBoxViewPassword_CheckedChanged);
            // 
            // progressBarPasswordStrength
            // 
            this.progressBarPasswordStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarPasswordStrength.Location = new System.Drawing.Point(3, 231);
            this.progressBarPasswordStrength.Name = "progressBarPasswordStrength";
            this.progressBarPasswordStrength.Size = new System.Drawing.Size(674, 51);
            this.progressBarPasswordStrength.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPasswordStrength.TabIndex = 5;
            // 
            // flowLayoutPanelRequirements
            // 
            this.flowLayoutPanelRequirements.Controls.Add(this.label4);
            this.flowLayoutPanelRequirements.Controls.Add(this.label5);
            this.flowLayoutPanelRequirements.Controls.Add(this.label6);
            this.flowLayoutPanelRequirements.Controls.Add(this.label7);
            this.flowLayoutPanelRequirements.Controls.Add(this.label8);
            this.flowLayoutPanelRequirements.Location = new System.Drawing.Point(3, 345);
            this.flowLayoutPanelRequirements.Name = "flowLayoutPanelRequirements";
            this.flowLayoutPanelRequirements.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flowLayoutPanelRequirements.Size = new System.Drawing.Size(674, 53);
            this.flowLayoutPanelRequirements.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 53);
            this.label4.TabIndex = 0;
            this.label4.Text = "a-z";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Location = new System.Drawing.Point(117, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 53);
            this.label5.TabIndex = 1;
            this.label5.Text = "A-Z";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(225, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 53);
            this.label6.TabIndex = 2;
            this.label6.Text = "0-9";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(331, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 53);
            this.label7.TabIndex = 3;
            this.label7.Text = "@^$%#";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Salmon;
            this.label8.Location = new System.Drawing.Point(427, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 53);
            this.label8.TabIndex = 4;
            this.label8.Text = "10 chars";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(700, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Strong Password Generator - Subeet Singh";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.flowLayoutPanelRequirements.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonRandomPassword;
        private System.Windows.Forms.CheckBox checkBoxViewPassword;
        private System.Windows.Forms.ProgressBar progressBarPasswordStrength;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRequirements;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

