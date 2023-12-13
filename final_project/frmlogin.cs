using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace final_project
{
    public partial class frmlogin : Form
    {
        public static string usernamedata;
        public static string passworddata;
        public frmlogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3OJ1S5A\SQLEXPRESS;Initial Catalog=password_manager;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtUsername.Text;
            password = txtpassword.Text;
            try{
                String querry = "SELECT * FROM users WHERE username='"+username+ "' AND  password='"+password+"'";
            
                SqlDataAdapter sda = new SqlDataAdapter(querry , conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    password = txtpassword.Text;
                    Form2 form2 = new Form2();
                    form2.label1.Text = username;
                    form2.label2.Text = password;
                    form2.Show();
                    label1.Text = username;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login Details", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtpassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch { MessageBox.Show("Error"); }
            finally { conn.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpassword.Clear();
            txtUsername.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked == true)
            txtpassword.UseSystemPasswordChar = false;
            else 
            txtpassword.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
            this.Hide();
        }
    }
}
