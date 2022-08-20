using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class RetriveCityOrState
    {
        public static bool CheckUserData(string phone, string config)
        {
            string sql = @"SELECT * FROM AspNetUsers WHERE PhoneNumber = @PhoneNumber";
            using (SqlConnection conn = new SqlConnection(config)
                )
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    {
                        return true;  // data exist
                    }
                    else
                    {
                        return false; //data not exist
                    }
                }
            }
        }
    }
}
