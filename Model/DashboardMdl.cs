using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using kasMasjid.Configuration;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Common;

namespace kasMasjid.Model
{
    internal class DashboardMdl
    {
        // CONNECTION ATTRIBUTE
        private ConnectionCls conn;

        private string query;

        public DashboardMdl()
        {
            conn = new ConnectionCls();
            query = "";
        }

        public double GetPemasukanMingguan()
        {
            query = "SELECT SUM(nominal) AS total FROM pemasukan WHERE YEAR(tanggal) = YEAR(CURDATE()) AND WEEK(tanggal) = WEEK(CURDATE());";

            try
            {
                DataTable result = conn.Query(query);

                if (result.Rows.Count > 0 && result.Rows[0]["total"] != DBNull.Value)
                {
                    // Mengonversi hasil query menjadi double
                    return Convert.ToDouble(result.Rows[0]["total"]);
                }
                else
                {
                    // Jika tidak ada hasil atau nilai null, mengembalikan 0
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public double GetPengeluaranMingguan()
        {
            query = "SELECT SUM(nominal) AS total FROM pengeluaran WHERE YEAR(tanggal) = YEAR(CURDATE()) AND WEEK(tanggal) = WEEK(CURDATE());";

            try
            {
                DataTable result = conn.Query(query);

                if (result.Rows.Count > 0 && result.Rows[0]["total"] != DBNull.Value)
                {
                    // Mengonversi hasil query menjadi double
                    return Convert.ToDouble(result.Rows[0]["total"]);
                }
                else
                {
                    // Jika tidak ada hasil atau nilai null, mengembalikan 0
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public double GetPemasukanBulanan()
        {
            query = "SELECT SUM(nominal) AS total FROM pemasukan WHERE YEAR(tanggal) = YEAR(CURDATE()) AND MONTH(tanggal) = MONTH(CURDATE());";

            try
            {
                DataTable result = conn.Query(query);

                if (result.Rows.Count > 0 && result.Rows[0]["total"] != DBNull.Value)
                {
                    // Mengonversi hasil query menjadi double
                    return Convert.ToDouble(result.Rows[0]["total"]);
                }
                else
                {
                    // Jika tidak ada hasil atau nilai null, mengembalikan 0
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public double GetPengeluaranBulanan()
        {
            query = "SELECT SUM(nominal) AS total FROM pengeluaran WHERE YEAR(tanggal) = YEAR(CURDATE()) AND MONTH(tanggal) = MONTH(CURDATE())";

            try
            {
                DataTable result = conn.Query(query);

                if (result.Rows.Count > 0 && result.Rows[0]["total"] != DBNull.Value)
                {
                    // Mengonversi hasil query menjadi double
                    return Convert.ToDouble(result.Rows[0]["total"]);
                }
                else
                {
                    // Jika tidak ada hasil atau nilai null, mengembalikan 0
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public double GetTotalPemasukan()
        {
            query = "SELECT SUM(nominal) AS total FROM pemasukan";

            try
            {
                DataTable result = conn.Query(query);

                if (result.Rows.Count > 0 && result.Rows[0]["total"] != DBNull.Value)
                {
                    // Mengonversi hasil query menjadi double
                    return Convert.ToDouble(result.Rows[0]["total"]);
                }
                else
                {
                    // Jika tidak ada hasil atau nilai null, mengembalikan 0
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public double GetTotalPengeluaran()
        {
            query = "SELECT SUM(nominal) AS total FROM pengeluaran";

            try
            {
                DataTable result = conn.Query(query);

                if (result.Rows.Count > 0 && result.Rows[0]["total"] != DBNull.Value)
                {
                    // Mengonversi hasil query menjadi double
                    return Convert.ToDouble(result.Rows[0]["total"]);
                }
                else
                {
                    // Jika tidak ada hasil atau nilai null, mengembalikan 0
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public double GetTotalKas()
        {
            return GetTotalPemasukan() - GetTotalPengeluaran();
        }

        public double GetPemasukanTahunan()
        {
            query = "SELECT SUM(nominal) AS total FROM pemasukan WHERE YEAR(tanggal) = YEAR(CURDATE());";

            try
            {
                DataTable result = conn.Query(query);

                if (result.Rows.Count > 0 && result.Rows[0]["total"] != DBNull.Value)
                {
                    // Mengonversi hasil query menjadi double
                    return Convert.ToDouble(result.Rows[0]["total"]);
                }
                else
                {
                    // Jika tidak ada hasil atau nilai null, mengembalikan 0
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public double GetPengeluaranTahunan()
        {
            query = "SELECT SUM(nominal) AS total FROM pengeluaran WHERE YEAR(tanggal) = YEAR(CURDATE());";

            try
            {
                DataTable result = conn.Query(query);

                if (result.Rows.Count > 0 && result.Rows[0]["total"] != DBNull.Value)
                {
                    // Mengonversi hasil query menjadi double
                    return Convert.ToDouble(result.Rows[0]["total"]);
                }
                else
                {
                    // Jika tidak ada hasil atau nilai null, mengembalikan 0
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}