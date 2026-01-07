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
    <td>Bill Month:</td>
    <td>
        <asp:DropDownList ID="ddlMonth" runat="server">
            <asp:ListItem>JAN</asp:ListItem>
            <asp:ListItem>FEB</asp:ListItem>
            <asp:ListItem>MAR</asp:ListItem>
            <asp:ListItem>APR</asp:ListItem>
            <asp:ListItem>MAY</asp:ListItem>
            <asp:ListItem>JUN</asp:ListItem>
            <asp:ListItem>JUL</asp:ListItem>
            <asp:ListItem>AUG</asp:ListItem>
            <asp:ListItem>SEP</asp:ListItem>
            <asp:ListItem>OCT</asp:ListItem>
            <asp:ListItem>NOV</asp:ListItem>
            <asp:ListItem>DEC</asp:ListItem>
        </asp:DropDownList>
    </td>
</tr>

<tr>
    <td>Bill Year:</td>
    <td>
        <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
    </td>
</tr>


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

            <h3>Recently Added Bill</h3>

<asp:GridView ID="gvLatestBill" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
        <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
        <asp:BoundField DataField="UnitsConsumed" HeaderText="Units" />
        <asp:TemplateField HeaderText="Bill Amount">
            <ItemTemplate>
                Rs.<%# Eval("BillAmount") %>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="BillMonth" HeaderText="Month" />
        <asp:BoundField DataField="BillYear" HeaderText="Year" />
    </Columns>
</asp:GridView>
    </form>

</body>
</html>
