using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel.DAO
{
    public class SqlExecuter
    {
        private string path = "Data Source=LAPTOP-SJIHJC72\\SQL2022;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True";
        public SqlExecuter() {}
        public DataTable executeQuery(string query, object[] parameters = null)
        {
            DataTable dt = new DataTable();
            try 
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    SqlDataAdapter adpt = new SqlDataAdapter(query, con);
                    adpt.Fill(dt);

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }
        public void executeNonQuery(string query, object[] parameters = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(path))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
