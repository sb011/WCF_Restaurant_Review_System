<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Home.aspx.cs" Inherits="RestaurantReviewSystem_WebClient.Admin_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home | Admin</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container text-center">
            <p class="h1 mt-5">
               Welcome Admin
            </p>

            <div class="mt-5">
                <asp:Button class="btn btn-primary btn-lg mx-3" ID="Btn_Restaurant" runat="server" OnClick="Btn_Restaurant_Click" Text="Restaurant" />

        <asp:Button class="btn btn-primary btn-lg mx-3" ID="Btn_Review" runat="server" OnClick="Btn_Review_Click" Text="Review" />

        <asp:Button class="btn btn-primary btn-lg mx-3" ID="Btn_User" runat="server" OnClick="Btn_User_Click" Text="Customer"/>

        <asp:Button class="btn btn-danger btn-lg  mx-3" ID="Btn_Logout" runat="server" OnClick="Btn_Logout_Click" Text="Logout"/></div>
         
        </div>
    
        
    </form>
</body>
</html>
