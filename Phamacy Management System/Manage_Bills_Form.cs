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

namespace Phamacy_Management_System
{
    public partial class Manage_Bills_Form : Form
    {
        public Manage_Bills_Form()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\PhamacyDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        //For data grid view
        SqlDataAdapter adpt;
        DataTable dt;



        //********************************* OTHER BUTTONS **********************************************************************************************************************

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void btn_medicines_Click(object sender, EventArgs e)
        {
            Medicines_Form med = new Medicines_Form();
            med.Show();
            this.Hide();
        }

        private void btn_manufactorers_Click(object sender, EventArgs e)
        {
            Manufactorers_Form manu = new Manufactorers_Form();
            manu.Show();
            this.Hide();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Customers_Form cus = new Customers_Form();
            cus.Show();
            this.Hide();
        }

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            Seller_Form sell = new Seller_Form();
            sell.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }




        //********************************* OTHER METHODS **********************************************************************************************************************

        public void clear()
        {
            txt_SellName.Text = "";
            txt_cusID.Text = "";
            txt_cusName.Text = "";
            txt_billAmount.Text = "";
        }

        public void display_data_grid_view()    //For the data grid view
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Bill_Table", con);
                adpt.Fill(dt);
                dgv_Bills.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void dgv_Bills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_Bills.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Bill_Table WHERE Bill_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_SellName.Text = DR1.GetValue(1).ToString();
                txt_cusID.Text = DR1.GetValue(2).ToString();
                txt_cusName.Text = DR1.GetValue(3).ToString();

                dtp_billDate.Value = DateTime.Parse(DR1.GetValue(4).ToString());
                                
                txt_billAmount.Text = DR1.GetValue(5).ToString();
                
            }
            DR1.Close();
            con.Close();
        }



        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_SellName.Text == "" || txt_cusID.Text == "" || txt_cusName.Text == "" || txt_billAmount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Bill_Table(Seller_Name,Cus_ID,Cus_Name,Bill_Date,Bill_Amount) VALUES('" + txt_SellName.Text + "' , '" + txt_cusID.Text + "' , " +
                        "'" + txt_cusName.Text + "' , '" + dtp_billDate.Value + "' , '" + txt_billAmount.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bill added successfully!!!");

                    display_data_grid_view();    //data grid view method
                    clear();    //data clear method

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_SellName.Text == "" || txt_cusID.Text == "" || txt_cusName.Text == "" || txt_billAmount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Bill_Table SET Cus_ID = '" + txt_cusID.Text + "' , Cus_Name = '" + txt_cusName.Text + "' , Bill_Date = '" + dtp_billDate.Value + "' ," +
                        " Bill_Amount = '" + txt_billAmount.Text + "' WHERE Seller_Name = '" + txt_SellName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bill edit successfully!!!");

                    display_data_grid_view();    //data grid view method
                    clear();    //data clear method

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_SellName.Text == "")
            {
                MessageBox.Show("Select Seller Name of the Bill to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Bill_Table WHERE Seller_Name = '" + txt_SellName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bill delete successfully!!!");

                    display_data_grid_view();    //data grid view method
                    clear();    //data clear method
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }        
    }
}
