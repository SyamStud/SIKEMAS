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
    public partial class DashboardForm : Form
    {
        private DashboardMdl dashboard = new DashboardMdl();

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            pemasukanMingguTxt.Text = "Rp. " + dashboard.GetPemasukanMingguan().ToString("N0");
            pengeluaranMingguTxt.Text = "Rp. " + dashboard.GetPengeluaranMingguan().ToString("N0");
            totalKasTxt.Text = "Rp. " + dashboard.GetTotalKas().ToString("N0");

            pemasukanBulanTxt.Text = "Rp. " + dashboard.GetPemasukanBulanan().ToString("N0");
            pengeluaranBulanTxt.Text = "Rp. " + dashboard.GetPengeluaranBulanan().ToString("N0");

            pemasukanTahunTxt.Text = "Rp. " + dashboard.GetPemasukanTahunan().ToString("N0");
            pengeluaranTahunTxt.Text = "Rp. " + dashboard.GetPengeluaranTahunan().ToString("N0");

            totalPengeluaranTxt.Text = "Rp. " + dashboard.GetTotalPengeluaran().ToString("N0");
        }

        private void totalKasTxt_Click(object sender, EventArgs e)
        {
        }
    }
}