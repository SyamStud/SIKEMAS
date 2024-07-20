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

namespace kasMasjid.Interface
{
    public partial class PengeluaranForm : Form
    {
        private Pengeluaran pengeluaran = new Pengeluaran();

        public PengeluaranForm()
        {
            InitializeComponent();
        }

        private void bersihkan()
        {
            idTxt.Clear();
            nominalTxt.Clear();
            keteranganTxt.Clear();
            nominalTxt.Focus();

            kategoriCmb.SelectedIndex = 0;
        }

        private void isiCombo()
        {
            // Isi combo box dengan data nama jurusan
            DataTable dt = pengeluaran.isiCombo();
            foreach (DataRow row in dt.Rows)
            {
                kategoriCmb.Items.Add(row["nama"].ToString());
            }
        }

        private void belangBelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 1)
                    {
                        kolom.Style.BackColor = Color.WhiteSmoke;
                    }
                    else
                        kolom.Style.BackColor = Color.LightGray;
                }
            }
        }

        private void tampilGrid()
        {
            if (cariTxt.Text == "")
            {
                pengeluaranDgv.DataSource = pengeluaran.TampilkanSemua();
            }
            else
            {
                pengeluaranDgv.DataSource = pengeluaran.CariDgNama(cariTxt.Text);
            }

            belangBelang(pengeluaranDgv);
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (!pengeluaran.ApakahAda(idTxt.Text))
            {
                pengeluaran.setNominal = nominalTxt.Text;
                pengeluaran.setKeterangan = keteranganTxt.Text;
                pengeluaran.setKategori = kategoriCmb.Text;
                pengeluaran.setTanggal = tanggalPick.Value.ToString("yyyy-MM-dd");

                if (pengeluaran.simpanData() > 0)
                {
                    MessageBox.Show("Data berhasil disimpan.",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    tampilGrid();
                    kategoriCmb.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan.",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bersihkan();
                    tampilGrid();
                    kategoriCmb.SelectedIndex = 0;
                }
            }
            else
            {
                if (MessageBox.Show("Apakah anda yakin akan mengubah data?", "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pengeluaran.setNominal = nominalTxt.Text;
                    pengeluaran.setKeterangan = keteranganTxt.Text;
                    pengeluaran.setKategori = kategoriCmb.Text;
                    pengeluaran.setTanggal = tanggalPick.Value.ToString("yyyy-MM-dd");

                    if (pengeluaran.ubahData(idTxt.Text) > 0)
                    {
                        MessageBox.Show("Data berhasil diubah",
                        "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bersihkan();
                        tampilGrid();
                        kategoriCmb.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Data gagal diubah.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bersihkan();
                        tampilGrid();
                        kategoriCmb.SelectedIndex = 0;
                    }
                }
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            string ids = idTxt.Text;

            if (!string.IsNullOrEmpty(ids))
            {
                if (MessageBox.Show("Apakah data akan dihapus ?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    pengeluaran.HapusData(idTxt.Text);

                tampilGrid();
                bersihkan();
                kategoriCmb.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pengeluaranDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.pengeluaranDgv.Rows[e.RowIndex];

                idTxt.Text = baris.Cells[0].Value.ToString();
                nominalTxt.Text = baris.Cells[1].Value.ToString();
                keteranganTxt.Text = baris.Cells[2].Value.ToString();
                tanggalPick.Text = baris.Cells[3].Value.ToString();
                kategoriCmb.Text = baris.Cells[4].Value.ToString();
            }
        }

        private void PengeluaranForm_Load(object sender, EventArgs e)
        {
            tampilGrid();
            isiCombo();
            kategoriCmb.Items.Insert(0, "-Pilih Data-");
            kategoriCmb.SelectedIndex = 0;
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void tutupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            if (cariTxt.Text == "")
            {
                pengeluaranDgv.DataSource = pengeluaran.TampilkanSemua();
            }
            else
            {
                pengeluaranDgv.DataSource = pengeluaran.CariDgNama(cariTxt.Text);
            }
        }

        private void nominalTxt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}