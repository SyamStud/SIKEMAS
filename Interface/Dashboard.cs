using kasMasjid.Model;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void kategoriBtn_Click(object sender, EventArgs e)
        {
            headerTxt.Text = "Daftar Kategori";

            KategoriForm kategori = new KategoriForm();

            kategori.TopLevel = false;
            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(kategori);
            kategori.Show();
        }

        private void pemasukanBtn_Click(object sender, EventArgs e)
        {
            headerTxt.Text = "Daftar Pemasukan";

            PemasukanForm pemasukan = new PemasukanForm();

            pemasukan.TopLevel = false;
            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(pemasukan);
            pemasukan.Show();
        }

        private void pengeluaranBtn_Click(object sender, EventArgs e)
        {
            headerTxt.Text = "Daftar Pengeluaran";

            PengeluaranForm pengeluaran = new PengeluaranForm();

            pengeluaran.TopLevel = false;
            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(pengeluaran);
            pengeluaran.Show();
        }

        private void penggunaBtn_Click(object sender, EventArgs e)
        {
            headerTxt.Text = "Daftar Pengguna";

            PenggunaForm penggunaForm = new PenggunaForm();

            penggunaForm.TopLevel = false;
            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(penggunaForm);
            penggunaForm.Show();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            headerTxt.Text = "Dashboard";

            DashboardForm dashboard = new DashboardForm();

            dashboard.TopLevel = false;
            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin akan keluar dari aplikasi?", "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}