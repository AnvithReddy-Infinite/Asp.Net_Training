<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondSession.aspx.cs" Inherits="WebApplication1.SecondSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblname" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblregion" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="btngetSession" runat="server" Text="Get Session Data" OnClick="btngetSession_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnThird" runat="server" Text="Redirect" OnClick="btnThird_Click" />

        </div>
    </form>
</body>
</html>
