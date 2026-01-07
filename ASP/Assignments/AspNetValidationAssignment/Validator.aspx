<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="AspNetValidationAssignment.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>User Validation Form</h2>

<table>
    <tr>
        <td>Name:</td>
        <td>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>Family Name:</td>
        <td>
            <asp:TextBox ID="txtFamilyName" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>Address:</td>
        <td>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>City:</td>
        <td>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>Zip Code:</td>
        <td>
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>Phone:</td>
        <td>
            <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>Email:</td>
        <td>
            <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td></td>
        <td>
            <asp:Button ID="btnCheckDetails" runat="server" Text="Check" OnClick="btnCheckDetails_Click" />
        </td>
    </tr>
</table>

<br />

<asp:Label ID="lblResultMessage" runat="server" ForeColor="Red"></asp:Label>

        </div>
    </form>
</body>
</html>
