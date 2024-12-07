﻿using ATM_CLONE_APP.Common;
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
            try
            {
                if ((txtUsername.Text.Equals(string.Empty)) || txtPassword.Text.Equals(string.Empty))
                {
                    Response.Write("<script>alert('Please enter Username/Password')</script>");
                }

                int checkLogin = obj.CheckLogin(txtUsername.Text, txtPassword.Text);
                if (checkLogin == 102)
                {
                    //Session["AuthUserName"] = txtUsername.Text;
                    //Response.Redirect("MainPage.aspx");
                    Response.Write("<script>alert('Welcome Admin')</script>");
                    Clear();
                }
                else if (checkLogin == 105)
                {
                    Response.Write("<script>alert('Welcome User')</script>");
                    Clear();
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