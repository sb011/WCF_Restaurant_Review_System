<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Review.aspx.cs" Inherits="RestaurantReviewSystem_WebClient.Admin_Review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Review | Admin</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 375px;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        
        <div class="container">
            <p class="h3 my-5">Manage Review</p>

        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
    OnRowDeleting="GridView1_RowDeleting" OnRowDataBound="GridView1_RowDataBound" DataKeyNames="Id">
            <Columns>
    <asp:CommandField ShowDeleteButton="true" />
    
</Columns>
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        
        <asp:Label ID="lblStautus" runat="server" class="h5"></asp:Label>
        <br />

        <br />

            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#0066FF" NavigateUrl="~/Admin_Home.aspx">Back To Home</asp:HyperLink>
        </div>
    </form>
</body>
</html>
