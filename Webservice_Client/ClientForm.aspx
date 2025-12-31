<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientForm.aspx.cs" Inherits="Webservice_Client.ClientForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter User Name : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
<br /><br />
            Enter a Decimal Number : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtfnum" runat="server"></asp:TextBox>
<br /><br />
<asp:Button ID="Btnhello" runat="server" Text="Hello World" OnClick="Btnhello_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Btnsayhello" runat="server" Text="Say Hello" OnClick="Btnsayhello_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Btnsq" runat="server" Text="For Square" OnClick="Btnsq_Click"/>
<br /> <br />
<asp:Label ID="lblstatus" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
