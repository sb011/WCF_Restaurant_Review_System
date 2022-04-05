<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main_Page.aspx.cs" Inherits="RestaurantReviewSystem_WebClient.Main_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Resturant Review System</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        
        <div class="container text-center mt-5">
            <asp:Label class="h2" ID="Label1" runat="server"  Text="RESATURANT REVIEW SYSTEM"></asp:Label>
            

            <div class="mt-4">
                <asp:Button class="btn btn-primary mx-3" ID="Btn_Admin_Login" runat="server" OnClick="Btn_Admin_Login_Click" Text="Admin Login" />

        <asp:Button class="btn btn-primary mx-3" ID="Btn_Customer_Login" runat="server" OnClick="Btn_Customer_Login_Click" Text="Customer Login" />
            </div>   
         
        </div>
        
    </form>
</body>
</html>
