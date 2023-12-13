using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            frmlogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtComPassword.Clear();
            txtpassword.Clear();
            txtUsername.Clear();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtComPassword.UseSystemPasswordChar = false;
                txtpassword.UseSystemPasswordChar=false;
            }
            else
            {
                txtComPassword.UseSystemPasswordChar = true;
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            frmlogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtComPassword.Text != txtpassword.Text)
            {
                txtComPassword.Clear();
                txtpassword.Clear();
                MessageBox.Show("Password Confirmation is not equal to Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3OJ1S5A\SQLEXPRESS;Initial Catalog=password_manager;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO users values (@username, @password)", conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
                frmlogin frmlogin = new frmlogin();
                frmlogin.Show();
                MessageBox.Show("Registration is Successful", "Success", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                
            }
        }
    }
}
