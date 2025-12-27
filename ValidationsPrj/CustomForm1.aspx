<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm1.aspx.cs" Inherits="ValidationsPrj.CustomForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Validation - Positive Prime Number</title>

    <script type="text/javascript">
        function IsPrime(source, args) {
            var num = parseInt(args.Value);

            if (args.Value == "") {
                args.IsValid = false;
                alert("Empty Text, Enter Valid Data..");
                return;
            }

            if (num <= 1) {
                args.IsValid = false;
                alert("Not a Positive Prime Number");
                return;
            }

            for (var i = 2; i <= Math.sqrt(num); i++) {
                if (num % i == 0) {
                    args.IsValid = false;
                    alert("Validation Failed...");
                    return;
                }
            }

            args.IsValid = true;
            alert("Validation Succeeded");
        }
    </script>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            Please Enter a Positive Prime Number :
            <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
            &nbsp;&nbsp;

            <asp:CustomValidator 
                ID="CustomValidator1" 
                runat="server"
                ControlToValidate="txtnum"
                ErrorMessage="Not a Positive Prime Number"
                ForeColor="Red"
                ClientValidationFunction="IsPrime"
                OnServerValidate="CustomValidator1_ServerValidate"
                ValidateEmptyText="True">
            </asp:CustomValidator>

            <br /><br />

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />

            <br /><br />

            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
