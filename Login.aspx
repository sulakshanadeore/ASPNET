<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FirstWebApp.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Username"></asp:Label>
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Enter Password"></asp:Label>
            <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </p>
    </form>
</body>
</html>
