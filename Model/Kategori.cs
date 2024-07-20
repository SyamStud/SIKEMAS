using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using kasMasjid.Configuration;

namespace kasMasjid.Model
{
    internal class Kategori
    {
        private string nama;
        private string tipe;

        // CONNECTION ATTRIBUTE
        private ConnectionCls conn;

        private DataTable temp;
        private string query;

        public Kategori()
        {
            nama = "";
            tipe = "";

            conn = new ConnectionCls();
            temp = new DataTable();
            query = "";
        }

        public string setNama
        {
            set { nama = value; }
        }

        public string setTipe
        {
            set { tipe = value; }
        }

        public bool isExist(string nama)
        {
            query = "SELECT * FROM kategori WHERE nama = '" + nama + "'";
            temp = conn.Query(query);

            if (temp.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int store()
        {
            int result = -1;
            query = "INSERT INTO kategori (nama, tipe) VALUES ('" + nama + "', '" + tipe + "')";

            try
            {
                result = conn.NonQuery(query);

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Data Gagal Disimpan");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int update(string id)
        {
            int result = -1;

            query = "UPDATE kategori SET nama = '" + nama + "', tipe = '" + tipe + "' WHERE id = '" + id + "'";

            try
            {
                result = conn.NonQuery(query);

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Data Gagal Diubah");
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int delete(int id)
        {
            int result = -1;
            query = "DELETE FROM kategori WHERE id = '" + id + "'";
            try
            {
                result = conn.NonQuery(query);

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    throw new Exception("Data Gagal Dihapus");
                }
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public DataTable showAll()
        {
            DataTable data = new DataTable();
            query = "SELECT * FROM kategori";
            data = conn.Query(query);
            return data;
        }

        public DataTable search(string nama)
        {
            DataTable data = new DataTable();
            query = "SELECT * FROM kategori WHERE nama LIKE '%" + nama + "%'";
            data = conn.Query(query);
            return data;
        }

        public int findID(string nama)
        {
            int id = -1; // default value jika ID tidak ditemukan
            string query = "SELECT id FROM kategori WHERE nama = '" + nama + "'";

            DataTable data = conn.Query(query);

            if (data.Rows.Count > 0)
            {
                // Ambil nilai ID dari baris pertama hasil query
                id = Convert.ToInt32(data.Rows[0]["id"]);
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan untuk nama: " + nama);
            }

            return id;
        }
    }
}