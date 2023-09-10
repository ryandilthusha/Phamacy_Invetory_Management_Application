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
    public partial class Billing_Form : Form
    {
        public Billing_Form()
        {
            InitializeComponent();

            fillcombo();    //Filling combobox
            fill_textbox(); //Filling texbox according to combox value.

            //Data Grid View methods
            display_data_grid_view_MEDICINESTOCK();
            display_data_grid_view_BILL();


            lbl_seller.Text = Login.user;   //Login user name display --> STEP 3 (Username Pass from Login Form to Billing Form)
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\PhamacyDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        //For data grid view
        SqlDataAdapter adpt;
        DataTable dt;







        //********************************* OTHER BUTTONS **********************************************************************************************************************

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }






        // SEPCIAL Method ******* SEPCIAL Method *******SEPCIAL Method *******SEPCIAL Method *******SEPCIAL Method *******SEPCIAL Method *******SEPCIAL Method *******


        private void fillcombo()    //Customer ID combobox link with Customer Table
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Cus_ID FROM Customers_Table", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Cus_ID", typeof(int));
            dt.Load(dr);
            cmb_CusID.ValueMember = "Cus_ID";
            cmb_CusID.DataSource = dt;
            con.Close();
        }        
        
        private void fill_textbox()     //TextBox link with the Combo Box
        {
            con.Open();
            string Query = "SELECT * FROM Customers_Table WHERE Cus_ID = '" + cmb_CusID.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_CusName.Text = dr["Cus_Name"].ToString();         //Should disable the behaviour of the textbox in order to prevent user editing
            }
            con.Close();
        }
        
        private void cmb_CusID_SelectionChangeCommitted(object sender, EventArgs e)     //According to ComboBox value change the TextBox value      (ComboBox Event"SelectionChangeCommitted")
        {
            fill_textbox();
        }








        //********************************* OTHER METHODS **********************************************************************************************************************


        public void display_data_grid_view_MEDICINESTOCK()    //For the Medicine Stock data grid view
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT Med_ID,Med_Name,Med_Type,Med_Price,Med_Quantity FROM Medicines_Table", con);
                adpt.Fill(dt);
                dgv_MedcineStock.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }


        int quantity;
        int price;
        private void dgv_MedcineStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            int ID;

            ID = int.Parse(dgv_MedcineStock.Rows[e.RowIndex].Cells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Medicines_Table WHERE Med_ID = '" + ID + "' ";

            SqlDataReader DR1 = cmd.ExecuteReader();

            if (DR1.Read())
            {
                txt_Medine.Text = DR1.GetValue(1).ToString();

                price = Convert.ToInt32(txt_price.Text = DR1.GetValue(3).ToString());      //should Covert to int, becz we calculate them when adding the bill          
                quantity = Convert.ToInt32(txt_quantity.Text = DR1.GetValue(4).ToString());     //should Covert to int, becz we calculate them when adding the bill                   

            }
            DR1.Close();
            con.Close();
        }





        
        //**************Add to Bill Button**************Add to Bill Button**************Add to Bill Button**************Add to Bill Button**************Add to Bill Button**************

        int finalTotal = 0;
        int n = 0;
        private void btn_AddBill_Click(object sender, EventArgs e)
        {
            if(txt_quantity.Text=="" || Convert.ToInt32(txt_quantity.Text) > quantity)
            {
                MessageBox.Show("Enter Correct Quantity");
            }
            else if (txt_CusName.Text == "")
            {
                MessageBox.Show("Enter Customer Details");
            }
            else
            {
                
                int Total = Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_quantity.Text);

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dgv_Bill);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txt_Medine.Text;
                newRow.Cells[2].Value = txt_price.Text;
                newRow.Cells[3].Value = txt_quantity.Text;
                newRow.Cells[4].Value = Total;
                dgv_Bill.Rows.Add(newRow);

                n++;    //ID Column value increament 1 by 1

                finalTotal = finalTotal + Total;

                lbl_Amount.Text = "Rs " + finalTotal;


                Update_Medicines_Quantity();

            }
        }


        // Update Quantity ******* Update Quantity *******Update Quantity *******Update Quantity *******Update Quantity *******Update Quantity *******Update Quantity *******
        
        private void Update_Medicines_Quantity()
        {
            try
            {
                int NewQty = quantity - Convert.ToInt32(txt_quantity.Text);
                con.Open();
                cmd = new SqlCommand("UPDATE Medicines_Table SET Med_Quantity = '" + NewQty + "' WHERE Med_Name = '" + txt_Medine.Text + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                

                //Then call this function at the end of Add bill button.



                display_data_grid_view_MEDICINESTOCK();    //data grid view method   



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }







        //*****************Bill Transaction Records*****************Bill Transaction Records*****************Bill Transaction Records*****************Bill Transaction Records*****************

        private void insert_bill()  //Create a new method to insert records into Bill table
        {

            try
            {

                con.Open();
                cmd = new SqlCommand("INSERT INTO Bill_Table(Seller_Name,Cus_ID,Cus_Name,Bill_Date,Bill_Amount) VALUES('" + lbl_seller.Text + "' , '" + cmb_CusID.SelectedValue.ToString() + "' ," +
                    " '" + txt_CusName.Text + "' , '" + DateTime.Today.Date + "' , '" + finalTotal + "' )", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Bill added successfully!!!");

                display_data_grid_view_BILL();    //data grid view method



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        public void display_data_grid_view_BILL()    //For the Bill Table data grid view
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM Bill_Table WHERE Seller_Name = '" + lbl_seller.Text + "'", con);
                adpt.Fill(dt);
                dgv_Transactions.DataSource = dt;
                con.Close();

                //This function will be passed to printing button. --> After printing a bill, this transaction record will be passed to Bill table.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }





        //**************For Bill Printing**************For Bill Printing**************For Bill Printing**************For Bill Printing**************For Bill Printing**************For Bill Printing**************

        //Print Document Tool double click and configuration
        int MedID;
        string MedName;
        int Medprice;
        int MedQty;
        int MedTot;
        int pos = 60;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ONE PHARMACY", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID     MEDICINE           PRICE            QUANTITY             TOTAL " , new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Red, new Point(26, 40));

            foreach(DataGridViewRow row in dgv_Bill.Rows)
            {
                MedID = Convert.ToInt32(row.Cells["Column1"].Value);
                MedName = "" + row.Cells["Column2"].Value;
                Medprice = Convert.ToInt32(row.Cells["Column3"].Value);
                MedQty = Convert.ToInt32(row.Cells["Column4"].Value);
                MedTot = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString("" + MedID, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + MedName, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + Medprice, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + MedQty, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + MedTot, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;
            }
            

            e.Graphics.DrawString("Final Total: " + finalTotal, new Font("Century Gothic", 10, FontStyle.Italic), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("******************ONE PHARMACY***************", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(10, pos + 85));
            dgv_Bill.Rows.Clear();
            dgv_Bill.Refresh();
            pos = 100;
            finalTotal = 0;
            n = 0;

            
        }

        //print button configuration
        private void btn_Print_Click(object sender, EventArgs e)
        {
            insert_bill();

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm",285,600);

              if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }       


            display_data_grid_view_BILL();
        }
        
    }
}
