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
    public partial class Manufactorers_Form : Form
    {
        public Manufactorers_Form()
        {
            InitializeComponent();

            display_data_grid_view();    //data grid view method
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
            txt_ManuName.Text = "";
            txt_Address.Text = "";
            txt_Phone.Text = "";
            dtp_Join.Value = DateTime.Now;
        }

        public void display_data_grid_view()    //For the data grid view
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Manufactorers_Table", con);
                adpt.Fill(dt);
                dgv_Manufactorers.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void dgv_Manufactorers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_Manufactorers.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Manufactorers_Table WHERE Manu_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_ManuName.Text = DR1.GetValue(1).ToString();
                txt_Address.Text = DR1.GetValue(2).ToString();
                txt_Phone.Text = DR1.GetValue(3).ToString();

                dtp_Join.Value = DateTime.Parse(DR1.GetValue(4).ToString());
            }
            DR1.Close();
            con.Close();
        }




        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_ManuName.Text == "" || txt_Address.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand ("INSERT INTO Manufactorers_Table(Manu_Name,Manu_Address,Manu_Phone,Manu_Date) VALUES('"+txt_ManuName.Text+"' , '"+txt_Address.Text+"' , '"+txt_Phone.Text+"' , " +
                        "'"+dtp_Join.Value+"')" , con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Manufactorer added successfully!!!");

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
            if (txt_ManuName.Text == "" || txt_Address.Text == "" || txt_Phone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand ("UPDATE Manufactorers_Table SET Manu_Address = '" + txt_Address.Text + "' , Manu_Phone = '" + txt_Phone.Text + "' , " +
                        "Manu_Date = '" + dtp_Join.Value + "' WHERE Manu_Name = '" + txt_ManuName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Manufactorer edit successfully!!!");

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
            if (txt_ManuName.Text == "")
            {
                MessageBox.Show("Select Seller to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Manufactorers_Table WHERE Manu_Name = '" + txt_ManuName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Manufactorer delete successfully!!!");

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
