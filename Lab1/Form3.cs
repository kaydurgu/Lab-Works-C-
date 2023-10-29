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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox1.Text);
            int second = Convert.ToInt32(textBox2.Text);
            textBox3.Text  = (first - second).ToString();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox1.Text);
            int second = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (first + second).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox1.Text);
            int second = Convert.ToInt32(textBox2.Text);
            textBox3.Text = (first * second).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(textBox1.Text);
            int second = Convert.ToInt32(textBox2.Text);
            textBox3.Text = ( (first / second)).ToString();
        }
    }
}
