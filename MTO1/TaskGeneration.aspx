<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskGeneration.aspx.cs" Inherits="MTO1.TaskGeneration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style6 {
            margin-top: 15px;
            width: 1201px;
            margin-bottom: 47px;
        }
        .auto-style8 {
            margin-left: 497px;
            margin-top: 0px;
        }
        .auto-style5 {
            width: 1150px;
            height: 316px;
            margin-left: 25px;
            resize : none;
        }
        .auto-style2 {
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 1px 0 0 #d7d8db, 0 0 0 1px #e3e4e8;
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
        .auto-style3 {
            position:relative;
            width: 264px;
            height: 155px;
            margin-left : 480px;
            margin-top: 0px;
        }
        
        .auto-style7 {
            position: relative;
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 1px 0 0 #d7d8db, 0 0 0 1px #e3e4e8;
            padding:10px;
            resize : none;
        }
        </style>
</head>
<body style="margin-left: 275px; height: 641px;">
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
            <div class="auto-style2">
            <asp:Label ID="QuestionLabel" runat="server" Text="Решите квадратное уравнение. Если уравнение имеет несколько корней,  запишите их через пробел, без запятых. Значения округлить до десятых. Если уравнение не имеет корней или решений бесконечное множество - введите &quot;0&quot;." Width="803px" CssClass="auto-style1" Font-Size="19pt"></asp:Label>
                <br />
                <br />
                <asp:Label ID="EquationLabel" runat="server" CssClass="auto-style12" Font-Size="25pt" Height="50px"></asp:Label>
                <br />
                <br />
            <asp:Label ID="Question1EnterLabel" runat="server" CssClass="auto-style4" Height="30px" Text="Введите ответ в текстовое поле:" Width="272px"></asp:Label>
                <asp:TextBox ID="AnswerTextBox1" runat="server" Height="25px" Width="368px" AutoCompleteType="Disabled" CssClass="auto-style11"></asp:TextBox>
                <br />
                <asp:Button ID="AnswerButton" runat="server" Height="25px" Text="Ответить" CssClass="auto-style9" OnClick="GetAnswerButton1_Click" />
                <asp:Label ID="AnswerLabel" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
                <br />
                <asp:Button ID="NextButton" runat="server" Height="25px" Text="Перейти к следующему заданию" CssClass="auto-style9" OnClick="NextButton_Click" Visible="False" />
            </div>
        </div>
    </form>
</body>
</html>
