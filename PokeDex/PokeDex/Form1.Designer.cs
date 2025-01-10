namespace PokeDex
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelName = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPokemonList = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelID = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPokemonID = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.pictureBoxPokemonLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelName.SuspendLayout();
            this.flowLayoutPanelID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPokemonID)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemonLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBoxPokemonLogo);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelID, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // flowLayoutPanelName
            // 
            resources.ApplyResources(this.flowLayoutPanelName, "flowLayoutPanelName");
            this.flowLayoutPanelName.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelName.Controls.Add(this.label1);
            this.flowLayoutPanelName.Controls.Add(this.comboBoxPokemonList);
            this.flowLayoutPanelName.Name = "flowLayoutPanelName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBoxPokemonList
            // 
            this.comboBoxPokemonList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPokemonList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPokemonList.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxPokemonList, "comboBoxPokemonList");
            this.comboBoxPokemonList.Name = "comboBoxPokemonList";
            this.comboBoxPokemonList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxPokemonList.TextUpdate += new System.EventHandler(this.comboBoxPokemonList_TextUpdate);
            // 
            // flowLayoutPanelID
            // 
            resources.ApplyResources(this.flowLayoutPanelID, "flowLayoutPanelID");
            this.flowLayoutPanelID.Controls.Add(this.label3);
            this.flowLayoutPanelID.Controls.Add(this.numericUpDownPokemonID);
            this.flowLayoutPanelID.Name = "flowLayoutPanelID";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // numericUpDownPokemonID
            // 
            resources.ApplyResources(this.numericUpDownPokemonID, "numericUpDownPokemonID");
            this.numericUpDownPokemonID.Maximum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.numericUpDownPokemonID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPokemonID.Name = "numericUpDownPokemonID";
            this.numericUpDownPokemonID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPokemonID.ValueChanged += new System.EventHandler(this.numericUpDownPokemonID_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonChoose);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // buttonChoose
            // 
            resources.ApplyResources(this.buttonChoose, "buttonChoose");
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // pictureBoxPokemonLogo
            // 
            resources.ApplyResources(this.pictureBoxPokemonLogo, "pictureBoxPokemonLogo");
            this.pictureBoxPokemonLogo.Image = global::PokeDex.Properties.Resources.Pokemon_Logo_PNG4;
            this.pictureBoxPokemonLogo.Name = "pictureBoxPokemonLogo";
            this.pictureBoxPokemonLogo.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanelName.ResumeLayout(false);
            this.flowLayoutPanelID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPokemonID)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemonLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPokemonList;
        private System.Windows.Forms.NumericUpDown numericUpDownPokemonID;
        private System.Windows.Forms.PictureBox pictureBoxPokemonLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelID;
    }
}

