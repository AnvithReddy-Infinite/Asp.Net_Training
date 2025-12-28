<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBills.aspx.cs" Inherits="ElectricityBillingAutomation.ViewBills" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/Site.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="top-bar">
    <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
</div>


            <h2>View Electricity Bills</h2>

<table>
    <tr>
        <td>Enter Last N Bills:</td>
        <td>
            <asp:TextBox ID="txtLastN" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td></td>
        <td>
            <asp:Button ID="btnGetBills" runat="server" Text="Get Bills" OnClick="btnGetBills_Click" />
        </td>
    </tr>
</table>

<br />

<asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

<br /><br />

<asp:GridView ID="gvBills" runat="server" AutoGenerateColumns="true"></asp:GridView>

<br />

<asp:HyperLink ID="lnkBack" runat="server" NavigateUrl="AddElectricityBill.aspx">
    Back to Add Bills
</asp:HyperLink>


        </div>
    </form>
</body>
</html>
