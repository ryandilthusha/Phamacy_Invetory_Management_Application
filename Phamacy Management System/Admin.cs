using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phamacy_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            obj.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Admin")
            {                
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrond Admin Password");
            }
            
            
            
        }
    }
}
