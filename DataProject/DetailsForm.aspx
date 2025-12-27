<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsForm.aspx.cs" Inherits="DataProject.DetailsForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
ody>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [EmployeeID], [LastName], [FirstName] FROM [Employees]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString2 %>" ProviderName="<%$ ConnectionStrings:NorthwindConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [Employees] WHERE ([EmployeeID] = @EmployeeID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="EmployeeID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
&nbsp;<asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="EmployeeID" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="TitleOfCourtesy" HeaderText="TitleOfCourtesy" SortExpression="TitleOfCourtesy" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate" />
                <asp:BoundField DataField="HireDate" HeaderText="HireDate" SortExpression="HireDate" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="HomePhone" HeaderText="HomePhone" SortExpression="HomePhone" />
                <asp:BoundField DataField="Extension" HeaderText="Extension" SortExpression="Extension" />
                <asp:BoundField DataField="Notes" HeaderText="Notes" SortExpression="Notes" />
                <asp:BoundField DataField="ReportsTo" HeaderText="ReportsTo" SortExpression="ReportsTo" />
                <asp:BoundField DataField="PhotoPath" HeaderText="PhotoPath" SortExpression="PhotoPath" />
            </Fields>
        </asp:DetailsView>
    </form>
</body>
</html>
