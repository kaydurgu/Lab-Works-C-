using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB13
{
    public partial class Form1 : Form
    {
        int index = 0; // variable for the index in all arrays
        int[] sum = { 2, 1, 1, 1, 2 }; // array with correct answers
        string[] s = { " C # this? ", " What is an int? ", " What is the foreach operator responsible for? ", " How does the conditional if statement work? ", " How does an int differ from a short data type? " };
        string[,] value =
        {// array with answers to the question
            {"Program for editing text", "Programming language", "DBMS", "This is the name of the processor"},
            {"Data type", "Programming language", " loop operator "," condition operator "},
            {" This operator is a loop that is specially created for a collection "," Programming language "," Data type responsible for integers "," This operator is erroneous "},
            {" one of branches "," is executed in a loop "," cc "," cc "},
            { "Program4 "," By the size of allocated memory "," cc "," cc "}
};

        int temp = 0; // variable
        int result = 0; // amount of typed data

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(index);
        }

        void LoadData(int i) // the function loads data from arrays by index
        {
            if (index >= s.Length) return; // check for going beyond the index
            else
            {
                groupBox1.Text = s[index];
                radioButton1.Text = value[index, 0];
                radioButton2.Text = value[index, 1];
                radioButton3.Text = value[index, 2];
                radioButton4.Text = value[index, 3];
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index >= s.Length) return;
            if (radioButton1.Checked == true)
                temp = 1;
            if (radioButton2.Checked == true)
                temp = 2;
            if (radioButton3.Checked == true)
                temp = 3;
            if (radioButton4.Checked == true)
                temp = 4;
            if (sum[index] == temp)
                result += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            LoadData(index);
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = "Вы выбрали " + result.ToString() + "баллов";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
