<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Welcome! Please Register to Make a Donation.</h1>
        <table>
            <tr>
                <td>First Name</td>
                <td><asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox></td>
                <td><asp:RequiredFieldValidator ID="FirstNameValidator" runat="server" ErrorMessage="First Name is Required" ControlToValidate="FirstNameTextbox"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td><asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="LastNameValidator" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="LastNameTextbox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Eamil</td>
                <td><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ID="EmailValidator" runat="server" ErrorMessage="Email is Required" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="EmailRegularExpressionValidator" runat="server" ErrorMessage="Invalid Email" ControlToValidate="EmailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Apt. Number</td>
                <td><asp:TextBox ID="ApartmentTextBox" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Street</td>
                <td><asp:TextBox ID="StreetTextBox" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>City</td>
                <td><asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>State</td>
                <td><asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Zipcode</td>
                <td><asp:TextBox ID="ZipcodeTextBox" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Home Phone</td>
                <td><asp:TextBox ID="HomePhoneTextBox" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Work Phone</td>
                <td><asp:TextBox ID="WorkPhoneTextBox" runat="server"></asp:TextBox></td>
                <td></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="NewPassTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
                <td></td>
            </tr>
            
            <tr>
                <td>Confirm Password</td>
                <td><asp:TextBox ID="ConfirmPassTextBox" runat="server" TextMode="Password"></asp:TextBox></td>
                <td><asp:CompareValidator ID="PasswordCompareValidator" runat="server" ErrorMessage="Passwords Do Not Match" ControlToValidate="ConfirmPassTextBox" ControlToCOmpare="NewPassTextBox"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td><asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></td>
                <td><!-- <asp:Label ID="ResultLabel" runat="server" Text="Result"></asp:Label> --></td>
                <td></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
