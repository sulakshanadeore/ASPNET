<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="WebForm1.aspx.cs"
    Inherits="FirstWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:LinkButton ID="LinkButton1" runat="server">Click here</asp:LinkButton>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="131px" ImageUrl="~/bunny1.jpg" Width="277px"  />
    </form>
</body>
</html>
