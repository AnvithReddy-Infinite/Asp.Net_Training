<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DbError.aspx.cs" Inherits="Exceptions_Prj.DbError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br /><br />
            <asp:Label ID="Lblmsg" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
