<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskGeneration.aspx.cs" Inherits="MTO1.TaskGeneration" %>

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
        }
        .auto-style8 {
            margin-left: 497px;
            margin-top: 0px;
            resize : none;
        }
        .auto-style5 {
            width: 1150px;
            height: 282px;
            margin-left: 93px;
            resize : none;
        }
        .auto-style2 {
            position: relative;
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 1px 0 0 #d7d8db, 0 0 0 1px #e3e4e8;
            resize : none;
        }
        .auto-style4 {
            margin-left:200px;
            resize : none;
        }
        .auto-style9 {
            margin-left: 200px;
            margin-right: 29px;
            padding-top: 5px;
            padding-bottom: 5px;
            margin-bottom: 5px;
            resize : none;
        }
        .auto-style1 {
            margin-left: 200px;
            margin-right: 200px;
            padding-top:5px;
            padding-bottom:5px;
            height:auto;
        }
        .auto-style11 {
            resize:none;
        }
        .auto-style12 {
            margin-left: 200px;
        }
        .auto-style13 {
            margin-left: 0px;
        }
                .auto-style14 {
            position:relative;
            left: 18px;
            top: -36px;
        }
        .auto-style15 {
            position: relative;
            left: 57px;
            top: -36px;
            margin-right: 0px;
        }
        .auto-style16 {
            position: relative;
            left: -50px;
            top: -2px;
        }
        .auto-style17 {
            position: relative;
            left: -11px;
            top: -2px;
        }
        </style>
</head>
<body style="margin-left: 273px; height: 420px;">
    <form id="form2" runat="server">
        <div class="auto-style3">
        <asp:Menu ID="MainMenu0" runat="server" CssClass="auto-style7" Height="80px" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="1.3em" ForeColor="#7C6F57" StaticSubMenuIndent="10px">
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
                <asp:Label ID="CheckYourselfLabel" runat="server" CssClass="auto-style8" Height="25px" Text="Генерация заданий" Font-Size="Larger" OnInit="CheckYourselfLabel_Init"></asp:Label>
            </div>
        <div class="auto-style5">
            <br />
            <div class="auto-style2">
            <asp:Label ID="QuestionLabel2" runat="server" Text="Вычислите определитель матрицы." Width="803px" CssClass="auto-style1"></asp:Label>
                <br />
                <asp:Label ID="Label1" runat="server" CssClass="auto-style12" Font-Size="60pt" Height="100px" Text="["></asp:Label>
                <asp:Label ID="Label3" runat="server" Height="25px" Text="Label" CssClass="auto-style14"></asp:Label>
                <asp:Label ID="Label4" runat="server" Height="25px" Text="Label" CssClass="auto-style15"></asp:Label>
                <asp:Label ID="Label5" runat="server" Height="25px" Text="Label" CssClass="auto-style16"></asp:Label>
                <asp:Label ID="Label6" runat="server" Height="25px" Text="Label" CssClass="auto-style17"></asp:Label>
                <asp:Label ID="Label2" runat="server" CssClass="auto-style13" Font-Size="60pt" Height="100px" Text="]"></asp:Label>
                <br />
            <asp:Label ID="Question1EnterLabel0" runat="server" CssClass="auto-style4" Height="30px" Text="Введите ответ(число) в текстовое поле:" Width="272px"></asp:Label>
                <asp:TextBox ID="AnswerTextBox1" runat="server" Height="25px" Width="368px" AutoCompleteType="Disabled" TextMode="Number" CssClass="auto-style11"></asp:TextBox>
                <br />
                <asp:Button ID="GetAnswerButton1" runat="server" Height="25px" Text="Ответить" CssClass="auto-style9" OnClick="GetAnswerButton1_Click" />
                <asp:Label ID="AnswerLabel1" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
