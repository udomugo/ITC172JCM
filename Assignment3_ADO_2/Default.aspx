<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1>Please Log In</h1>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="UserTextBox" placeholder="User Name" runat="server"></asp:TextBox>
        <asp:TextBox ID="PassTextBox" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="LoginSubmitButton" runat="server" Text="Login" OnClick="LoginSubmitButton_Click" />
        <asp:Label ID="ResultLabel" runat="server" Text="Result"></asp:Label>
    </div>
    </form>
</body>
</html>
