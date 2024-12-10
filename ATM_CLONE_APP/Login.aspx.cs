using ATM_CLONE_APP.Common;
using ATM_CLONE_APP.Models;
using System;

namespace ATM_CLONE_APP
{
    public partial class Login : System.Web.UI.Page
    {
        Global obj = new Global();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            LoginResponseModel responseModel = new LoginResponseModel();
            try
            {
                if ((txtUsername.Text.Equals(string.Empty)) || txtPassword.Text.Equals(string.Empty))
                {
                    Response.Write("<script>alert('Please enter Username/Password')</script>");
                }

                responseModel = obj.CheckLogin(txtUsername.Text, txtPassword.Text);
                if (responseModel.StatusCode == 102)
                {
                    //Session["AuthUserName"] = txtUsername.Text;
                    //Response.Redirect("MainPage.aspx");
                    Response.Write("<script>alert('Welcome Admin')</script>");
                    Clear();
                }
                else if (responseModel.StatusCode == 205)
                {
                    //Response.Write("<script>alert('Welcome User')</script>");

                    Session["AuthUserName"] = responseModel.Username;
                    Response.Redirect("MainPage.aspx", false);
                    Clear();
                    // Optionally, call CompleteRequest to bypass the rest of the ASP.NET pipeline
                    Context.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    Response.Write("<script>alert('Login failed!Please check Login Credentials')</script>");
                    Clear();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void Clear()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("RegisterUser.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}