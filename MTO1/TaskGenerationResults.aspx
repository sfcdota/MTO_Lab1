<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskGenerationResults.aspx.cs" Inherits="MTO1.TaskGenerationResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style3 {
            width: 264px;
            height: 155px;
            margin-left: 480px;
        }
        .auto-style7 {
            position: relative;
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 1px 0 0 #d7d8db, 0 0 0 1px #e3e4e8;
            padding:10px;
            resize : none;
        }
        .auto-style6 {
            margin-top: 15px;
            width: 1201px;
            margin-left: 0px;
            margin-bottom: 47px;
        }
        .auto-style8 {
            margin-left: 497px;
            margin-top: 0px;
            resize : none;
        }
        .auto-style5 {
            width: 1150px;
            height: 282px;
            margin-left: 0px;
        }
        .auto-style9 {
            position: relative;
            width: 1123px;
            resize : none;
        }
        .auto-style11 {
            margin-left: 365px;
            margin-top: 24px;
        }
        .auto-style10 {
            margin-left: 480px;
            margin-top: 0px;
            resize : none;
        }
        </style>
</head>
<body style="height: 641px; margin-left: 275px">
    <form id="form1" runat="server">
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
            <div class="auto-style6">
                <asp:Label ID="TaskGenerationLabel" runat="server" CssClass="auto-style8" Height="25px" Text="Генерация заданий" Font-Size="Larger"></asp:Label>
            </div>
        <div class="auto-style5">
            <div class="auto-style9">
                <asp:Label ID="StudentResultsLabel" runat="server" CssClass="auto-style10" Height="25px" Text="Результаты студентов" Font-Size="Larger" ForeColor="#66CCFF"></asp:Label>
            </div>
            <asp:GridView ID="ResultGridView" runat="server" AllowSorting="True" BackColor="#CCFF99" CssClass="auto-style11" Font-Names="Arial" Font-Size="16pt">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
