<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Add_Restaurant.aspx.cs" Inherits="RestaurantReviewSystem_WebClient.Admin_Add_Restaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Restaurant</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 331px;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body  class="bg-light">
    <form id="form1" runat="server">
        <div class="container">
            <p class="h3 mt-4">Add Restaurant</p>

            <table>
            <tr>
                <td class="auto-style2">Restaurant Name : </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Food Type&nbsp; : </td>
                <td>
                    <asp:TextBox ID="txtFoodType" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Description :</td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">City : </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Contact No :</td>
                <td>
                    <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button class="btn btn-primary mt-3" ID="Btn_Add_Restaurant" runat="server" OnClick="Btn_Add_Restaurant_Click" Text="Add Restaurant" />

        <asp:Label ID="lblStatus" runat="server" class="h5"></asp:Label>
        <br />
        <br />

            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#0066FF" NavigateUrl="~/Admin_Home.aspx">Back To Home</asp:HyperLink>
        </div>
        
    </form>
</body>
</html>
