<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckYourself.aspx.cs" Inherits="MTO1.CheckYourself" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 200px;
            margin-right: 200px;
            padding-top:5px;
            padding-bottom:5px;
            height:auto;
        }
        .auto-style2 {
            position: relative;
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 1px 0 0 #d7d8db, 0 0 0 1px #e3e4e8;
        }
        .auto-style3 {
            position:absolute;
            left: 8px;
            top: 14px;
            width: 154px;
            height: 155px;
            right: 1246px;
        }
        .auto-style4 {
            margin-left: 200px;
            margin-right: 200px;
        }
        .auto-style5 {
            width: 1150px;
            height: 748px;
            margin-left: 160px;
        }
        .auto-style6 {
            position: relative;
            margin-top: 78px;
            left: 141px;
            top: -50px;
            width: 1228px;
        }
        .auto-style7 {
            position: relative;
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 1px 0 0 #d7d8db, 0 0 0 1px #e3e4e8;
            padding:10px;
        }
        .auto-style8 {
            margin-left: 616px;
            margin-top: 0px;
        }
        .auto-style9 {
            margin-left: 200px;
            margin-right: 29px;
            padding-top: 5px;
            padding-bottom: 5px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="auto-style3">
        <asp:Menu ID="MainMenu0" runat="server" CssClass="auto-style7" Height="60px">
            <Items>
                <asp:MenuItem Selectable="False" Text="Выбрать модуль" Value="Выбрать модуль">
                    <asp:MenuItem Text="Проверь себя" Value="Проверь себя"></asp:MenuItem>
                    <asp:MenuItem Text="Генерация заданий" Value="Генерация заданий"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Выйти" Value="Выйти"></asp:MenuItem>
            </Items>
        </asp:Menu>
        </div>
            <div class="auto-style6">
                <asp:Label ID="Label18" runat="server" CssClass="auto-style8" Height="25px" Text="Label"></asp:Label>
            </div>
        <div class="auto-style5">
            <div class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Вопрос 1" Width="79px" CssClass="auto-style1"></asp:Label>
                <br />
            <asp:Label ID="Label2" runat="server" CssClass="auto-style4" Height="30px" Text="Введите ответ в текстовое поле:" Width="228px"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="368px"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Height="25px" Text="Button" CssClass="auto-style9" />
                <asp:Label ID="Label23" runat="server" Height="25px" Text="Label"></asp:Label>
            </div>
            <br />
            <div class="auto-style2">
            <asp:Label ID="Label3" runat="server" Text="Вопрос 2" Width="79px" CssClass="auto-style1"></asp:Label>
                <br />
            <asp:Label ID="Label4" runat="server" CssClass="auto-style4" Height="30px" Text="Введите число в текстовое поле:" Width="228px"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="364px"></asp:TextBox>
                <br />
                <asp:Button ID="Button2" runat="server" Height="25px" Text="Button" CssClass="auto-style9" />
                <asp:Label ID="Label22" runat="server" Height="25px" Text="Label"></asp:Label>
            </div>
            <br />
            <div class="auto-style2">
            <asp:Label ID="Label5" runat="server" Text="Вопрос 3" Width="79px" CssClass="auto-style1"></asp:Label>
                <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="83px" Width="193px" CssClass="auto-style4">
            </asp:RadioButtonList>
            <asp:RadioButton ID="RadioButton1" runat="server" CssClass="auto-style4" Height="25px" />
            <asp:RadioButton ID="RadioButton2" runat="server" Height="25px" />
                <br />
            <asp:RadioButton ID="RadioButton3" runat="server" CssClass="auto-style4" Height="25px" />
            <asp:RadioButton ID="RadioButton4" runat="server" Height="25px" />
                <br />
                <asp:Button ID="Button3" runat="server" Height="25px" Text="Button" CssClass="auto-style9" />
                <asp:Label ID="Label21" runat="server" Height="25px" Text="Label"></asp:Label>
            </div>
            <br />
            <div class="auto-style2">
            <asp:Label ID="Label7" runat="server" Text="Вопрос 4" Width="79px" CssClass="auto-style1"></asp:Label>
                <br />
            <asp:CheckBox ID="CheckBox1" runat="server" CssClass="auto-style4" Height="25px" />
            <asp:CheckBox ID="CheckBox2" runat="server" Height="25px" />
                <br />
            <asp:CheckBox ID="CheckBox3" runat="server" CssClass="auto-style4" Height="25px" />
            <asp:CheckBox ID="CheckBox4" runat="server" Height="25px" />
                <br />
                <asp:Button ID="Button4" runat="server" Height="25px" Text="Button" CssClass="auto-style9" />
                <asp:Label ID="Label20" runat="server" Height="25px" Text="Label"></asp:Label>
                <br />
            </div>
            <br />
            <div class="auto-style2">
            <asp:Label ID="Label9" runat="server" Text="Вопрос 5" Width="79px" CssClass="auto-style1"></asp:Label>
                <br />
            <asp:Label ID="Label10" runat="server" CssClass="auto-style4" Height="25px" Text="Label"></asp:Label>
            <asp:Label ID="Label11" runat="server" Height="25px" Text="Label"></asp:Label>
                <br />
            <asp:Label ID="Label12" runat="server" CssClass="auto-style4" Height="25px" Text="Label"></asp:Label>
            <asp:Label ID="Label13" runat="server" Height="25px" Text="Label"></asp:Label>
                <br />
            <asp:Label ID="Label14" runat="server" CssClass="auto-style4" Height="25px" Text="Label"></asp:Label>
            <asp:Label ID="Label15" runat="server" Height="25px" Text="Label"></asp:Label>
                <br />
            <asp:Label ID="Label16" runat="server" CssClass="auto-style4" Height="25px" Text="Label"></asp:Label>
            <asp:Label ID="Label17" runat="server" Height="25px" Text="Label"></asp:Label>
                <br />
                <asp:Button ID="Button5" runat="server" Height="25px" Text="Button" CssClass="auto-style9" />
                <asp:Label ID="Label19" runat="server" Height="25px" Text="Label"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
