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
    public partial class FrmMain : Form
    {
        double MaterialCost = 0, LabourCost = 0, EstimateCost = 0, Profit = 0;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P2TJ3NF\\SQLEXPRESS;Initial Catalog=SaegisProject;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public FrmMain()
        {
            InitializeComponent();
            DisplayData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           try
            {
                con.Open();
                cmd = new SqlCommand("update tbl_Labour set Labour_First_Name='" + TxtLabourFirstName.Text + "',Labour_Last_Name='" + TxtLabourLastName.Text + "',Prefix='" + CmbLabourPrefix.SelectedItem.ToString() + "', Mobile_No1='" + Int32.Parse(TxtLabourMobile1.Text) + "' ,Mobile_No2='" + Int32.Parse(TxtLabourMobile2.Text) + "',Residential_Telephone='" + Int32.Parse(TxtLabourResidential.Text) + "',Address_Line01='" + TxtLabourAddressL1.Text + "',Address_Line02='" + TxtLabourAddressL2.Text + "',Address_Line03='" + TxtLabourAddressL3.Text + "',Email='" + TxtLabourEmail.Text + "',Description='" + TxtLabourDiscription.Text + "' Where Labour_ID='" + TxtLabourID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfuly!!!");
                con.Close();
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (TxtCustomerNIC.Text == "")
            {
                MessageBox.Show("Please type the Customer N.I.C!", "Missing Details");
            }
            else if (TxtCustomerFirstName.Text == "")
            {
                MessageBox.Show("Please type the First Name!", "Missing Details");
            }
            else if (TxtCustomerLastName.Text == "")
            {
                MessageBox.Show("Please type the Last Name!", "Missing Details");
            }
            else if (CmbCustomerPrefix.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Name Prefix!", "Missing Details");
            }
            else if (TxtCustomerAddressL1.Text == "")
            {
                MessageBox.Show("Please type the address Line 01!", "Missing Details");
            }
            else if (TxtCustomerAddressL2.Text == "")
            {
                MessageBox.Show("Please type the address Line 02!", "Missing Details");
            }
            else if (TxtCustomerAddressL3.Text == "")
            {
                MessageBox.Show("Please type the address Line 03!", "Missing Details");
            }
            else if (TxtCustomerMobile1.Text == "")
            {
                MessageBox.Show("Please type the Mobile No1!", "Missing Details");
            }
            else if (TxtCustomerMobile2.Text == "")
            {
                MessageBox.Show("Please type the Mobile No2!", "Missing Details");
            }
            else if (TxtCustomerResidential.Text == "")
            {
                MessageBox.Show("Please type the Residential Number!", "Missing Details");
            }
            else if (TxtCustomerEmail.Text == "")
            {
                MessageBox.Show("Please type the Email!", "Missing Details");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand ("insert into tbl_Customer values('" + TxtCustomerFirstName.Text + "','" + TxtCustomerLastName.Text + "','" + CmbCustomerPrefix.SelectedItem.ToString() + "','" + TxtCustomerNIC.Text + "','" + Int32.Parse(TxtCustomerMobile1.Text) + "','" + Int32.Parse(TxtCustomerMobile2.Text) + "','" + Int32.Parse(TxtCustomerResidential.Text) + "','" + TxtCustomerAddressL1.Text + "','" + TxtCustomerAddressL2.Text + "','" + TxtCustomerAddressL3.Text + "','" + TxtCustomerEmail.Text + "','" + TxtCustomerDiscription.Text + "')",con);
                int Customer = cmd.ExecuteNonQuery();
                if (Customer == 1)
                {
                    MessageBox.Show("New Customer Inserted Successfuly!!!");
                }
                else
                {
                    MessageBox.Show("New Customer Inserted Failed!!!");
                }
                con.Close();
                DisplayData();
            }
        }


        private void BtnCClear_Click(object sender, EventArgs e)
        {
            TxtCustomerNIC.Clear();
            TxtCustomerAddressL1.Clear();
            TxtCustomerFirstName.Clear();
            TxtCustomerEmail.Clear();
            TxtCustomerMobile1.Clear();
            TxtCustomerMobile2.Clear();
            TxtCustomerNIC.Clear();
            TxtCustomerResidential.Clear();
            TxtCustomerDiscription.Clear();
            TxtCustomerAddressL2.Clear();
            TxtCustomerAddressL3.Clear();
            TxtCustomerLastName.Clear();
            CmbCustomerPrefix.ResetText();
        }

        private void btnNICclear_Click(object sender, EventArgs e)
        {
            TxtNIC.Clear();
        }

        private void BtnCSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddLabour_Click(object sender, EventArgs e)
        {

            if (TxtLabourID.Text == "")
            {
                MessageBox.Show("Please type the Labour ID!", "Missing Details");
            }
            else if (TxtLabourFirstName.Text == "")
            {
                MessageBox.Show("Please type the First Name!", "Missing Details");
            }
            else if (TxtLabourLastName.Text == "")
            {
                MessageBox.Show("Please type the Last Name!", "Missing Details");
            }
            else if (CmbLabourPrefix.SelectedIndex == -1)
            {
                MessageBox.Show("Please type the Name Prefix!", "Missing Details");
            }
            else if (TxtLabourAddressL1.Text == "")
            {
                MessageBox.Show("Please type the Address Line01!", "Missing Details");
            }
            else if (TxtLabourAddressL2.Text == "")
            {
                MessageBox.Show("Please type the Address Line02!", "Missing Details");
            }
            else if (TxtLabourAddressL3.Text == "")
            {
                MessageBox.Show("Please type the Address Line03!", "Missing Details");
            }
            else if (TxtLabourMobile1.Text == "")
            {
                MessageBox.Show("Please type the Mobile No1!", "Missing Details");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("insert into tbl_Labour values('" + TxtLabourFirstName.Text + "','" + TxtLabourLastName.Text + "','" + TxtLabourID.Text + "','" + CmbLabourPrefix.SelectedItem.ToString() + "','" + TxtLabourMobile1.Text + "','" + TxtLabourMobile2.Text + "','" + TxtLabourResidential.Text + "','" + TxtLabourAddressL1.Text + "','" + TxtLabourAddressL2.Text + "','" + TxtLabourAddressL3.Text + "','" + TxtLabourEmail.Text + "','" + TxtLabourDiscription.Text + "')",con);
                int Labour = cmd.ExecuteNonQuery();
                if (Labour == 1)
                {
                    MessageBox.Show("New Labour Inserted Successfuly!!!");
                }
                else
                {
                    MessageBox.Show("New Labour Inserted Failed!!!");
                }
                con.Close();
                DisplayData();
            }
        }

        public void DisplayData()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from tbl_Customer", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            con.Open();
            adpt = new SqlDataAdapter("select * from tbl_Labour", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

            con.Open();
            adpt = new SqlDataAdapter("select * from tbl_Jobs", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saegisProjectDataSet3.tbl_Jobs' table. You can move, or remove it, as needed.
            this.tbl_JobsTableAdapter.Fill(this.saegisProjectDataSet3.tbl_Jobs);
            // TODO: This line of code loads data into the 'saegisProjectDataSet1.tbl_Labour' table. You can move, or remove it, as needed.
            this.tbl_LabourTableAdapter.Fill(this.saegisProjectDataSet1.tbl_Labour);
            // TODO: This line of code loads data into the 'saegisProjectDataSet.tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.saegisProjectDataSet.tbl_Customer);

        }


        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            MaterialCost = Double.Parse(TxtMaterialCost.Text);
            LabourCost = Double.Parse(TxtLabourCost.Text);
            EstimateCost = Double.Parse(TxtEstimateCost.Text);
            Profit = EstimateCost - (LabourCost + MaterialCost);
            MessageBox.Show("Profit is :" + Profit);
        }

        private void TxtProfit_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEstimateCost_TextChanged(object sender, EventArgs e)
        { 
            try
            {
                TxtProfit.Text = (float.Parse(TxtEstimateCost.Text) - (float.Parse(TxtMaterialCost.Text) + float.Parse(TxtLabourCost.Text)) ).ToString();
            }
            catch
            {

            }
        }

        private void BtnCDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from tbl_Customer where Customer_NIC='" + TxtCustomerNIC.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Data Has Been Deleted!");
            DisplayData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            TxtCustomerNIC.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtCustomerFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtCustomerLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            CmbCustomerPrefix.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtCustomerAddressL1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtCustomerAddressL2.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            TxtCustomerAddressL3.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            TxtCustomerMobile1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtCustomerMobile2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtCustomerResidential.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtCustomerEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            TxtCustomerDiscription.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtEstimateCost.Clear();
            TxtLabourCost.Clear();
            TxtMaterialCost.Clear();
            TxtProfit.Clear();

            MaterialCost = 0;
            LabourCost = 0;
            EstimateCost = 0;
            Profit = 0;
        }

        private void BtnLDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from tbl_Labour where Labour_ID='" + TxtLabourID.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Data Has Been Deleted!");
            DisplayData();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtLabourID.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtLabourFirstName.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtLabourLastName.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            CmbLabourPrefix.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtLabourMobile1.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtLabourMobile2.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtLabourResidential.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtLabourAddressL1.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            TxtLabourAddressL2.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
            TxtLabourAddressL3.Text = dataGridView2.Rows[e.RowIndex].Cells[9].Value.ToString();
            TxtLabourEmail.Text = dataGridView2.Rows[e.RowIndex].Cells[10].Value.ToString();
            TxtLabourDiscription.Text = dataGridView2.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void BtnCUpdate_Click(object sender, EventArgs e)
        {

             try
             {
                con.Open();
                cmd = new SqlCommand("update tbl_Customer set Customer_FirstName='" + TxtCustomerFirstName.Text + "',Customer_LastName='" + TxtCustomerLastName.Text + "',Prefix ='" + CmbCustomerPrefix.SelectedItem.ToString() + "', Mobile_No1='" + Int32.Parse(TxtCustomerMobile1.Text) + "',Mobile_No2 ='" + Int32.Parse(TxtCustomerMobile2.Text) + "',Residential_Telephone='" + Int32.Parse(TxtCustomerResidential.Text) + "',Address_Line01='" + TxtCustomerAddressL1.Text + "',Address_Line02='" + TxtCustomerAddressL2.Text + "',Address_Line03='" + TxtCustomerAddressL3.Text + "',Email='" + TxtCustomerEmail.Text + "',Description='" + TxtCustomerDiscription.Text + "' Where Customer_NIC='" + TxtCustomerNIC.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfuly!!!");
                con.Close();
                DisplayData();
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
             }
        }

        private void BtnJobSubmit_Click(object sender, EventArgs e)
        {
            if (TxtJob.Text == "")
            {
                MessageBox.Show("Please type the Job Number!", "Missing Details");
            }
            else if (TxtJobCNIC.Text == "")
            {
                MessageBox.Show("Please type the Customer NIC!", "Missing Details");
            }
            else if (JobDate.Text == "")
            {
                MessageBox.Show("Please set the date!", "Missing Details");
            }
            else if (TxtJobLID.Text == "")
            {
                MessageBox.Show("Please type the Labour ID!", "Missing Details");
            }
            else if (TxtJobEC.Text == "")
            {
                MessageBox.Show("Please type the Estimate Cost!", "Missing Details");
            }
            else if (TxtJobND.Text == "")
            {
                MessageBox.Show("Please type the Number Of days!", "Missing Details");
            }
            else if (TxtJonConDet.Text == "")
            {
                MessageBox.Show("Please type the Project Description!", "Missing Details");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("insert into tbl_Jobs values('" + TxtJob.Text + "','" + TxtJobCNIC.Text + "','" + this.JobDate.Text + "','" + TxtJobLID.Text + "','" +TxtJobEC.Text + "','" + TxtJobND.Text + "','" + TxtJonConDet.Text + "')", con);
                int Job = cmd.ExecuteNonQuery();
                if (Job == 1)
                {
                    MessageBox.Show("New Job Inserted Successfuly!!!");
                }
                else
                {
                    MessageBox.Show("New Job Inserted Failed!!!");
                }
                con.Close();
                DisplayData();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtJob.Clear();
            TxtJobCNIC.Clear();
            JobDate.ResetText();
            TxtJobLID.Clear();
            TxtJobEC.Clear();
            TxtJobND.Clear();
            TxtJonConDet.Clear();
        }

        private void BtnJobUpdate_Click(object sender, EventArgs e)
        {
            try
             {
                con.Open();
                cmd = new SqlCommand("update tbl_Customer set Customer_FirstName='" + TxtCustomerFirstName.Text + "',Customer_LastName='" + TxtCustomerLastName.Text + "',Prefix ='" + CmbCustomerPrefix.SelectedItem.ToString() + "', Mobile_No1='" + Int32.Parse(TxtCustomerMobile1.Text) + "',Mobile_No2 ='" + Int32.Parse(TxtCustomerMobile2.Text) + "',Residential_Telephone='" + Int32.Parse(TxtCustomerResidential.Text) + "',Address_Line01='" + TxtCustomerAddressL1.Text + "',Address_Line02='" + TxtCustomerAddressL2.Text + "',Address_Line03='" + TxtCustomerAddressL3.Text + "',Email='" + TxtCustomerEmail.Text + "',Description='" + TxtCustomerDiscription.Text + "' Where Customer_NIC='" + TxtCustomerNIC.Text + "'", con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successfuly!!!");
                con.Close();
                DisplayData();
             }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
             }



            cmd = new SqlCommand("update tbl_Jobs set Customer_NIC='" + TxtJobCNIC.Text + "',ReceivedDate='" + JobDate.Text + "',Labour_ID ='" + TxtJobLID.Text + "',EstimatedCost='" + TxtJobEC.Text + "',NumberOfDays='" + TxtJobND.Text + "',ConstructionDetails='" + TxtJonConDet.Text + "', where JobNo ='" + TxtJob.Text + "'", con);
        }

        private void BtnJobDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete from tbl_Jobs where JobNo ='" + TxtJob.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The Data Has Been Deleted!");
            DisplayData();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtJob.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtJobCNIC.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            JobDate.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtJobLID.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtJobEC.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtJobND.Text = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtJonConDet.Text = dataGridView3.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void BtnLClear_Click(object sender, EventArgs e)
        {
            TxtLabourAddressL1.Clear();
            TxtLabourDiscription.Clear();
            TxtLabourEmail.Clear();
            TxtLabourFirstName.Clear();
            TxtLabourID.Clear();
            TxtLabourMobile1.Clear();
            TxtLabourMobile2.Clear();
            TxtLabourResidential.Clear();
            TxtLabourAddressL2.Clear();
            TxtLabourAddressL3.Clear();
            TxtLabourLastName.Clear();
            CmbLabourPrefix.ResetText();
        }

        private void BtnLSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSerchNIC_Click(object sender, EventArgs e)
        {
        //-----------------------------------------Customer NIC SEARCH--------------------------------------------------------------//
        
            string Customer_NIC = " ";
            bool IsRecordFound = false;

            if (TxtNIC.Text != "")
            {
                try
                {
                    Customer_NIC = TxtNIC.Text;

                    string SearchQuery = "SELECT * FROM tbl_Customer WHERE Customer_NIC='" + TxtNIC.Text + "'";

                    SqlCommand SearchCmd = new SqlCommand(SearchQuery, con);

                    con.Open();

                    SqlDataReader Results = SearchCmd.ExecuteReader();

                    while (Results.Read())
                    {
                        if (Results.GetString(3) == Customer_NIC)
                        {
                            IsRecordFound = true;
                        }
                    }
                    Results.Close();
                    con.Close();

                    if (IsRecordFound == true)
                    {
                        MessageBox.Show("Customer Available!!!");
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Available!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry, An Exception Occured!\n" + ex.Message);
                }
            }
        }
    }
}
