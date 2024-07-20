using kasMasjid.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasMasjid.Model
{
    internal class user
    {
        private string _nama;
        private string _username;
        private string _password;

        private ConnectionCls koneksi;
        private DataTable temp;
        private string Query;

        public user()
        {
            koneksi = new ConnectionCls();
            temp = new DataTable();
            Query = "";
        }

        public string nama
        {
            set { _nama = value; }
        }

        public string username
        {
            set { _username = value; }
            get { return _username; }
        }

        public string password
        {
            set { _password = value; }
        }

        public bool CekLogin(string username, string password)
        {
            bool cek = false;
            //Query = "select * from user where user_id='" + username + "'and password= '"+password+"'";
            Query = "select * from user where username='" + username + "'and password= '" + password + "'";
            temp = koneksi.Query(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        //public string ambilNamaPengguna(string username, string password)
        //{
        //    string nama = "";
        //    Query = "select nama from pengguna " +
        //        "where username='" + username + "' and password='" +
        //        password + "'";
        //    temp = koneksi.Query(Query);
        //    if (temp.Rows.Count > 0)
        //    {
        //        foreach (DataRow row in temp.Rows)
        //        {
        //            nama = row[0].ToString();
        //        }
        //    }
        //    return nama;
        //}

        public bool isExist(string username)
        {
            bool cek = false;
            Query = "select * from user where username='" + username + "'";
            temp = koneksi.Query(Query);

            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public int store()
        {
            int result = -1;
            Query = "insert into user (nama, username, password) values ('" + _nama + "', '" + _username + "', '" + _password + "')";
            try
            {
                result = koneksi.NonQuery(Query);
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return result;
                }
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public int update(string id)
        {
            int result = -1;
            Query = "update user set username = '" + _username + "', password = '" + _password + "' where id = '" + id + "'";

            try
            {
                result = koneksi.NonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Gagal mengupdate data.");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int delete(string id)
        {
            int result = -1;
            Query = "delete from user where id='" + id + "'";

            try
            {
                result = koneksi.NonQuery(Query);
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

        public DataTable showAll()
        {
            DataTable data = new DataTable();
            Query = "select * from user";
            data = koneksi.Query(Query);
            return data;
        }

        public DataTable search(string username)
        {
            Query = "select * from user where username like '%" + username + "%'";
            return koneksi.Query(Query);
        }
    }
}