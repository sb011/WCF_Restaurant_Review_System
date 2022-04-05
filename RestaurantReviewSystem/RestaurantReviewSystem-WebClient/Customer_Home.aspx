<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_Home.aspx.cs" Inherits="RestaurantReviewSystem_WebClient.Customer_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home | Customer</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container text-center">
            <p class="h1 mt-5">
                Welcome
                <asp:Label class="h2" ID="Label1" runat="server"></asp:Label>
            </p>

            <div class="mt-5">
                
        <asp:Button class="btn btn-primary btn-lg mx-3" ID="Button2" runat="server" Text="Add Review" OnClick="Button2_Click" />

        <asp:Button class="btn btn-primary btn-lg mx-3" ID="Button3" runat="server" Text="Display All Reviews" OnClick="Button3_Click" />
            
        <asp:Button class="btn btn-primary btn-lg mx-3" ID="Button4" runat="server" Text="Update Profile" OnClick="Button4_Click" />

        <asp:Button class="btn btn-danger btn-lg mx-3" ID="Btn_Logout" runat="server" OnClick="Btn_Logout_Click" Text="Logout"/>
        </div>
    </div>
    </form>
</body>
</html>
