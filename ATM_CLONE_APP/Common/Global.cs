using ATM_CLONE_APP.DataTables;
using ATM_CLONE_APP.Models;
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

        public AccountInfoModel CreateUser(UserModel model)
        {
            AccountInfoModel accountInfoModel = new AccountInfoModel();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString))
                {
                    con.Open();
                    string str = "INSERT INTO USERLOGIN(USERNAME,DATEOFBIRTH,AGE,USERADDRESS) VALUES(@Username,@Dob,@Age,@UserAddress)";
                    using (SqlCommand cmd = new SqlCommand(str, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", model.UserName);
                        cmd.Parameters.AddWithValue("@Dob", model.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Age", model.Age);
                        cmd.Parameters.AddWithValue("@UserAddress", model.Address);
                        int response = cmd.ExecuteNonQuery();
                        if (response != 0)
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader != null)
                            {
                                if (reader.Read())
                                {
                                    int userId = (int)reader["USERID"];
                                    accountInfoModel = AddAcccoutInfo(Convert.ToInt32(model.Password), userId);
                                    return accountInfoModel;

                                }
                            }
                            return accountInfoModel;
                        }
                        else
                        {
                            return accountInfoModel;
                        }
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
                    string str = "INSERT INTO ACCOUNTINFO(ACCOUNTNUMBER,PIN,USERID) VALUES(@ACCNO,@PIN,@USERID)";
                    using (SqlCommand cmd = new SqlCommand(str, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@ACCNO", accountNumber);
                        cmd.Parameters.AddWithValue("@PIN", pin);
                        cmd.Parameters.AddWithValue("@USERID", userid);

                        int response = cmd.ExecuteNonQuery();
                        if (response != 0)
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader != null)
                            {
                                if (reader.Read())
                                {
                                    infoModel.AccountNumber = (int)reader["ACCOUNTNUMBER"];
                                    infoModel.StatusCode = 200;
                                    return infoModel;
                                }
                                else
                                {
                                    infoModel.AccountNumber = 0;
                                    infoModel.StatusCode = 400;
                                    return infoModel;
                                }
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
            catch (Exception)
            {

                throw;
            }

            return default;
        }
    }
}