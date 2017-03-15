<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome New User!</h1>
        <p>Please Register to Begin</p>
        <p>Last Name <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox></p>
        <p>First Name <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox></p>
        <p>Email <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></p>
        <p>Apartment <asp:TextBox ID="AptTextBox" runat="server"></asp:TextBox></p>
        <p>Street <asp:TextBox ID="StreetTextBox" runat="server"></asp:TextBox></p>
        <p>City <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox></p>
        <p>State <asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox></p>
        <p>Home Phone <asp:TextBox ID="HomePhoneTextBox" runat="server"></asp:TextBox></p>
        <p>Work Phone <asp:TextBox ID="WorkPhoneTextBox" runat="server"></asp:TextBox></p>
        <p>New Password <asp:TextBox ID="NewPassTextBox" runat="server" TextMode="Password"></asp:TextBox></p>
        <p><asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" /></p>
        <p><asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label></p>
        <asp:LinkButton ID="LinkButton1" runat="server"
            PostbackUrl="~/Default.aspx">Go to Login Page</asp:LinkButton>
    </div>
    </form>
</body>
</html>
