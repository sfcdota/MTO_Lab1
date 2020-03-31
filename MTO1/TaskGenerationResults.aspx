<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskGenerationResults.aspx.cs" Inherits="MTO1.TaskGenerationResults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">


        .auto-style3 {
            position:absolute;
            left: 30px;
            top: 48px;
            width: 264px;
            height: 155px;
            right: 1114px;
            resize : none;
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
            position: relative;
            margin-top: 78px;
            left: 90px;
            top: -48px;
            width: 1201px;
            resize : none;
            margin-left: 270px;
        }
        .auto-style8 {
            margin-left: 497px;
            margin-top: 0px;
            resize : none;
        }
        .auto-style5 {
            width: 1150px;
            height: 282px;
            margin-left: 360px;
            resize : none;
        }
        .auto-style9 {
            position: relative;
            width: 1123px;
            resize : none;
        }
        .auto-style10 {
            margin-left: 480px;
            margin-top: 0px;
            resize : none;
        }
        .auto-style11 {
            margin-left: 361px;
            margin-top: 19px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="auto-style3">
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
