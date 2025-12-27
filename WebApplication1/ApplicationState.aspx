<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationState.aspx.cs" Inherits="WebApplication1.ApplicationState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:blueviolet">
            <asp:Button ID="BtnApp" runat="server" Text="Get App Count" OnClick="BtnApp_Click" />
            <br /><br />
            <asp:Label ID="lblcount" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
