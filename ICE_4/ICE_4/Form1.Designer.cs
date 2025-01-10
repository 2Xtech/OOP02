namespace ICE_4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStack = new System.Windows.Forms.TabPage();
            this.dataGridViewStack = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPopStack = new System.Windows.Forms.Button();
            this.buttonPushStack = new System.Windows.Forms.Button();
            this.textBoxPopElement = new System.Windows.Forms.TextBox();
            this.textBoxPushElement = new System.Windows.Forms.TextBox();
            this.tabPageQueue = new System.Windows.Forms.TabPage();
            this.dataGridViewQueue = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDequeue = new System.Windows.Forms.Button();
            this.buttonEnqueue = new System.Windows.Forms.Button();
            this.textBoxDequeueElement = new System.Windows.Forms.TextBox();
            this.textBoxEnqueueElement = new System.Windows.Forms.TextBox();
            this.panelTitle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStack)).BeginInit();
            this.tabPageQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 135);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(214, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(306, 75);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Stack - FILO";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageStack);
            this.tabControl1.Controls.Add(this.tabPageQueue);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 315);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.ChangedTabs);
            // 
            // tabPageStack
            // 
            this.tabPageStack.BackColor = System.Drawing.Color.Teal;
            this.tabPageStack.Controls.Add(this.dataGridViewStack);
            this.tabPageStack.Controls.Add(this.label4);
            this.tabPageStack.Controls.Add(this.label1);
            this.tabPageStack.Controls.Add(this.buttonPopStack);
            this.tabPageStack.Controls.Add(this.buttonPushStack);
            this.tabPageStack.Controls.Add(this.textBoxPopElement);
            this.tabPageStack.Controls.Add(this.textBoxPushElement);
            this.tabPageStack.Location = new System.Drawing.Point(4, 32);
            this.tabPageStack.Name = "tabPageStack";
            this.tabPageStack.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStack.Size = new System.Drawing.Size(792, 279);
            this.tabPageStack.TabIndex = 0;
            this.tabPageStack.Text = "Stack";
            // 
            // dataGridViewStack
            // 
            this.dataGridViewStack.AllowUserToAddRows = false;
            this.dataGridViewStack.AllowUserToDeleteRows = false;
            this.dataGridViewStack.AllowUserToResizeColumns = false;
            this.dataGridViewStack.AllowUserToResizeRows = false;
            this.dataGridViewStack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStack.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStack.ColumnHeadersHeight = 29;
            this.dataGridViewStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStack.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStack.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStack.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewStack.Location = new System.Drawing.Point(291, 35);
            this.dataGridViewStack.MultiSelect = false;
            this.dataGridViewStack.Name = "dataGridViewStack";
            this.dataGridViewStack.ReadOnly = true;
            this.dataGridViewStack.RowHeadersVisible = false;
            this.dataGridViewStack.RowHeadersWidth = 51;
            this.dataGridViewStack.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStack.RowTemplate.Height = 24;
            this.dataGridViewStack.ShowEditingIcon = false;
            this.dataGridViewStack.Size = new System.Drawing.Size(214, 215);
            this.dataGridViewStack.TabIndex = 1;
            this.dataGridViewStack.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bottom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top";
            // 
            // buttonPopStack
            // 
            this.buttonPopStack.AutoSize = true;
            this.buttonPopStack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPopStack.Location = new System.Drawing.Point(635, 71);
            this.buttonPopStack.Name = "buttonPopStack";
            this.buttonPopStack.Size = new System.Drawing.Size(102, 33);
            this.buttonPopStack.TabIndex = 3;
            this.buttonPopStack.Text = "Pop";
            this.buttonPopStack.UseVisualStyleBackColor = true;
            this.buttonPopStack.Click += new System.EventHandler(this.buttonPopStack_Click);
            // 
            // buttonPushStack
            // 
            this.buttonPushStack.AutoSize = true;
            this.buttonPushStack.Location = new System.Drawing.Point(106, 71);
            this.buttonPushStack.Name = "buttonPushStack";
            this.buttonPushStack.Size = new System.Drawing.Size(102, 33);
            this.buttonPushStack.TabIndex = 2;
            this.buttonPushStack.Text = "Push";
            this.buttonPushStack.UseVisualStyleBackColor = true;
            this.buttonPushStack.Click += new System.EventHandler(this.buttonPushStack_Click);
            // 
            // textBoxPopElement
            // 
            this.textBoxPopElement.Location = new System.Drawing.Point(580, 35);
            this.textBoxPopElement.Name = "textBoxPopElement";
            this.textBoxPopElement.ReadOnly = true;
            this.textBoxPopElement.Size = new System.Drawing.Size(157, 30);
            this.textBoxPopElement.TabIndex = 1;
            this.textBoxPopElement.TabStop = false;
            // 
            // textBoxPushElement
            // 
            this.textBoxPushElement.Location = new System.Drawing.Point(51, 35);
            this.textBoxPushElement.Name = "textBoxPushElement";
            this.textBoxPushElement.Size = new System.Drawing.Size(157, 30);
            this.textBoxPushElement.TabIndex = 1;
            // 
            // tabPageQueue
            // 
            this.tabPageQueue.BackColor = System.Drawing.Color.IndianRed;
            this.tabPageQueue.Controls.Add(this.dataGridViewQueue);
            this.tabPageQueue.Controls.Add(this.label3);
            this.tabPageQueue.Controls.Add(this.label2);
            this.tabPageQueue.Controls.Add(this.buttonDequeue);
            this.tabPageQueue.Controls.Add(this.buttonEnqueue);
            this.tabPageQueue.Controls.Add(this.textBoxDequeueElement);
            this.tabPageQueue.Controls.Add(this.textBoxEnqueueElement);
            this.tabPageQueue.Location = new System.Drawing.Point(4, 32);
            this.tabPageQueue.Name = "tabPageQueue";
            this.tabPageQueue.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQueue.Size = new System.Drawing.Size(792, 279);
            this.tabPageQueue.TabIndex = 1;
            this.tabPageQueue.Text = "Queue";
            // 
            // dataGridViewQueue
            // 
            this.dataGridViewQueue.AllowUserToAddRows = false;
            this.dataGridViewQueue.AllowUserToDeleteRows = false;
            this.dataGridViewQueue.AllowUserToResizeColumns = false;
            this.dataGridViewQueue.AllowUserToResizeRows = false;
            this.dataGridViewQueue.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewQueue.ColumnHeadersHeight = 29;
            this.dataGridViewQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewQueue.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQueue.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewQueue.Location = new System.Drawing.Point(51, 136);
            this.dataGridViewQueue.MultiSelect = false;
            this.dataGridViewQueue.Name = "dataGridViewQueue";
            this.dataGridViewQueue.ReadOnly = true;
            this.dataGridViewQueue.RowHeadersVisible = false;
            this.dataGridViewQueue.RowHeadersWidth = 51;
            this.dataGridViewQueue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewQueue.RowTemplate.Height = 24;
            this.dataGridViewQueue.Size = new System.Drawing.Size(686, 75);
            this.dataGridViewQueue.TabIndex = 1;
            this.dataGridViewQueue.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Front";
            // 
            // buttonDequeue
            // 
            this.buttonDequeue.AutoSize = true;
            this.buttonDequeue.Location = new System.Drawing.Point(627, 71);
            this.buttonDequeue.Name = "buttonDequeue";
            this.buttonDequeue.Size = new System.Drawing.Size(110, 33);
            this.buttonDequeue.TabIndex = 3;
            this.buttonDequeue.Text = "Dequeue";
            this.buttonDequeue.UseVisualStyleBackColor = true;
            this.buttonDequeue.Click += new System.EventHandler(this.buttonDequeue_Click);
            // 
            // buttonEnqueue
            // 
            this.buttonEnqueue.AutoSize = true;
            this.buttonEnqueue.Location = new System.Drawing.Point(98, 71);
            this.buttonEnqueue.Name = "buttonEnqueue";
            this.buttonEnqueue.Size = new System.Drawing.Size(110, 33);
            this.buttonEnqueue.TabIndex = 2;
            this.buttonEnqueue.Text = "Enqueue";
            this.buttonEnqueue.UseVisualStyleBackColor = true;
            this.buttonEnqueue.Click += new System.EventHandler(this.buttonEnqueue_Click);
            // 
            // textBoxDequeueElement
            // 
            this.textBoxDequeueElement.Location = new System.Drawing.Point(580, 35);
            this.textBoxDequeueElement.Name = "textBoxDequeueElement";
            this.textBoxDequeueElement.ReadOnly = true;
            this.textBoxDequeueElement.Size = new System.Drawing.Size(157, 30);
            this.textBoxDequeueElement.TabIndex = 2;
            this.textBoxDequeueElement.TabStop = false;
            // 
            // textBoxEnqueueElement
            // 
            this.textBoxEnqueueElement.Location = new System.Drawing.Point(51, 35);
            this.textBoxEnqueueElement.Name = "textBoxEnqueueElement";
            this.textBoxEnqueueElement.Size = new System.Drawing.Size(157, 30);
            this.textBoxEnqueueElement.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonPushStack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonPopStack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ICE_4 - Subeet Singh";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageStack.ResumeLayout(false);
            this.tabPageStack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStack)).EndInit();
            this.tabPageQueue.ResumeLayout(false);
            this.tabPageQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStack;
        private System.Windows.Forms.TabPage tabPageQueue;
        private System.Windows.Forms.Button buttonDequeue;
        private System.Windows.Forms.Button buttonEnqueue;
        private System.Windows.Forms.TextBox textBoxDequeueElement;
        private System.Windows.Forms.TextBox textBoxEnqueueElement;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonPopStack;
        private System.Windows.Forms.Button buttonPushStack;
        private System.Windows.Forms.TextBox textBoxPopElement;
        private System.Windows.Forms.TextBox textBoxPushElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewStack;
        private System.Windows.Forms.DataGridView dataGridViewQueue;
    }
}

