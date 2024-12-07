<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="ATM_CLONE_APP.RegisterUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register User</title>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="DataTables/dataTables.dataTables.min.css" rel="stylesheet" />
    <link href="fontawesome/css/all.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <style>
      
    </style>
</head>


<body>
    <div class="card" style="box-shadow: rgba(0, 0, 0, 0.3) 0px 19px 38px, rgba(0, 0, 0, 0.22) 0px 15px 12px; opacity: 0.6;">
         <div class="navbar" style="background-color:aliceblue ;">
             <h3>Registration Form</h3>
         </div>
         
 </div>
    <form id="form1" runat="server">
        <div class="container d-flex justify-content-center align-items-center" style="min-height: 100vh;">
            <div class="card">
                <div class="card-body">
                    <div class="mb-3">
                        <label for="lblUserName" class="form-label">UserName</label>
                        <asp:TextBox ID="txtUsername" MaxLength="10" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required" CssClass="text-danger" Display="Dynamic" />
                    </div>
                    <div class="mb-3">
                        <label for="lblDate" class="form-label">DateOfBirth</label>
                        <asp:TextBox ID="txtDate" TextMode="Date" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="lblAge" class="form-label">Age</label>
                        <asp:TextBox ID="txtAge" Enabled="false" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="lblAddress" class="form-label">Address</label>
                        <asp:TextBox ID="txtAddress" MaxLength="30" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address is required" CssClass="text-danger" Display="Dynamic" />
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Email address</label>
                        <asp:TextBox ID="txtMail" runat="server" CssClass="form-control"></asp:TextBox>
                        <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
                        <asp:RequiredFieldValidator ID="rfvMail" runat="server" ControlToValidate="txtMail" ErrorMessage="Email is required" CssClass="text-danger" Display="Dynamic" />
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Password</label>
                        <asp:TextBox ID="txtPassword" TextMode="Password" MaxLength="10" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" CssClass="text-danger" Display="Dynamic" />
                    </div>

                     <asp:Button ID="btnSubmit" CssClass="btn btn-outline-dark" runat="server" Text="Register" OnClick="btnSubmit_Click" />
                     <asp:Button ID="btnCancel" CssClass="btn btn-outline-dark" runat="server" Text="Cancel" />
                     <asp:Button ID="btnLogin" CssClass="btn btn-outline-warning" CausesValidation="false" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    
                </div>
            </div>
        </div>
    </form>
</body>

</html>
