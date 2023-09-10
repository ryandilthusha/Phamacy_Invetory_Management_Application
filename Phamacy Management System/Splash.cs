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
    public partial class Splash : Form
    {
        int startpoint = 0;

        public Splash()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value = startpoint;
            startpoint += 5;

            if (bunifuCircleProgressbar1.Value == 100)
            {
                timer1.Stop();

                Login F = new Login();
                this.Hide();
                F.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
