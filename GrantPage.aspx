<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GrantPage.aspx.cs" Inherits="GrantPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Apply for a Grant</h1>
        <asp:DropDownList ID="GrantsDropDownList" runat="server"></asp:DropDownList>

        <p>Reason for Grant Request <asp:TextBox ID="ExplainTextBox" runat="server"></asp:TextBox></p>
        <p>Enter the Amount $ <asp:TextBox ID="AmountTextBox" runat="server"></asp:TextBox></p>
        <p><asp:Button ID="GrantButton" runat="server" Text="Submit" OnClick="GrantButton_Click" />
        <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></p>
    </div>
    </form>
</body>
</html>
