<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cookie.aspx.cs" Inherits="Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookie</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUserName" runat="server" Text="User Name "></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address "></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number "></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
        <br />
        <br />
        <asp:Button ID="btnCookie" runat="server" Text="Cookie" OnClick="btnCookie_Click" Visible="False"/>
        <asp:Button ID="btnSession" runat="server" Text="Session" OnClick="btnSession_Click" Visible="False" />
        <asp:Button ID="btnCache" runat="server" Text="Cache" OnClick="btnCache_Click" Visible="False" />
        <asp:Button ID="btnQuery" runat="server" Text="Query" OnClick="btnQuery_Click" Visible="False" />
    </div>
    </form>
</body>
</html>
