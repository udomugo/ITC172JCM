<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donations.aspx.cs" Inherits="Donations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href ="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Donation Records</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Your Donations</h1>
        <p>Thanks</p>
        <asp:GridView ID="DonationsGridView" runat="server"></asp:GridView>
    
    </div>
    </form>
</body>
</html>
