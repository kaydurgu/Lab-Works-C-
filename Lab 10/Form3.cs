﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form3 : Form
    {
        public int[] mas = new int[4] { 30, 34, 195, 200 };
        double r = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = mas[comboBox1.SelectedIndex].ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text != "")
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text.Replace(".", ",")));

        }
        void Clear()
        {
            textBox1.Text = mas[comboBox1.SelectedIndex].ToString(); ;
            textBox2.Text = "";
            textBox3.Text = "";

        }
        double res( double d)
        {
            r = d + r;
            return r; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = listView1.Items.Add(comboBox1.SelectedItem.ToString());
            newItem.SubItems.Add(textBox1.Text);
            newItem.SubItems.Add(textBox2.Text);
            newItem.SubItems.Add(textBox3.Text);
            
            textBox4.Text = res(Convert.ToDouble(textBox3.Text)).ToString();

            Clear();

        }
    }
}
