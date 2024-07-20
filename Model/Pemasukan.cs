using kasMasjid.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kasMasjid.Model
{
    internal class Pemasukan
    {
        private string _nominal;
        private string _keterangan;
        private string _kategori;
        private string _tanggal;

        private ConnectionCls server;
        private DataTable temp;
        private string query;

        public Pemasukan()
        {
            _nominal = "";
            _keterangan = "";
            _kategori = "";

            server = new ConnectionCls();
            temp = new DataTable();
            query = "";
        }

        public string setNominal
        {
            set { _nominal = value; }
        }

        public string setKeterangan
        {
            set { _keterangan = value; }
        }

        public string setKategori
        {
            set { _kategori = value; }
        }

        public string setTanggal
        {
            set { _tanggal = value; }
        }

        public bool ApakahAda(string id)
        {
            bool cek = false;
            query = "select * from pemasukan where id = '" + id + "'";

            temp = server.Query(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public DataTable TampilkanSemua()
        {
            query = "SELECT p.id, p.nominal, p.keterangan, p.tanggal, j.nama FROM pemasukan p JOIN kategori j ON p.id_kategori = j.id";
            return server.Query(query);
        }

        public int simpanData()
        {
            int result = -1;
            int id_kategori = GetIDKategori(_kategori);

            query = "INSERT INTO pemasukan (nominal, keterangan, id_kategori, tanggal) VALUES ('" + _nominal + "', '" + _keterangan + "', " + id_kategori + ", '" + _tanggal + "')";

            result = server.NonQuery(query);
            try
            {
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan Data");
                }
            }
            catch (Exception e)
            {
            }
            return result;
        }

        public int ubahData(string id)
        {
            int result = -1;
            int id_kategori = GetIDKategori(_kategori);

            query = "UPDATE pemasukan SET keterangan ='" + _keterangan + "', nominal='" + _nominal + "', id_kategori='" + id_kategori + "', tanggal='" + _tanggal + "' WHERE id='" + id + "'";

            result = server.NonQuery(query);
            try
            {
                if (result < 0)
                {
                    throw new Exception("Gagal Menyimpan Data");
                }
            }
            catch (Exception e)
            {
            }
            return result;
        }

        public int HapusData(string id)
        {
            int result = -1;

            query = "delete from pemasukan where id = '" + id + "'";

            try
            {
                result = server.NonQuery(query);
                if (result < 0)
                {
                    throw new Exception("Gagal menghapus data.");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int GetIDKategori(string nama)
        {
            int id = -1;

            query = "SELECT id FROM kategori WHERE nama = '" + nama + "'";
            DataTable result = server.Query(query);

            if (result.Rows.Count > 0)
            {
                id = Convert.ToInt32(result.Rows[0]["id"]);
            }

            return id;
        }

        public DataTable isiCombo()
        {
            query = "SELECT nama FROM kategori WHERE tipe = 'Pemasukan'";
            return server.Query(query);
        }

        public DataTable CariDgNama(string keterangan)
        {
            query = "select p.id, p.nominal, p.keterangan, p.tanggal, j.nama from pemasukan p join kategori j on p.id_kategori = j.id where p.keterangan like '%" + keterangan + "%'";
            return server.Query(query);
        }
    }
}