using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasMasjid.Interface
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count > 5)
            {
                timer1.Enabled = false;
                Login login = new Login();

                login.Show();
                this.Hide();
            }
        }
    }
}