<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ElectricityBillingAutomation.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/Site.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">


            <h2>Admin Login</h2>

<table>
    <tr>
        <td>Username:</td>
        <td>
            <asp:TextBox ID="txtAdminUser" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>Password:</td>
        <td>
            <asp:TextBox ID="txtAdminPass" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td></td>
        <td>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </td>
    </tr>
</table>

<br />

<asp:Label ID="lblLoginMsg" runat="server" ForeColor="Red"></asp:Label>


        </div>
    </form>
</body>
</html>
