<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tip Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter the Total Cost of Meal:"></asp:Label>
            <!-- renamed because text box will be referenced in code -->
            <asp:TextBox ID="MealTextBox" runat="server"></asp:TextBox>
            <asp:RadioButtonList ID="TipPercentsRadioButtonList" runat="server"></asp:RadioButtonList>
            <asp:Label ID="Label2" runat="server" Text="Enter Custom Tip Percentage:"></asp:Label>
            <asp:TextBox ID="OtherTextBox" runat="server"></asp:TextBox>
            <!-- Web pages are stateless, hitting the button will refresh the page -->
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
