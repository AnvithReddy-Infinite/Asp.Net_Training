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

<h3>View Bills By Consumer & Year</h3>

Consumer Number:
<asp:TextBox ID="txtSearchConsumer" runat="server"></asp:TextBox>

Year:
<asp:TextBox ID="txtSearchYear" runat="server"></asp:TextBox>

<asp:Button ID="btnSearch" runat="server"
            Text="Search"
            OnClick="btnSearch_Click" />

<br /><br />
<asp:GridView ID="gvYearlyBills" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
        <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
        <asp:BoundField DataField="UnitsConsumed" HeaderText="Units Consumed" />
        <asp:TemplateField HeaderText="Bill Amount">
            <ItemTemplate>
                Rs.<%# Eval("BillAmount") %>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="BillMonth" HeaderText="Month" />
        <asp:BoundField DataField="BillYear" HeaderText="Year" />
    </Columns>
</asp:GridView>


<asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

<br /><br />

<asp:GridView ID="gvBills" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
        <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
        <asp:BoundField DataField="UnitsConsumed" HeaderText="Units Consumed" />
        <asp:TemplateField HeaderText="Bill Amount">
            <ItemTemplate>
                Rs.<%# Eval("BillAmount") %>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="BillMonth" HeaderText="Month" />
        <asp:BoundField DataField="BillYear" HeaderText="Year" />
    </Columns>
</asp:GridView>

<br />

<asp:HyperLink ID="lnkBack" runat="server" NavigateUrl="AddElectricityBill.aspx">
    Back to Add Bills
</asp:HyperLink>


        </div>
    </form>
</body>
</html>
