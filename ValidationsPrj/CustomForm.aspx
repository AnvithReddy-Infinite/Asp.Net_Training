<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm.aspx.cs" Inherits="ValidationsPrj.CustomForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Custom Validation Client Side JS enabled</title>
    <script type="text/javascript">
        function IsEven(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
                alert("Empty Text, Enter Valid Data..");
            }
            else {
                if ((args.Value > 0) && (args.Value % 2 == 0)) {
                    args.IsValid = true;
                    alert("Validation Suceeded");
                }
                else {
                    args.IsValid = false;
                    alert("Validation Failed...");
                }
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter a Positive Even Number : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtnum" ErrorMessage="Not a Positive or Even Number" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" ClientValidationFunction="IsEven" ValidateEmptyText="True"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <br /><br />
            <asp:label ID="lblmsg" runat="server"></asp:label>
        </div>
    </form>
</body>
</html>
