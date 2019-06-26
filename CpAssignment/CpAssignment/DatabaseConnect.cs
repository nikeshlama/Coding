using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CpAssignment
{
    class DatabaseConnect
    {

        SqlConnection con;
        public DatabaseConnect()
        {
            con = new SqlConnection("Data source =DESKTOP-3FU1KJE\\NIKESHSERVER; Initial catalog = dailyexpensessystem; Integrated Security=True");
        }
        public int Executequery(string query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable data(string query)
        {
            try
            {
                SqlDataAdapter sq = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                sq.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
