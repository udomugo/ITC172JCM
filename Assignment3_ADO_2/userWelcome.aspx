<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userWelcome.aspx.cs" Inherits="userWelcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        
    <div>
        <h1>Welcome User!</h1>
        <asp:DropDownList ID="PersonDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="PersonDropDownList_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GrantExplainGridView" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
