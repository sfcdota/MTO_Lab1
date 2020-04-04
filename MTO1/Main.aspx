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
        .auto-style3 {
            position:relative;
            width: 264px;
            height: 155px;
            margin-left : 480px;
            margin-top: 0px;
        }
        .auto-style5 {
            width: 1150px;
            height: 70px;
            margin-left: 0px;
            margin-top: 28px;
        }
        .auto-style8 {
            margin-left: 215px;
            margin-top: 0px;
        }
        </style>
</head>
<body style="height: 258px; margin-left: 275px">
    <form id="form2" runat="server">
        <div class="auto-style3">
        <asp:Menu ID="MainMenu0" runat="server" CssClass="auto-style7" Height="80px" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" StaticSubMenuIndent="10px" OnMenuItemClick="MainMenu0_MenuItemClick">
            <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#E3EAEB" />
            <DynamicSelectedStyle BackColor="#1C5E55" />
            <Items>
                <asp:MenuItem Selectable="False" Text="Выбрать модуль" Value="Выбрать модуль">
                    <asp:MenuItem Text="Проверь себя" Value="Проверь себя" NavigateUrl="~/CheckYourself.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Генерация заданий" Value="Генерация заданий" NavigateUrl="~/TaskGeneration.aspx"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Выйти" Value="Выйти"></asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#666666" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" Font-Size="20pt" />
            <StaticSelectedStyle BackColor="#1C5E55" />
        </asp:Menu>
        </div>
        <div class="auto-style5">
        <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Font-Size="40pt" Height="60px" Text="Вы авторизовались по логину "></asp:Label>
        </div>
    </form>
</body>
</html>
