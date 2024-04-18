
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_main.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.Size = new System.Drawing.Size(610, 495);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 495);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}

