﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="ATM_CLONE_APP.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="DataTables/dataTables.dataTables.min.css" rel="stylesheet" />
    <link href="fontawesome/css/all.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <style>
        img {
            height: 200px;
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

        .box1 {
            float: left;
            width: 48%;
            border: 1px solid red;
        }

        .box2 {
            float: right;
            width: 48%;
            border: 1px solid blue;
            
        }
    </style>
</head>

<body>
    <div class="card" style="box-shadow: rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px; margin: 50px; opacity: 0.6;">
        <div class="card-body" style="padding: inherit">
            <!-- Image and text -->
            <nav class="navbar">
                <marquee>Welcome to new Bank's ATM!Hope you have a great Day!!</marquee>

            </nav>
        </div>
    </div>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="card card-body">
                    <div class="box1">
                        <asp:Button ID="btnMiniStatement" runat="server" Text="MiniStatement" CssClass=" btn btn-outline-warning" />
                        <asp:Button ID="btnPinGeneration" runat="server" Text="PIN GENERATION" CssClass=" btn btn-outline-warning" />
                        <asp:Button ID="btnBalanceEnquiry" runat="server" Text="Check Balance" CssClass=" btn btn-outline-warning" />

                    </div>
                    <div class="box2">
                        <asp:Button ID="btnDeposit" runat="server" Text="DEPOSIT" CssClass=" btn btn-outline-warning" />
                        <asp:Button ID="btnWithDraw" runat="server" Text="WITHDRAW" CssClass=" btn btn-outline-warning" />
                        <asp:Button ID="btnTransfer" runat="server" Text="TRANSFER" CssClass=" btn btn-outline-warning" />

                    </div>
                    <img src="IMAGES/logoa.jpg" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>