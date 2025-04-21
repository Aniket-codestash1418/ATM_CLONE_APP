using ATM_CLONE_APP.Common;
using ATM_CLONE_APP.DataTables;
using ATM_CLONE_APP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ATM_CLONE_APP
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        Global obj = new Global();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AccountInfoModel accountInfoModel = new AccountInfoModel();
            try
            {
                UserModel userModel = new UserModel();
                userModel.UserName = txtUsername.Text;
                userModel.DateOfBirth = Convert.ToDateTime(txtDate.Text);
                userModel.Age = (txtAge.Text is null ? Convert.ToInt32(txtAge.Text) : 0);
                userModel.Address = txtAddress.Text;
                userModel.Email = txtMail.Text;
                userModel.Password = txtPassword.Text;


                var validationContext = new ValidationContext(userModel, null, null);
                var validationResults = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(userModel, validationContext, validationResults, true);
                if (isValid)
                {
                    accountInfoModel = obj.CreateUser(userModel);
                    if (accountInfoModel.StatusCode == 200)
                    {
                        string accno = accountInfoModel.AccountNumber.ToString();
                        string message = "Registration Successful!! Please Login to Continue";
                        // Construct the alert message
                        string alertMessage = $"Account Number: {accno}\\n{message}";
                        //Register the script to show the alert
                        string script = $"<script>alert('{alertMessage.Replace("'", "\\'")}');</script>"; ClientScript.RegisterStartupScript(this.GetType(), "ShowAlert", script);
                        clear();

                    }
                    else
                    {
                        Response.Write("<script>alert('Registration failed!! Please check your credentials')</script>");
                    }
                }
                else
                { // Display validation errors
                    foreach (var validationResult in validationResults)
                    {
                        Response.Write($"<script>alert('{validationResult.ErrorMessage}')</script>");
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
        private void clear()
        {
            txtUsername.Text = string.Empty;
            txtDate.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void CheckUserInput(UserModel model)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}