<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MTO1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 718px;
            margin-top: 150px;
        }
        .auto-style3 {
            margin-left: 0px;
            position: absolute;
            left: 755px;
            top: 372px;
            width: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style3" NavigateUrl="~/Registration.aspx">Регистрация</asp:HyperLink>
            <asp:Login ID="LoginForm" runat="server" OnAuthenticate="LoginForm_Authenticate" CssClass="auto-style1" BackColor="#E3EAEB" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="250px" TextLayout="TextOnTop" Width="300px" DisplayRememberMe="False" UserNameLabelText="Login:">
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <LoginButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" Height="30px" Width="100px" />
                <TextBoxStyle Font-Size="0.8em" Width="250px" />
                <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
            </asp:Login>
        </div>
    </form>
</body>
</html>
