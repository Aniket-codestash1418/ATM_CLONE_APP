<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ATM_CLONE_APP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to New bank's ATM</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="DataTables/dataTables.dataTables.min.css" rel="stylesheet" />
    <link href="fontawesome/css/all.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <style>
     .glass-effect {
         
         border-radius: 10px;
         backdrop-filter: blur(10px);
         -webkit-backdrop-filter: blur(10px);
         box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
         padding: 20px;
     }
     #body {
     background-image: url(IMAGES/IMG.jpg);
     background-size: cover;
     width: auto;
 }
 </style>
</head>
<body id="body">
    <div class="card" style="box-shadow: rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px; margin: 50px; opacity: 0.6;">
     <div class="card-body" style="padding: inherit">
         <!-- Image and text -->
         <nav class="navbar">
             <a class="navbar" href="Login.aspx">
                 <img src="IMAGES/logoa.jpg" width="40" height="40" class="d-inline-block align-top" alt="" />
                 BANK'S ATM
             </a>

         </nav>
     </div>
 </div>
    <form id="form1" runat="server">
        <div style="margin-top:100px">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-md-4">
                        <div class="card glass-effect">
                            <div class="card-header" style="background-color:transparent">
                                <h3 class="text-center">Bank's Login</h3>
                            </div>
                            <div class="card-body">
                                <div class="form-group">
                                    <label for="username">AccountNumber</label>
                                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
                                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required" CssClass="text-danger" Display="Dynamic" />
                                </div>
                                <div class="form-group">
                                    <label for="password">PIN</label>
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" MaxLength="25" />
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" CssClass="text-danger" Display="Dynamic" />
                                </div>
                                <div class="form-group text-center">
                                    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click"/>
                                    <asp:Button ID="btnRegister" runat="server" CausesValidation="false" Text="Register" CssClass=" btn btn-outline-warning" OnClick="btnRegister_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
       </div>
            
    </form>
</body>
</html>
