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
    public partial class Customers_Form : Form
    {
        public Customers_Form()
        {
            InitializeComponent();

            display_data_grid_view();
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

        private void btn_sellers_Click(object sender, EventArgs e)
        {
            Seller_Form sell = new Seller_Form();
            sell.Show();
            this.Hide();
        }

        private void btn_bills_Click(object sender, EventArgs e)
        {
            Manage_Bills_Form bill_manage = new Manage_Bills_Form();
            bill_manage.Show();
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
            txt_CusName.Text = "";
            cmb_Gender.Text = "";
            txt_Address.Text = "";
            txt_Phone.Text = "";
            dtp_birth.Value = DateTime.Now;

        }

        public void display_data_grid_view()    //For the data grid view
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Customers_Table", con);
                adpt.Fill(dt);
                dgv_Customers.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void dgv_Customers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_Customers.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Customers_Table WHERE Cus_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_CusName.Text = DR1.GetValue(1).ToString();
                cmb_Gender.Text = DR1.GetValue(2).ToString();
                txt_Address.Text = DR1.GetValue(3).ToString();
                txt_Phone.Text = DR1.GetValue(4).ToString();

                dtp_birth.Value = DateTime.Parse(DR1.GetValue(5).ToString());
                
            }
            DR1.Close();
            con.Close();
        }







        //***********************************SAVE*************Edit***************Delete*****************************************************************************************


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_CusName.Text == "" || cmb_Gender.Text == "" || txt_Address.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Customers_Table(Cus_Name,Cus_Gender,Cus_Address,Cus_Phone,Cus_Date) VALUES('" + txt_CusName.Text + "' , '" + cmb_Gender.Text + "' , " +
                        "'" + txt_Address.Text + "' , '" + txt_Phone.Text + "' , '" + dtp_birth.Value + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer added successfully!!!");

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
            if (txt_CusName.Text == "" || cmb_Gender.Text == "" || txt_Address.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Customers_Table SET Cus_Gender = '" + cmb_Gender.Text + "' , Cus_Address = '" + txt_Address.Text + "' , Cus_Phone = '" + txt_Phone.Text + "' ," +
                        " Cus_Date = '" + dtp_birth.Value + "' WHERE Cus_Name = '" + txt_CusName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer edit successfully!!!");

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
            if (txt_CusName.Text == "")
            {
                MessageBox.Show("Select Customer to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Customers_Table WHERE Cus_Name = '" + txt_CusName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer delete successfully!!!");

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
