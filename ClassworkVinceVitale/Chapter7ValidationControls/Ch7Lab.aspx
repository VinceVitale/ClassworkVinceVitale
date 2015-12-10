<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ch7Lab.aspx.cs" Inherits="Ch7Lab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chapter 7 Validation Lab</title>
    <style>
        .ValidationRed{
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ErrorMessage="First Name Required" ControlToValidate="txtFirstName" CssClass="ValidationRed" Display="Dynamic">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name "></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ErrorMessage="Last Name Required" ControlToValidate="txtLastName" CssClass="ValidationRed" Display="Dynamic">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Email Required" ControlToValidate="txtEmail" Display="Dynamic" CssClass="ValidationRed">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email(Ex. Name@Email.com)" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic" CssClass="ValidationRed">Invalid</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="lblZipCode" runat="server" Text="Zip Code "></asp:Label>
        <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" ErrorMessage="Zip Code Required" ControlToValidate="txtZipCode" EnableTheming="True" Display="Dynamic" CssClass="ValidationRed">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Zip Code, (Ex. 63025)" ControlToValidate="txtZipCode" ValidationExpression="\d{5}(-\d{4})?" Display="Dynamic" CssClass="ValidationRed">Invalid</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="lblBirthday" runat="server" Text="Birthday "></asp:Label>
        <asp:TextBox ID="txtBirthday" runat="server" Text="mm/dd/yyyy"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvBirthday" runat="server" ErrorMessage="Birthday Required" ControlToValidate="txtBirthday" Display="Dynamic" CssClass="ValidationRed">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator4" runat="server" ErrorMessage="Invalid Date (Ex. 10/18/1995)" Display="Dynamic" Type="Date" ControlToValidate="txtBirthday" Operator="DataTypeCheck" InitialValue="mm/dd/yyyy" CssClass="ValidationRed">Invalid</asp:CompareValidator>
        <br />
        <asp:Label ID="lblState" runat="server" Text="State "></asp:Label>
        <asp:DropDownList ID="ddlState" runat="server">
            <asp:ListItem Value="None" Selected="True">Select a State</asp:ListItem>
            <asp:ListItem>MO</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvState" runat="server" ErrorMessage="State Required" ControlToValidate="ddlState" InitialValue="None" Display="Dynamic" CssClass="ValidationRed">*</asp:RequiredFieldValidator>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StateXHalloweenXConnectionString %>" SelectCommand="SELECT * FROM [States]"></asp:SqlDataSource>
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Password Required" ControlToValidate="txtPassword" Display="Dynamic" CssClass="ValidationRed">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblPasswordCheck" runat="server" Text="Re-enter Password"></asp:Label>
        <asp:TextBox ID="txtPasswordCheck" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords do not match" ControlToCompare="txtPasswordCheck" ControlToValidate="txtPassword" Display="Dynamic" CssClass="ValidationRed">Mismatch</asp:CompareValidator>
        <br />
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvQuantity" runat="server" ErrorMessage="Quantity Required" ControlToValidate="txtQuantity" Display="Dynamic" CssClass="ValidationRed">*</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Quantity must be greater than 0" ControlToValidate="txtQuantity" Operator="GreaterThan" ValueToCompare="0" Type="Integer" CssClass="ValidationRed" Display="Dynamic">Invalid</asp:CompareValidator>
        <br />
        <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvAge" runat="server" ErrorMessage="Age Required" ControlToValidate="txtAge" Display="Dynamic" CssClass="ValidationRed">*</asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age must be between 1 and 110" ControlToValidate="txtAge" MaximumValue="110" MinimumValue="1" Type="Integer" CssClass="ValidationRed" Display="Dynamic">Invalid</asp:RangeValidator>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <br />
        <br />
        <asp:TextBox ID="txtUserInfo" runat="server" Enabled="False" Rows="8" TextMode="MultiLine" Visible="False" Wrap="False" Width="300px"></asp:TextBox>
        <br />
        <asp:Label ID="lblUserInfo" runat="server" Visible="False"></asp:Label>
        <br />
    </div>
    <div id="ValidationSummary">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Please fix the following errors" CssClass="ValidationRed"/>
    </div>
    </form>
</body>
</html>
