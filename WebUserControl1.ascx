<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="CachingDemo.WebUserControl1" %>
<%@ OutputCache Duration="20" VaryByParam="None"/>
<p>
    Enter No1<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    Enter No2<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
<p>