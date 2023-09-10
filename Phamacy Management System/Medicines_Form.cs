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
    public partial class Medicines_Form : Form
    {
        public Medicines_Form()
        {
            InitializeComponent();

            
            display_data_grid_view();   //data grid view method
            fillcombo();    //To fill combo box Manufactorer with Manufactorers table's Manufactor ID
            
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
            txt_MedName.Text = "";
            cmb_MedType.Text = "";
            txt_Price.Text = "";
            txt_Quantity.Text = "";
            cmb_ManuID.Text = "";
            txt_ManuName.Text = "";            
             
        }

        public void display_data_grid_view()    //For the data grid view
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Medicines_Table", con);
                adpt.Fill(dt);
                dgv_Medicines.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void dgv_Medicines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_Medicines.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Medicines_Table WHERE Med_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_MedName.Text = DR1.GetValue(1).ToString();
                cmb_MedType.Text = DR1.GetValue(2).ToString();
                txt_Price.Text = DR1.GetValue(3).ToString();
                txt_Quantity.Text = DR1.GetValue(4).ToString();
                cmb_ManuID.Text = DR1.GetValue(5).ToString();
                txt_ManuName.Text = DR1.GetValue(6).ToString();

            }
            DR1.Close();
            con.Close();
        }






        // SEPCIAL Method ******* SEPCIAL Method *******SEPCIAL Method *******SEPCIAL Method *******SEPCIAL Method *******SEPCIAL Method *******SEPCIAL Method *******

        private void fillcombo()    //ComboBox fill with Manufactorers name
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Manu_ID FROM Manufactorers_Table", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cmb_ManuID" , typeof(int));
            dt.Load(dr);
            cmb_ManuID.ValueMember = "Manu_ID";
            cmb_ManuID.DataSource = dt;
            con.Close();
        }        
        
        private void fill_textbox()     //TextBox link with the Combo Box
        {
            con.Open();
            string Query = "SELECT * FROM Manufactorers_Table WHERE Manu_ID = '"+cmb_ManuID.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                txt_ManuName.Text = dr["Manu_Name"].ToString();         //Should disable the behaviour of the textbox in order to prevent user editing
            }
            con.Close();
        }

        
        private void cmb_ManuID_SelectionChangeCommitted(object sender, EventArgs e)    //According to ComboBox value change the TextBox value      (ComboBox Event"SelectionChangeCommitted")
        {
            fill_textbox();
        }


            




        //***********************************SAVE*************Edit***************Delete*****************************************************************************************

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_MedName.Text == "" || cmb_MedType.Text == "" || txt_Price.Text == "" || txt_Quantity.Text == "" || cmb_ManuID.Text == "" || txt_ManuName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Medicines_Table(Med_Name,Med_Type,Med_Price,Med_Quantity,Med_ManuID,Med_ManuName) VALUES('" + txt_MedName.Text + "' , '" + cmb_MedType.Text + "' , " +
                        "'" + txt_Price.Text + "' , '" + txt_Quantity.Text + "' , '" + cmb_ManuID.Text + "'  , '" + txt_ManuName.Text + "' )", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine added successfully!!!");

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
            if (txt_MedName.Text == "" || cmb_MedType.Text == "" || txt_Price.Text == "" || txt_Quantity.Text == "" || cmb_ManuID.Text == "" || txt_ManuName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Medicines_Table SET Med_Type = '" + cmb_MedType.Text + "' , Med_Price = '" + txt_Price.Text + "', Med_Quantity = '" + txt_Quantity.Text + "', " +
                        "Med_ManuID = '" + cmb_ManuID.Text + "', Med_ManuName = '" + txt_ManuName.Text + "' WHERE Med_Name = '" + txt_MedName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine edit successfully!!!");

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
            if (txt_MedName.Text == "")
            {
                MessageBox.Show("Select Medicine to Delete");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Medicines_Table WHERE Med_Name = '" + txt_MedName.Text + "' ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Medicine delete successfully!!!");

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
