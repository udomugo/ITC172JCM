﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href ="StyleSheet.css" rel ="stylesheet" type="text/css" />
    <title>Welcome to Community Assist Donations</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Please Sign In</h1>
        <table>
            <tr>
                <td>User Name</td>
                <td><asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" /></td>
                <td><asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        <!--add a link button so that the can register if they can't login.
            a plain hyperlink would work as well-->
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackURL="~/Register.aspx">Register</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackURL="~/Donate.aspx">Donate</asp:LinkButton>
    </div>
    </form>
</body>
</html>
