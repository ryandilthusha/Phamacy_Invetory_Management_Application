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
    public partial class Seller_Form : Form
    {
        public Seller_Form()
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

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Customers_Form cus = new Customers_Form();
            cus.Show();
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
            txt_SellName.Text = "";
            cmb_Gender.Text = "";
            dtp_Birth.Text = "";
            txt_Address.Text = "";
            txt_Phone.Text = "";
            txt_Password.Text = "";
        }
        public void display_data_grid_view()    //For the data grid view
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Sellers_Table", con);
                adpt.Fill(dt);
                dgv_Sellers.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void dgv_Sellers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_Sellers.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Sellers_Table WHERE Sell_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_SellName.Text = DR1.GetValue(1).ToString();
                cmb_Gender.Text = DR1.GetValue(2).ToString();

                dtp_Birth.Value = DateTime.Parse(DR1.GetValue(3).ToString());

                txt_Address.Text = DR1.GetValue(4).ToString();
                txt_Phone.Text = DR1.GetValue(5).ToString();
                txt_Password.Text = DR1.GetValue(6).ToString();

            }
            DR1.Close();
            con.Close();
        }



        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_SellName.Text == "" || cmb_Gender.Text == "" || txt_Address.Text == "" || txt_Phone.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Sellers_Table(Sell_Name,Sell_Gender,Sell_Date,Sell_Address,Sell_Phone,Sell_Password) VALUES('" + txt_SellName.Text + "' , '" + cmb_Gender.Text + "' , " +
                        "'" + dtp_Birth.Value + "' , '" + txt_Address.Text + "' , '" + txt_Phone.Text + "' , '" + txt_Password.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Seller added successfully!!!");

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
            if (txt_SellName.Text == "" || cmb_Gender.Text == "" || txt_Address.Text == "" || txt_Phone.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Sellers_Table SET Sell_Gender = '" + cmb_Gender.Text + "' , Sell_Date = '" + dtp_Birth.Value + "' , Sell_Address = '" + txt_Address.Text + "' , " +
                        "Sell_Phone = '" + txt_Phone.Text + "' , Sell_Password = '" + txt_Password.Text + "' WHERE Sell_Name = '" + txt_SellName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Seller edit successfully!!!");

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
                MessageBox.Show("Select Seller to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Sellers_Table WHERE Sell_Name = '" + txt_SellName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Seller delete successfully!!!");

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
