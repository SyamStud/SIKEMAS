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
    public partial class KategoriForm : Form

    {
        private Kategori kategori = new Kategori();

        public KategoriForm()
        {
            InitializeComponent();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;
            string nama = namaTxt.Text;

            if (!string.IsNullOrEmpty(nama) && tipeCmb.SelectedIndex != 0)
            {
                if (!kategori.isExist(namaTxt.Text) && string.IsNullOrEmpty(id))
                {
                    kategori.setNama = namaTxt.Text;
                    kategori.setTipe = tipeCmb.SelectedItem.ToString().Replace("'", "''");

                    if (kategori.store() > 0)
                    {
                        MessageBox.Show("Data Berhasil disimpan.",
                            "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        bersihkan();

                        kategoriDgv.DataSource = kategori.showAll();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan data.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (kategori.isExist(namaTxt.Text))
                {
                    if (MessageBox.Show("Apakah Data akan diubah?",
                        "KONFIRMASI", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        kategori.setNama = namaTxt.Text;
                        kategori.setTipe = tipeCmb.Text;

                        if (kategori.update(idTxt.Text) > 0)
                        {
                            MessageBox.Show("Data Berhasil diubah.",
                                "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            bersihkan();

                            kategoriDgv.DataSource = kategori.showAll();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah data.",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lengkapi form terlebih dahulu.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            int id = kategori.findID(namaTxt.Text);
            string ids = idTxt.Text;

            if (!string.IsNullOrEmpty(ids))
            {
                if (MessageBox.Show("Apakah data akan dihapus ?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Hapus data program studi
                    kategori.delete(id);

                    // Tampilkan data terbaru di DataGridView
                    kategoriDgv.DataSource = kategori.showAll();

                    // Bersihkan input
                    bersihkan();
                    tipeCmb.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bersihkan()
        {
            idTxt.Clear();
            namaTxt.Clear();
            tipeCmb.SelectedIndex = 0;
            namaTxt.Focus();
        }

        private void tampilGrid()
        {
            if (namaTxt.Text == "")
            {
                kategoriDgv.DataSource = kategori.showAll();
            }
            else
            {
                kategoriDgv.DataSource = kategori.search(namaTxt.Text);
            }
            belangBelang(kategoriDgv);
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

        private void batalBtn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void tutupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kategoriDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.kategoriDgv.Rows[e.RowIndex];
                idTxt.Text = baris.Cells[0].Value.ToString();
                namaTxt.Text = baris.Cells[1].Value.ToString();
                tipeCmb.Text = baris.Cells[2].Value.ToString();
            }
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            bersihkan();
            tampilGrid();

            tipeCmb.Items.Insert(0, "-Pilih Data-");
            tipeCmb.SelectedIndex = 0;
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            if (cariTxt.Text == "")
            {
                kategoriDgv.DataSource = kategori.showAll();
            }
            else
            {
                kategoriDgv.DataSource = kategori.search(cariTxt.Text);
            }
        }
    }
}