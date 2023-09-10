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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            
            
            fillcombo_Seller();     //Filling combobox


            //********************************* Summery Panel Details

            Get_MedCount(); //Medicine count Summery Panel

            Get_CusCount(); //Customer count Summery Panel

            Get_SellCount(); //Seller count Summery method



            //********************************* Dashboard Financial Panel Details

            Get_SellTotal(); //Total Sell Amount Financial Panel

            Get_Sell_Amount_BySeller(); //Seller's Sell Amount Financial Panel



            //********************************* Dashboard Award Panel Details

            BestSeller();   //Best Seller Award Panel

            BestCustomer();     //Best Customer Award Panel
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\PhamacyDB.mdf;Integrated Security=True;Connect Timeout=30");
        





        //********************************* OTHER BUTTONS **********************************************************************************************************************

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

        





        //********************************* Summery Panel Details **********************************************************************************************************************

        public void Get_MedCount()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Medicines_Table", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_GetMed.Text = dt.Rows[0][0].ToString();
            con.Close();            
        }

        public void Get_CusCount()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Customers_Table", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_GetCus.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        public void Get_SellCount()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sellers_Table", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_GetSell.Text = dt.Rows[0][0].ToString();
            con.Close();
        }






        //********************************* Dashboard Financial Panel Details **********************************************************************************************************************

        public void Get_SellTotal()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(Bill_Amount) FROM Bill_Table", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_SellTotal.Text = dt.Rows[0][0].ToString();
            con.Close();
        }


        
        private void fillcombo_Seller()     //ComboBox fill with sellers name
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Sell_Name FROM Sellers_Table", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("cmb_seller", typeof(string));
            dt.Load(dr);
            cmb_seller.ValueMember = "Sell_Name";
            cmb_seller.DataSource = dt;
            con.Close();
        }

        public void Get_Sell_Amount_BySeller()      //TextBox link with the Combo Box
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT SUM(Bill_Amount) FROM Bill_Table WHERE Seller_Name = '"+ cmb_seller.SelectedValue.ToString()  +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lbl_sellesByseller.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void cmb_seller_SelectionChangeCommitted(object sender, EventArgs e)        //According to ComboBox value change the TextBox value      (ComboBox Event"SelectionChangeCommitted")
        {
            Get_Sell_Amount_BySeller();
        }






        //********************************* Dashboard Award Panel Details **********************************************************************************************************************


        private void BestSeller()
        {
            try
            {
                con.Open();
                string InnerQuery = "SELECT MAX(Bill_Amount) FROM Bill_Table";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, con);
                sda1.Fill(dt1);

                string Query = "SELECT Seller_Name FROM Bill_Table WHERE Bill_Amount = '" + dt1.Rows[0][0].ToString()+"'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                lbl_BestAgent.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void BestCustomer()
        {
            try
            {
                con.Open();
                string InnerQuery = "SELECT MAX(Bill_Amount) FROM Bill_Table";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, con);
                sda1.Fill(dt1);

                string Query = "SELECT Cus_Name FROM Bill_Table WHERE Bill_Amount = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                lbl_BestCustomer.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }        
    }
}
