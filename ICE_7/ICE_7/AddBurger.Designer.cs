namespace ICE_7
{
    partial class AddBurger
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
            this.tableLayoutPanelAddBurger = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBurgerName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanelAddBurger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAddBurger
            // 
            this.tableLayoutPanelAddBurger.ColumnCount = 2;
            this.tableLayoutPanelAddBurger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddBurger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAddBurger.Controls.Add(this.buttonAddItem, 1, 2);
            this.tableLayoutPanelAddBurger.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanelAddBurger.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelAddBurger.Controls.Add(this.textBoxBurgerName, 1, 0);
            this.tableLayoutPanelAddBurger.Controls.Add(this.buttonCancel, 0, 2);
            this.tableLayoutPanelAddBurger.Controls.Add(this.numericUpDownPrice, 1, 1);
            this.tableLayoutPanelAddBurger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAddBurger.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAddBurger.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanelAddBurger.Name = "tableLayoutPanelAddBurger";
            this.tableLayoutPanelAddBurger.RowCount = 3;
            this.tableLayoutPanelAddBurger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAddBurger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAddBurger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAddBurger.Size = new System.Drawing.Size(395, 145);
            this.tableLayoutPanelAddBurger.TabIndex = 0;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.Green;
            this.buttonAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddItem.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonAddItem.Location = new System.Drawing.Point(202, 101);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(188, 39);
            this.buttonAddItem.TabIndex = 5;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price: $";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBurgerName
            // 
            this.textBoxBurgerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBurgerName.Location = new System.Drawing.Point(202, 9);
            this.textBoxBurgerName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxBurgerName.Name = "textBoxBurgerName";
            this.textBoxBurgerName.Size = new System.Drawing.Size(188, 30);
            this.textBoxBurgerName.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.ForeColor = System.Drawing.Color.SeaShell;
            this.buttonCancel.Location = new System.Drawing.Point(5, 101);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(187, 39);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(202, 57);
            this.numericUpDownPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numericUpDownPrice.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(188, 30);
            this.numericUpDownPrice.TabIndex = 6;
            this.numericUpDownPrice.Value = new decimal(new int[] {
            399,
            0,
            0,
            131072});
            // 
            // AddBurger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(395, 145);
            this.Controls.Add(this.tableLayoutPanelAddBurger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBurger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBurger";
            this.tableLayoutPanelAddBurger.ResumeLayout(false);
            this.tableLayoutPanelAddBurger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddBurger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBurgerName;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
    }
}