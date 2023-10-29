using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox1.Text);
            int second = Convert.ToInt32(textBox2.Text);
            string sign = textBox4.Text.ToString();
            if (sign == "+")
            {
                textBox3.Text = (first + second).ToString();
            }
            else if (sign == "-")
            {
                textBox3.Text = (first + second).ToString();
            }
            else if (sign == "*")
            {
                textBox3.Text = (first * second).ToString();
            }
            else if (sign == "/")
            {
                textBox3.Text = (first / second).ToString();
            }
            else
                MessageBox.Show("Error sign", "Error");

        }
    }
}
