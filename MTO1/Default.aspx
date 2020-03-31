<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MTO1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 718px;
        }
        .auto-style3 {
            margin-left: 0px;
            position: absolute;
            left: 750px;
            top: 392px;
            width: 91px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style3" NavigateUrl="~/Registration.aspx">Регистрация</asp:HyperLink>
            <asp:Login ID="LoginForm" runat="server" OnAuthenticate="LoginForm_Authenticate" style="margin-top: 297px" CssClass="auto-style1">
            </asp:Login>
        </div>
    </form>
</body>
</html>
