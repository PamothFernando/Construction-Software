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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLLogin_Click(object sender, EventArgs e)
        {
            if (TxtLUsername.Text == "")
                MessageBox.Show("Please fill Username field!");
            else if (TxtLPassword.Text == "")
                MessageBox.Show("Please fill Password field!");
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-P2TJ3NF\SQLEXPRESS;Initial Catalog=SaegisProject;Integrated Security=True");
                string query = "Select * from tbl_LoginUsers Where User_Name ='" + TxtLUsername.Text.Trim() + "' and Password = '" + TxtLPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    new FrmMain().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Check Your Username and Password!!!");
                }
            }
            
        }

        private void CheckBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPass.Checked)
            {
                TxtLPassword.PasswordChar = '\0';
            }
            else
            {
                TxtLPassword.PasswordChar = '*';
            }
        }

        private void BtnLClear_Click(object sender, EventArgs e)
        {
            TxtLUsername.Text = "";
            TxtLPassword.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new FrmRegister().Show();
            this.Hide();
        }
    }
}
