<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar & Events</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="cal">
        <h1>Agenda Schedule</h1>
        <asp:Calendar ID="todoCalendar" runat="server" OnSelectionChanged="todoCalendar_SelectionChanged"></asp:Calendar>
        <asp:Table ID="AgendaTable" runat="server" CellPadding="10"></asp:Table>
    </div>
    </form>
</body>
</html>
