﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KÁ_2024_04_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EredmenyekRepo.path = "eredmenyek.txt";
            dataGridView_main.DataSource = EredmenyekRepo.FindAll();
            comboBox_targy.SelectedIndex = 0;
            comboBox_erdemjegy.SelectedIndex = 0;
        }

        private void button_kereses_Click(object sender, EventArgs e)
        {
            dataGridView_main.DataSource = EredmenyekRepo.FindAllBySearch("", "", comboBox_targy.SelectedItem.ToString(), "", comboBox_erdemjegy.SelectedItem.ToString());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                EredmenyekRepo.path = openFileDialog1.FileName;
                dataGridView_main.DataSource = EredmenyekRepo.FindAllBySearch("", "", comboBox_targy.SelectedItem.ToString(), "", comboBox_erdemjegy.SelectedItem.ToString());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eredmenyek 1.0\nKrauter Ádám tualjdona csak Krauter Ádám nyúlhato hozzá aki nem más mint Krauter Ádám");
        }
    }
}
