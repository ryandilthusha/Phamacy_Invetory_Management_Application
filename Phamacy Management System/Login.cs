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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ryand\Documents\PhamacyDB.mdf;Integrated Security=True;Connect Timeout=30");
        


        public static string user;      //Newly Created Variable --> To pass the username to bill form constructer to show in a label --> STEP 1 (Username Pass to Login Form to Billing Form)

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text =="" || txt_password.Text == "")
            {
                MessageBox.Show("Enter both Username and Password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Sellers_Table WHERE Sell_Name = '"+txt_username.Text+"' AND Sell_Password = '"+txt_password.Text+"' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    user = txt_username.Text; //Catching username to pass to bill form constructer to show in a label   --> STEP 2 (Username Pass to Login Form to Billing Form)
                    Billing_Form bill = new Billing_Form();
                    bill.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username and Password");
                }
                con.Close();

            }
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
