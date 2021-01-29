<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="FirstWebApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Enter City"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="122px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" SelectionMode="Multiple" Width="104px"></asp:ListBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btn_submit" runat="server" Text="Submit" />
            </asp:Panel>
        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
    </form>
</body>
</html>
