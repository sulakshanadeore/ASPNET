<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="FirstWebApp.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Enter ProductID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter ProductName:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Qty:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Select Qty</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Upload File:
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add To Cart" />
        </p>
        <p>
            -------------------------------------------------------------------------------------------------------</p>
        <p>
            &nbsp;</p>
        <p>
            Enter ProductID:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter ProductName:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter Qty:
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Select Qty</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show My Shopping" />
            <asp:ListBox ID="ListBox1" runat="server" Width="393px"></asp:ListBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            ------------------------------------------------------------------------------------------------</p>
        <p>
            Number of clicks to a&nbsp; button:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button3" runat="server" Text="click" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button4" runat="server" Text="Button" />
        </p>
        <p>
            --------------------------------------------------------------------------------------------------</p>
        <p>
            Enter your answer:
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Next" />
            <asp:HiddenField ID="HiddenField1" runat="server" Value="1" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
