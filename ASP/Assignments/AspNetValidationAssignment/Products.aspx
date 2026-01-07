<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="AspNetValidationAssignment.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product Selection</h2>

<table>
    <tr>
        <td>Select Product:</td>
        <td>
            <asp:DropDownList 
    ID="ddlProducts" 
    runat="server" 
    AutoPostBack="true"
    OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
</asp:DropDownList>

        </td>
    </tr>

    <tr>
        <td>Product Image:</td>
        <td>
            <asp:Image ID="imgProduct" runat="server" Width="200px" Height="200px" />
        </td>
    </tr>

    <tr>
        <td></td>
        <td>
            <asp:Button ID="btnShowPrice" runat="server" Text="Get Price" OnClick="btnShowPrice_Click" />
        </td>
    </tr>

    <tr>
        <td>Price:</td>
        <td>
            <asp:Label ID="lblProductPrice" runat="server" ForeColor="Green"></asp:Label>
        </td>
    </tr>
</table>

        </div>
    </form>
</body>
</html>
