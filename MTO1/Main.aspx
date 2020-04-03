<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="MTO1.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style7 {
            position: relative;
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 1px 0 0 #d7d8db, 0 0 0 1px #e3e4e8;
            padding:10px;
            resize : none;
        }
        .auto-style8 {
            margin-left: 546px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Menu ID="MainMenu0" runat="server" CssClass="auto-style7" Height="80px" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="1.3em" ForeColor="#7C6F57" StaticSubMenuIndent="10px" OnMenuItemClick="MainMenu0_MenuItemClick">
            <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#F7F6F3" />
            <DynamicSelectedStyle BackColor="#5D7B9D" />
            <Items>
                <asp:MenuItem Selectable="False" Text="Выбрать модуль" Value="Выбрать модуль">
                    <asp:MenuItem Text="Проверь себя" Value="Проверь себя" NavigateUrl="~/CheckYourself.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Генерация заданий" Value="Генерация заданий" NavigateUrl="~/TaskGeneration.aspx"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Выйти" Value="Выйти"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#5D7B9D" />
        </asp:Menu>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Font-Size="40pt" Height="60px" Text="Вы авторизовались по логину "></asp:Label>
    </form>
</body>
</html>
