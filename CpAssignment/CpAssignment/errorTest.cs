using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CpAssignment
{
    public class errorTest
    {
        public static bool CheckDuplicateUsername(string Username)
        {
            try
            {
                string query = "select * from register_tbl where Username='" + Username + "'";
                DatabaseConnect dc = new DatabaseConnect();
                DataTable deuser = dc.data(query);
                if (deuser.Rows.Count > 0)

                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public static bool CheckPasswordLength(string Password)
        {
            if (Password.Length > 5)
                return true;
            else
                return false;
        }
        public static bool PresenceOfTitle(string title)
        {
            if (title == "")
                return true;
            else
                return false;
        }
        public static bool PresenceOfmoney(string money)
        {
            if (money == "")
                return true;
            else
                return false;
        }

    }
}
