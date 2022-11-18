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

namespace SaegisProject
{
    public partial class FrmRegister : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P2TJ3NF\\SQLEXPRESS;Initial Catalog=SaegisProject;Integrated Security=True");
        SqlCommand cmd;
 

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtCPassword.Text = "";
        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPass.Checked)
            {
                TxtPassword.PasswordChar = '\0';
                TxtCPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                TxtCPassword.PasswordChar = '*';
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "" )
                MessageBox.Show("Please fill Username field!");
            else if (TxtPassword.Text == "")
                MessageBox.Show("Please fill Password field!");
            else if (TxtPassword.Text != TxtCPassword.Text)
                MessageBox.Show("Password do not match!");
            else
            {
                con.Open();
                cmd = new SqlCommand("insert into tbl_LoginUsers values('" + TxtUsername.Text + "','" + TxtPassword.Text +"')", con);
                int User = cmd.ExecuteNonQuery();
                if (User == 1)
                {
                    MessageBox.Show("New Account Created!!!");
                }
                else
                {
                    MessageBox.Show(" Failed!!!");
                }
                con.Close();
            }
        }
    }
}
