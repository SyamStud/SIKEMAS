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
    public partial class PenggunaForm : Form
    {
        private user pengguna = new user();

        public PenggunaForm()
        {
            InitializeComponent();
        }

        private void bersihkan()
        {
            idTxt.Clear();
            namaTxt.Clear();
            usernameTxt.Clear();
            passwordTxt.Clear();

            usernameTxt.Focus();
        }

        private void tampilGrid()
        {
            if (cariTxt.Text == "")
            {
                penggunaDgv.DataSource = pengguna.showAll();
            }
            else
            {
                penggunaDgv.DataSource = pengguna.search(namaTxt.Text);
            }
            belangBelang(penggunaDgv);
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

        private void PenggunaForm_Load(object sender, EventArgs e)
        {
            bersihkan();
            tampilGrid();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            string id = idTxt.Text;
            string username = usernameTxt.Text;
            string nama = namaTxt.Text;
            string password = passwordTxt.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(nama) && !string.IsNullOrEmpty(password))
            {
                if (!pengguna.isExist(namaTxt.Text) && string.IsNullOrEmpty(id))
                {
                    pengguna.nama = namaTxt.Text;
                    pengguna.username = usernameTxt.Text;
                    pengguna.password = passwordTxt.Text;

                    if (pengguna.store() > 0)
                    {
                        MessageBox.Show("Data Berhasil disimpan.",
                                                   "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        bersihkan();

                        penggunaDgv.DataSource = pengguna.showAll();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan data.",
                                                   "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (MessageBox.Show("Apakah Data akan diubah?",
                                           "KONFIRMASI", MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pengguna.username = namaTxt.Text;
                        pengguna.password = passwordTxt.Text;

                        if (pengguna.update(idTxt.Text) > 0)
                        {
                            MessageBox.Show("Data Berhasil diubah.",
                                                           "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            bersihkan();

                            penggunaDgv.DataSource = pengguna.showAll();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah data.",
                                                           "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lengkapi form terlebih dahulu.",
                                                           "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void penggunaDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.penggunaDgv.Rows[e.RowIndex];

                idTxt.Text = baris.Cells[0].Value.ToString();
                namaTxt.Text = baris.Cells[2].Value.ToString();
                usernameTxt.Text = baris.Cells[3].Value.ToString();
                passwordTxt.Text = baris.Cells[1].Value.ToString();
            }
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            string ids = idTxt.Text;

            if (!string.IsNullOrEmpty(ids))
            {
                if (MessageBox.Show("Apakah data akan dihapus ?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    pengguna.delete(idTxt.Text);

                tampilGrid();
                bersihkan();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus.",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            if (cariTxt.Text == "")
            {
                penggunaDgv.DataSource = pengguna.showAll();
            }
            else
            {
                penggunaDgv.DataSource = pengguna.search(cariTxt.Text);
            }
        }
    }
}