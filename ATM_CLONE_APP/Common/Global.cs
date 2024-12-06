using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ATM_CLONE_APP.Common
{
    public class Global
    {
        public bool CheckLogin(string accountnumber, string pin)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString))
                {
                    con.Open();
                    string str = "SELECT * FROM ACCOUNTINFO WHERE ACCOUNTNUMBER=@username AND PIN=@pin";
                    using (SqlCommand cmd = new SqlCommand(str, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue(@"username", accountnumber);
                        cmd.Parameters.AddWithValue("pin", pin);

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if (sdr != null)
                            {
                                if (sdr.Read())
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}