using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with line", "Line Title");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a string and different buttons", "Title string", MessageBoxButtons.OKCancel);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.AbortRetryIgnore);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line and different buttons", "Title bar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save data", "Attention!",
                MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes){
                MessageBox.Show("Data Saved", "Data Saved");
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("Data not Saved", "Data not Saved");
            }
            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Saving data canceled by the user", "Data not Saved");
            }

        }
    }
}
