<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="MTO1.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:LinkButton ID="LogoutButton" runat="server" style="margin-left: 1408px" Width="63px">Log out</asp:LinkButton>
        <asp:Menu ID="MainMenu" runat="server" Font-Size="Large">
            <Items>
                <asp:MenuItem Selectable="False" Text="Выбрать модуль" Value="Выбрать модуль">
                    <asp:MenuItem Text="Проверь себя" Value="Проверь себя" NavigateUrl="~/CheckYourself.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Генерация заданий" Value="Генерация заданий" NavigateUrl="~/TaskGeneration.aspx"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Выйти" Value="Выйти"></asp:MenuItem>
            </Items>
        </asp:Menu>
    </form>
</body>
</html>
