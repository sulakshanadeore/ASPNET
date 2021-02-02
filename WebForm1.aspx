<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataCachingDemo.WebForm1" %>
<meta  http-equiv="refresh" content="30" />
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
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="270px" TextMode="MultiLine" Width="554px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Set" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Retrieve" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Remove" />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="change" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
