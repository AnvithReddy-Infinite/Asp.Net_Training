<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieSource.aspx.cs" Inherits="WebApplication1.CookieSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:Label ID="lblusername" runat="server" Text="User Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtusername" runat="server" Width="191px" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <br />
<br />
            <asp:Button ID="BtnStore" runat="server" Text="Store Data" OnClick="BtnStore_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnRedirect" runat="server" Text="Redirect Data" OnClick="BtnRedirect_Click" />
            <br />
            <p>
                <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
            </p>

        </div>
    </form>
</body>
</html>
