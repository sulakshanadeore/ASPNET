<%@ Page Language="C#" Theme="Blue" EnableTheming="true" AutoEventWireup="true" CodeBehind="BlueTheme.aspx.cs" Inherits="MasterPagesDemo.BlueTheme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 439px;
            background-color: #00FFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="height: 500px; width: 500px;color:cyan;background-color:bisque">
                <tr>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server" SkinID="BlueCalendar" EnableTheming="False"></asp:Calendar>
                    </td>
                    <td>              <asp:Calendar ID="Calendar2" runat="server" SkinID="BlueCalendar" ></asp:Calendar></td>
                </tr>
                <tr>
                    <td>sdfsdfsfsf</td>
                    <td>sdfsfsf</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
