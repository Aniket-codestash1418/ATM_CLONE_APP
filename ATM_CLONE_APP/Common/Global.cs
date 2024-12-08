using ATM_CLONE_APP.DataTables;
using ATM_CLONE_APP.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ATM_CLONE_APP.Common
{
    public class Global
    {
        public int CheckLogin(string accountnumber, string pin)
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
                                    if (sdr["ACCOUNTNUMBER"].ToString() == "12345" && sdr["PIN"].ToString() == "1")
                                    {
                                        return 102;
                                    }
                                    else
                                        return 105;
                                }
                                else
                                {
                                    return 400;
                                }
                            }
                        }
                    }
                }
                return 0;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public AccountInfoModel CreateUser(UserModel model)
        {
            AccountInfoModel accountInfoModel = new AccountInfoModel();
            int response = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString))
                {
                    con.Open();
                    //string str = "INSERT INTO USERLOGIN(USERNAME,DATEOFBIRTH,AGE,USERADDRESS) VALUES(@Username,@Dob,@Age,@UserAddress)";
                    string str = @" INSERT INTO USERLOGIN (USERNAME, DATEOFBIRTH,AGE, USERADDRESS,EMAILS) OUTPUT INSERTED.USERID, INSERTED.USERNAME, INSERTED.DATEOFBIRTH, INSERTED.AGE, INSERTED.USERADDRESS,INSERTED.EMAILS VALUES (@Username, @DateOfBirth,@Age, @Address,@Emails)";
                    using (SqlCommand cmd = new SqlCommand(str, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", model.UserName);
                        cmd.Parameters.AddWithValue("@DateOfBirth", model.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Age", model.Age);
                        cmd.Parameters.AddWithValue("@Address", model.Address);
                        cmd.Parameters.AddWithValue("@Emails", model.Email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    int userId = reader.GetInt32(0);
                                    int userIds = (int)reader["USERID"];
                                    accountInfoModel = AddAcccoutInfo(Convert.ToInt32(model.Password), userIds);
                                    return accountInfoModel;
                                }
                                //int userId = reader.GetInt64


                            }
                        }
                        return accountInfoModel;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        private AccountInfoModel AddAcccoutInfo(int pin, int userid)
        {
            AccountInfoModel infoModel = new AccountInfoModel();
            try
            {
                Random random = new Random();
                int accountNumber = random.Next(10000, 100000);

                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString))
                {
                    con.Open();
                    string str = "INSERT INTO ACCOUNTINFO(ACCOUNTNUMBER,PIN,USERID) OUTPUT INSERTED.ACCOUNTID,INSERTED.ACCOUNTNUMBER,INSERTED.PIN,INSERTED.USERID VALUES(@ACCNO,@PIN,@USERID)";
                    using (SqlCommand cmd = new SqlCommand(str, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@ACCNO", accountNumber);
                        cmd.Parameters.AddWithValue("@PIN", pin);
                        cmd.Parameters.AddWithValue("@USERID", userid);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                if (reader.Read())
                                {
                                    infoModel.AccountNumber = Convert.ToInt32(reader["ACCOUNTNUMBER"]);
                                    infoModel.StatusCode = 200;
                                    return infoModel;
                                }

                            }
                            else
                            {
                                infoModel.AccountNumber = 0;
                                infoModel.StatusCode = 400;
                                return infoModel;
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return default;
        }
    }
}