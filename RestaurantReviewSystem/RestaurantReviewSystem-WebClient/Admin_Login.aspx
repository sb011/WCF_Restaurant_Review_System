<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Login.aspx.cs" Inherits="RestaurantReviewSystem_WebClient.Admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login | Admin</title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 157px;
        }
    </style>
    <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form2" runat="server">
        
        <br />
        <div class="container">
            <p class="h3 mt-4">Admin Login</p>
        <table>
            <tr>
                <td class="auto-style2">Username</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
     
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Username" ForeColor="Red" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <br />

            <tr>
                <td class="auto-style2">Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"></asp:TextBox>
                
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Password" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
        </table>
        <asp:Button class="btn btn-primary mt-3"  ID="Btn_Login" runat="server" OnClick="Btn_Login_Click" Text="Login"/>
        

        
        <br />

        <asp:Label ID="lblStatus" runat="server"></asp:Label>
        </div>

    </form>
    <!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"  ></script>
</body>
</html>
