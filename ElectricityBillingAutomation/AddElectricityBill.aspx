<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddElectricityBill.aspx.cs" Inherits="ElectricityBillingAutomation.AddElectricityBill" %>

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


            <h2>Add Electricity Bill</h2>

<table>
    <tr>
        <td>Consumer Number:</td>
        <td>
            <asp:TextBox ID="txtConsumerNumber" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>Consumer Name:</td>
        <td>
            <asp:TextBox ID="txtConsumerName" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>Units Consumed:</td>
        <td>
            <asp:TextBox ID="txtUnitsConsumed" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td></td>
        <td>
            <asp:Button ID="btnAddBill" runat="server" Text="Add Bill" OnClick="btnAddBill_Click" />
        </td>
    </tr>
</table>

<br />
            <br />

            <br />
<asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
<br />


<asp:HyperLink ID="lnkViewBills" runat="server" NavigateUrl="ViewBills.aspx">
    View Electricity Bills
</asp:HyperLink>


        </div>
    </form>
</body>
</html>
