<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deposit.aspx.cs" Inherits="ATM_CLONE_APP.Deposit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Deposit</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <link rel="stylesheet" href="Scripts/bootstrap.min.js" />
    <style>
        .hiddenField {
            margin-bottom: 20px; /* Add some space between the hiddenField and the card */
            text-align: center; /* Center the content */
            float: left;
        }

        .Logout {
            float: right;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="mb-5">
            <div class="hiddenField">
                <asp:Label ID="Label1" Text="www" runat="server"></asp:Label>
            </div>
            <div class="Logout">
                <asp:Button ID="Button1" CssClass="btn btn-outline-danger" runat="server" Text="Logout" />
            </div>
        </div>
        <div class="container d-flex justify-content-center align-items-center" style="height: 100vh">

            <div class="card text-center" style="width: 50%; height: 50%; box-shadow: rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px;">
                <div class="card-body d-flex flex-column justify-content-start align-content-center">
                    <div class="tab-content">
                        <div class="tab-pane fade show active" id="home">
                            <h4 class="card-title">Deposit Here</h4>
                            <h5 class="card-text">Please enter account number</h5>
                            <div class="mb-3">
                                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="Enter Account number"></asp:TextBox>
                            </div>
                            <div class="mb-2">
                                <asp:Label ID="lblAccName" runat="server" ForeColor="#ff0066" Text="www"></asp:Label>
                            </div>



                            <asp:Button runat="server" Text="Deposit" CssClass="btn btn-outline-primary" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="card text-center">
                <div class="card-body">
                    <asp:GridView runat="server" AutoGenerateColumns="false"></asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
