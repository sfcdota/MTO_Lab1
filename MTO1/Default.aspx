<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MTO1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Login ID="LoginForm" runat="server" OnAuthenticate="LoginForm_Authenticate" style="margin-left: 626px; margin-top: 297px">
            </asp:Login>
        </div>
    </form>
</body>
</html>
