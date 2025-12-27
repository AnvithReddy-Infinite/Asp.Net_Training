<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataForm_withDS.aspx.cs" Inherits="DataProject.DataForm_withDS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CategoryID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" InsertVisible="False" ReadOnly="True" SortExpression="CategoryID" />
                    <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" SortExpression="CategoryName" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString.ProviderName %>" SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]"></asp:SqlDataSource>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
