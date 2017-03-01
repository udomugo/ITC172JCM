<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Donation Portal</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Donate</h1>
        <p>How Much Would You Like to Donate?</p>
        <p>$<asp:TextBox ID="DonationTextBox" runat="server" TextMode="Number"></asp:TextBox></p>
        <p><asp:Button ID="DonateButton" runat="server" Text="Donate" OnClick="DonateButton_Click" /></p>
        <p><asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label></p>
    </div>
    </form>
</body>
</html>
