using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kasMasjid.Model;

namespace kasMasjid.Interface
{
    public partial class Login : Form
    {
        private user User = new user();

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (User.CekLogin(username_txt.Text, password_txt.Text))
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah", "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                loginBtn.PerformClick();
            }
        }

        private void username_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                password_txt.Focus(); // Mengarahkan fokus ke TextBox password
            }
        }
    }
}