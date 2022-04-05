<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_AddReview.aspx.cs" Inherits="RestaurantReviewSystem_WebClient.Customer_AddReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Review</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container">
            <p class="h3 mt-4">Add Restaurant</p>

        Select Restaurant:
        <asp:DropDownList  class="mt-3" ID="DropDownList1" runat="server" Height="21px" Width="211px">
            <asp:ListItem Value="Select Restaurant">Select Restaurant</asp:ListItem>
        </asp:DropDownList>
        <p class="mt-3">
            Feedback:
            <asp:TextBox ID="txtFeedback" runat="server" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            Rating:
            <asp:TextBox ID="txtRating" runat="server" TextMode="Number" Width="58px"></asp:TextBox>
        
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtRating" ErrorMessage="Give Rating Between 0 to 5 !" ForeColor="Red" MaximumValue="5" MinimumValue="0"></asp:RangeValidator>
        </p>

        <asp:Button class="btn btn-primary" ID="Btn_Add_Review" runat="server" OnClick="Btn_Add_Review_Click" Text="Submit" />
        <br />

        <asp:Label class="h5" ID="lblStauts" runat="server"></asp:Label>
        <br />
        <br />

            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#0066FF" NavigateUrl="~/Customer_Home.aspx">Back To Home</asp:HyperLink>
        </div>
    </form>
</body>
</html>
