
namespace KÁ_2024_04_18
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
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_kereses = new System.Windows.Forms.Button();
            this.label_erdemjegy = new System.Windows.Forms.Label();
            this.label_Targy = new System.Windows.Forms.Label();
            this.comboBox_erdemjegy = new System.Windows.Forms.ComboBox();
            this.comboBox_targy = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_main.Location = new System.Drawing.Point(0, 24);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.Size = new System.Drawing.Size(610, 471);
            this.dataGridView_main.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_kereses);
            this.splitContainer1.Panel1.Controls.Add(this.label_erdemjegy);
            this.splitContainer1.Panel1.Controls.Add(this.label_Targy);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_erdemjegy);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_targy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_main);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(835, 495);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 1;
            // 
            // button_kereses
            // 
            this.button_kereses.Location = new System.Drawing.Point(43, 281);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(131, 82);
            this.button_kereses.TabIndex = 5;
            this.button_kereses.Text = "Kereses";
            this.button_kereses.UseVisualStyleBackColor = true;
            this.button_kereses.Click += new System.EventHandler(this.button_kereses_Click);
            // 
            // label_erdemjegy
            // 
            this.label_erdemjegy.AutoSize = true;
            this.label_erdemjegy.Location = new System.Drawing.Point(12, 42);
            this.label_erdemjegy.Name = "label_erdemjegy";
            this.label_erdemjegy.Size = new System.Drawing.Size(56, 13);
            this.label_erdemjegy.TabIndex = 4;
            this.label_erdemjegy.Text = "Erdemjegy";
            // 
            // label_Targy
            // 
            this.label_Targy.AutoSize = true;
            this.label_Targy.Location = new System.Drawing.Point(12, 15);
            this.label_Targy.Name = "label_Targy";
            this.label_Targy.Size = new System.Drawing.Size(34, 13);
            this.label_Targy.TabIndex = 3;
            this.label_Targy.Text = "Targy";
            // 
            // comboBox_erdemjegy
            // 
            this.comboBox_erdemjegy.FormattingEnabled = true;
            this.comboBox_erdemjegy.Items.AddRange(new object[] {
            "",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox_erdemjegy.Location = new System.Drawing.Point(76, 39);
            this.comboBox_erdemjegy.Name = "comboBox_erdemjegy";
            this.comboBox_erdemjegy.Size = new System.Drawing.Size(121, 21);
            this.comboBox_erdemjegy.TabIndex = 1;
            // 
            // comboBox_targy
            // 
            this.comboBox_targy.FormattingEnabled = true;
            this.comboBox_targy.Items.AddRange(new object[] {
            "",
            "magyar",
            "tortenelem",
            "matematika"});
            this.comboBox_targy.Location = new System.Drawing.Point(76, 12);
            this.comboBox_targy.Name = "comboBox_targy";
            this.comboBox_targy.Size = new System.Drawing.Size(121, 21);
            this.comboBox_targy.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 495);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.Label label_erdemjegy;
        private System.Windows.Forms.Label label_Targy;
        private System.Windows.Forms.ComboBox comboBox_erdemjegy;
        private System.Windows.Forms.ComboBox comboBox_targy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

