namespace Lab3_ExpenseTracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNetBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownBudget = new System.Windows.Forms.NumericUpDown();
            this.textBoxExpenses = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewExpenses = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRemoveExpense = new System.Windows.Forms.Button();
            this.buttonAddExpense = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(506, 74);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Lab3_ExpenseTracker.Properties.Resources.Graphicloads_Flat_Finance_Dollar_256;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 77);
            this.label4.TabIndex = 1;
            this.label4.Text = "Expense Tracker";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxNetBalance, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownBudget, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxExpenses, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 71);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxNetBalance
            // 
            this.textBoxNetBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNetBalance.ForeColor = System.Drawing.Color.White;
            this.textBoxNetBalance.Location = new System.Drawing.Point(354, 31);
            this.textBoxNetBalance.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxNetBalance.Name = "textBoxNetBalance";
            this.textBoxNetBalance.ReadOnly = true;
            this.textBoxNetBalance.Size = new System.Drawing.Size(142, 20);
            this.textBoxNetBalance.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxNetBalance, "Net Balance = Budget - Expenses");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(354, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Net Balance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(182, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expenses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownBudget
            // 
            this.numericUpDownBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownBudget.DecimalPlaces = 2;
            this.numericUpDownBudget.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownBudget.Location = new System.Drawing.Point(10, 32);
            this.numericUpDownBudget.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.numericUpDownBudget.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownBudget.Name = "numericUpDownBudget";
            this.numericUpDownBudget.Size = new System.Drawing.Size(152, 20);
            this.numericUpDownBudget.TabIndex = 3;
            this.numericUpDownBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownBudget.ThousandsSeparator = true;
            this.toolTip1.SetToolTip(this.numericUpDownBudget, "Your budget");
            this.numericUpDownBudget.Value = new decimal(new int[] {
            50000,
            0,
            0,
            131072});
            this.numericUpDownBudget.ValueChanged += new System.EventHandler(this.numericUpDownBudget_ValueChanged);
            this.numericUpDownBudget.Click += new System.EventHandler(this.numericUpDownBudget_ValueChanged);
            // 
            // textBoxExpenses
            // 
            this.textBoxExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExpenses.Location = new System.Drawing.Point(182, 31);
            this.textBoxExpenses.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxExpenses.Name = "textBoxExpenses";
            this.textBoxExpenses.ReadOnly = true;
            this.textBoxExpenses.Size = new System.Drawing.Size(152, 20);
            this.textBoxExpenses.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxExpenses, "Total expenses");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 282);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewExpenses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 234);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewExpenses
            // 
            this.dataGridViewExpenses.AllowUserToAddRows = false;
            this.dataGridViewExpenses.AllowUserToDeleteRows = false;
            this.dataGridViewExpenses.AllowUserToResizeColumns = false;
            this.dataGridViewExpenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Brown;
            this.dataGridViewExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExpenses.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Description,
            this.Amount});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExpenses.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExpenses.GridColor = System.Drawing.Color.Black;
            this.dataGridViewExpenses.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewExpenses.MultiSelect = false;
            this.dataGridViewExpenses.Name = "dataGridViewExpenses";
            this.dataGridViewExpenses.ReadOnly = true;
            this.dataGridViewExpenses.RowHeadersVisible = false;
            this.dataGridViewExpenses.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Wheat;
            this.dataGridViewExpenses.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Maroon;
            this.dataGridViewExpenses.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Linen;
            this.dataGridViewExpenses.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Brown;
            this.dataGridViewExpenses.RowTemplate.ReadOnly = true;
            this.dataGridViewExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExpenses.Size = new System.Drawing.Size(506, 234);
            this.dataGridViewExpenses.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle3;
            this.Date.Frozen = true;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.ToolTipText = "date spent";
            this.Date.Width = 57;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.ToolTipText = "the description of the expense";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.ToolTipText = "Amount Spent";
            this.Amount.Width = 70;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonRemoveExpense, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddExpense, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 234);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(506, 48);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonRemoveExpense
            // 
            this.buttonRemoveExpense.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonRemoveExpense.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonRemoveExpense.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRemoveExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonRemoveExpense.ForeColor = System.Drawing.Color.Black;
            this.buttonRemoveExpense.Location = new System.Drawing.Point(15, 8);
            this.buttonRemoveExpense.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.buttonRemoveExpense.Name = "buttonRemoveExpense";
            this.buttonRemoveExpense.Size = new System.Drawing.Size(166, 32);
            this.buttonRemoveExpense.TabIndex = 0;
            this.buttonRemoveExpense.Text = "Remove Selected Expense";
            this.toolTip1.SetToolTip(this.buttonRemoveExpense, "Click to remove the selected expense from the list");
            this.buttonRemoveExpense.UseVisualStyleBackColor = false;
            this.buttonRemoveExpense.Click += new System.EventHandler(this.buttonRemoveExpense_Click);
            // 
            // buttonAddExpense
            // 
            this.buttonAddExpense.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddExpense.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAddExpense.ForeColor = System.Drawing.Color.Black;
            this.buttonAddExpense.Location = new System.Drawing.Point(364, 8);
            this.buttonAddExpense.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.buttonAddExpense.Name = "buttonAddExpense";
            this.buttonAddExpense.Size = new System.Drawing.Size(127, 32);
            this.buttonAddExpense.TabIndex = 1;
            this.buttonAddExpense.Text = "Add New Expense";
            this.toolTip1.SetToolTip(this.buttonAddExpense, "Click to add a new expense to the list");
            this.buttonAddExpense.UseVisualStyleBackColor = false;
            this.buttonAddExpense.Click += new System.EventHandler(this.buttonAddExpense_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(506, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ExpenseTracker - Subeet Singh";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudget)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenses)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonRemoveExpense;
        private System.Windows.Forms.Button buttonAddExpense;
        private System.Windows.Forms.DataGridView dataGridViewExpenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNetBalance;
        private System.Windows.Forms.NumericUpDown numericUpDownBudget;
        private System.Windows.Forms.TextBox textBoxExpenses;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}

