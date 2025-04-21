using System;

namespace ATM_CLONE_APP
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = "Hi " + Session["AuthUserName"].ToString();
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            Server.Transfer("Deposit.aspx", false);
        }
    }
}