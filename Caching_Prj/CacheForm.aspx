<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheForm.aspx.cs" Inherits="Caching_Prj.CacheForm" %>
<%--<%@ OutputCache Duration="30" VaryByParam="None" Location="Client" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        Select a Product  : &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DDL" runat="server" OnSelectedIndexChanged="DDL_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Text="All" Value="All"></asp:ListItem>
             <asp:ListItem Text="Laptops" Value="Laptops"></asp:ListItem>
             <asp:ListItem Text="Desktops" Value="Desktop"></asp:ListItem>
             <asp:ListItem Text="iPhones" Value="iPhone"></asp:ListItem>
             <asp:ListItem Text="LED TV" Value="LED TV"></asp:ListItem>
        </asp:DropDownList>
       
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <br />

        Server Time : <br />
        <asp:Label ID="lblmsg" runat="server"></asp:Label>
        <br /> <br />

        Client Time :
        <br /> <br />

        <script>
            document.write(Date());
        </script>

    </form>
</body>
</html>
