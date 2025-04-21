<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="ATM_CLONE_APP.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="DataTables/dataTables.dataTables.min.css" rel="stylesheet" />
    <link href="fontawesome/css/all.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <style>
        .img {
            height: 1px;
            width: 1px;
            display: flex;
            justify-content: center;
            align-items: center;
            opacity: 0.5;
        }

        .card {
            top: 50%;
            box-shadow: 0 0 5px 0;
            background: inherit;
            backdrop-filter: blur(10px);
            margin: 100px;
            text-align: center;

        }
        .hiddenField{
             /*width: 100px;*/
             height: 50px;
             margin-right:auto;
             /*background-color: #c4c4;*/
        }
        .Logout{
            float:right;
            
        }
    </style>
</head>

<body>
    <div class="card" style="box-shadow: rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px; margin: 50px; opacity: 0.6;">
        <div class="card-body" style="padding: inherit">
            <!-- Image and text -->
            <nav class="navbar" style="background-color: mintcream;">
                <marquee>Welcome to new Bank's ATM!Hope you have a great Day!!</marquee>

            </nav>
        </div>
    </div>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="hiddenField">
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                    <div class="Logout">
                        <asp:Button ID="btnLogout" CssClass="btn btn-outline-danger" runat="server" Text="Logout" />
                    </div>
                </div>
                <div class="card1" style="box-shadow: rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px;">

                    <div class="box1">
                        <asp:Button ID="btnMiniStatement" runat="server" Text="MiniStatement" CssClass=" btn btn-outline-warning" /><br /><br />
                        <asp:Button ID="btnPinGeneration" runat="server" Text="PIN GENERATION" CssClass=" btn btn-outline-warning" /><br /><br />
                        <asp:Button ID="btnBalanceEnquiry" runat="server" Text="Check Balance" CssClass=" btn btn-outline-warning" />

                    </div>

                    <%-- <div class="img">
                        <img src="IMAGES/logoa.jpg" />
                    </div>--%>

                    <div class="box2">
                        <asp:Button ID="btnDeposit" runat="server" Text="DEPOSIT" CssClass=" btn btn-outline-warning" OnClick="btnDeposit_Click" /><br /><br />
                        <asp:Button ID="btnWithDraw" runat="server" Text="WITHDRAW" CssClass=" btn btn-outline-warning" /><br /><br />
                        <asp:Button ID="btnTransfer" runat="server" Text="TRANSFER" CssClass=" btn btn-outline-warning" />

                    </div>


                </div>
            </div>
        </div>
    </form>
</body>
</html>
