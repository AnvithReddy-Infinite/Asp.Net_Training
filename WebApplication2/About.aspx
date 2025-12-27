<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your application description page.</h3>

        <p>Use this area to provide additional information.</p>
        <p>Hello ASP</p>
    <p>
        <asp:TextBox ID ="Txtname" runat="server" Text=""></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
    </p>
    <p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <input id="Button2" type="button" value="button" /></p>

    </main>
</asp:Content>