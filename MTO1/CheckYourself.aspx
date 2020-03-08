<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckYourself.aspx.cs" Inherits="MTO1.CheckYourself" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <asp:Menu ID="MainMenu" runat="server">
            <Items>
                <asp:MenuItem Selectable="False" Text="Выбрать модуль" Value="Выбрать модуль">
                    <asp:MenuItem Text="Проверь себя" Value="Проверь себя"></asp:MenuItem>
                    <asp:MenuItem Text="Генерация заданий" Value="Генерация заданий"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Выйти" Value="Выйти"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" style="margin-left: 603px" Text="Вопрос 1" Width="79px"></asp:Label>
        </div>
    </form>
</body>
</html>
