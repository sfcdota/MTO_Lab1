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
            margin-left:200px;
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
            margin-bottom: 5px;
        }
        .auto-style10 {
            margin-left: 200px;

        }
        .auto-style11 {
            
        }
        .auto-style12 {
            position: absolute;
            padding-left: 180px;
        }
        .auto-style13 {
            margin-left: 200px;
            margin-right: 200px;
            padding-top: 5px;
            padding-bottom: 5px;
        }
        .auto-style14 {
            margin-left: 193px;
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
                <asp:Label ID="CheckYourselfLabel" runat="server" CssClass="auto-style8" Height="25px" Text="Проверь себя" OnInit="CheckYourselfLabel_Init"></asp:Label>
            </div>
        <div class="auto-style5">
            <div class="auto-style2">
            <asp:Label ID="QuestionLabel1" runat="server" Text="Вопрос 1" Width="803px" CssClass="auto-style13"></asp:Label>
                <br />
            <asp:Label ID="Question1EnterLabel" runat="server" CssClass="auto-style4" Height="30px" Text="Введите ответ в текстовое поле:" Width="228px"></asp:Label>
                <asp:TextBox ID="AnswerTextBox1" runat="server" Height="25px" Width="368px"></asp:TextBox>
                <br />
                <asp:Button ID="GetAnswerButton1" runat="server" Height="25px" Text="Ответить" CssClass="auto-style9" OnClick="GetAnswerButton1_Click" />
                <asp:Label ID="AnswerLabel1" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
            </div>
            <br />
            <div class="auto-style2">
            <asp:Label ID="QuestionLabel2" runat="server" Text="Вопрос 2" Width="803px" CssClass="auto-style1"></asp:Label>
                <br />
            <asp:Label ID="Question2EnterLabel" runat="server" CssClass="auto-style4" Height="30px" Text="Введите число в текстовое поле:" Width="228px"></asp:Label>
                <asp:TextBox ID="AnswerTextBox2" runat="server" Height="25px" Width="364px"></asp:TextBox>
                <br />
                <asp:Button ID="GetAnswerButton2" runat="server" Height="25px" Text="Ответить" CssClass="auto-style9" OnClick="GetAnswerButton2_Click" />
                <asp:Label ID="AnswerLabel2" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
            </div>
            <br />
            <div class="auto-style2">
            <asp:Label ID="QuestionLabel3" runat="server" Text="Вопрос 3" Width="803px" CssClass="auto-style1"></asp:Label>
                <br />
                <asp:RadioButtonList ID="Question3RadioButtonList" runat="server" CssClass="auto-style14" Width="752px" CellPadding="5" RepeatColumns="2" RepeatDirection="Horizontal">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="GetAnswerButton3" runat="server" Height="25px" Text="Ответить" CssClass="auto-style9" OnClick="GetAnswerButton3_Click" />
                <asp:Label ID="AnswerLabel3" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
            </div>
            <br />
            <div class="auto-style2">
            <asp:Label ID="QuestionLabel4" runat="server" Text="Вопрос 4" Width="803px" CssClass="auto-style1"></asp:Label>
                <br />
            <asp:CheckBox ID="Question4CheckBox1" runat="server" CssClass="auto-style4" Height="25px" Width="200px" />
            <asp:CheckBox ID="Question4CheckBox2" runat="server" Height="25px" CssClass="auto-style12" />
                <br />
            <asp:CheckBox ID="Question4CheckBox3" runat="server" CssClass="auto-style4" Height="25px" Width="200px" />
            <asp:CheckBox ID="Question4CheckBox4" runat="server" Height="25px" CssClass="auto-style12" />
                <br />
                <asp:Button ID="GetAnswerButton4" runat="server" Height="25px" Text="Ответить" CssClass="auto-style9" OnClick="GetAnswerButton4_Click" />
                <asp:Label ID="AnswerLabel4" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
                <br />
            </div>
            <br />
            <div class="auto-style2">
            <asp:Label ID="QuestionLabel5" runat="server" Text="Вопрос 5" Width="803px" CssClass="auto-style1"></asp:Label>
                <br />
            <asp:Label ID="Question5Label1" runat="server" CssClass="auto-style10" Height="25px" Text="Label" Width="200px"></asp:Label>
                <asp:DropDownList ID="Question5DropDownList1" runat="server" CssClass="auto-style11">
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                </asp:DropDownList>
            <asp:Label ID="Question5Label5" runat="server" Height="25px" Text="Label" CssClass="auto-style12"></asp:Label>
                <br />
            <asp:Label ID="Question5Label2" runat="server" CssClass="auto-style10" Height="25px" Text="Label" Width="200px"></asp:Label>
                <asp:DropDownList ID="Question5DropDownList2" runat="server" CssClass="auto-style11">
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                </asp:DropDownList>
            <asp:Label ID="Question5Label6" runat="server" Height="25px" Text="Label" CssClass="auto-style12"></asp:Label>
                <br />
            <asp:Label ID="Question5Label3" runat="server" CssClass="auto-style10" Height="25px" Text="Label" Width="200px"></asp:Label>
                <asp:DropDownList ID="Question5DropDownList3" runat="server" CssClass="auto-style11">
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                </asp:DropDownList>
            <asp:Label ID="Question5Label7" runat="server" Height="25px" Text="Label" CssClass="auto-style12"></asp:Label>
                <br />
            <asp:Label ID="Question5Label4" runat="server" CssClass="auto-style10" Height="25px" Text="Label" Width="200px"></asp:Label>
                <asp:DropDownList ID="Question5DropDownList4" runat="server" CssClass="auto-style11">
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                </asp:DropDownList>
            <asp:Label ID="Question5Label8" runat="server" Height="25px" Text="Label" CssClass="auto-style12"></asp:Label>
                <br />
                <asp:Button ID="GetAnswerButton5" runat="server" Height="25px" Text="Ответить" CssClass="auto-style9" OnClick="GetAnswerButton5_Click" />
                <asp:Label ID="AnswerLabel5" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
