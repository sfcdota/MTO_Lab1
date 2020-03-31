<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckYourselfEdit.aspx.cs" Inherits="MTO1.CheckYourselfEdit" %>

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
            height: 748px;
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
        .auto-style14 {
            margin-left: 193px;
            resize : none;
        }
        .auto-style12 {
            position: absolute;
            padding-left: 180px;
            resize : none;
            margin-top: 9px;
        }
        .auto-style10 {
            margin-left: 200px;

            resize : none;
        }
        .auto-style15 {
            margin-left: 200px;
            margin-right: 0px;
            padding-top: 5px;
            padding-bottom: 5px;
            resize : none;
        }
        .auto-style17 {
            margin-left: 0px;
            resize : none;
        }
        .auto-style18 {
            margin-left: 207px;
            resize : none;
        }
        .auto-style19 {
            position:absolute;
            margin-left: 0px;
            resize : none;
            margin-right: 0px;
            left: 231px;
            top: 172px;
            width: 149px;
            height: 21px;
        }
        .auto-style21 {
            position: absolute;
            margin-left: 0px;
            resize : none;
            margin-right: 0px;
            left: 231px;
            top: 202px;
            width: 149px;
            height: 21px;
        }
        .auto-style23 {
            position:absolute;
            margin-left: 200px;
            resize : none;
            top: 224px;
            margin-top: 0px;
            margin-bottom: 0px;
            padding-bottom: 5px;
            left: -1px;
        }
        .auto-style24 {
            margin-left: 0px;
            resize : none;
            margin-top: 0px;
        }
        .auto-style25 {
            margin-left: 228px;
            resize : none;
        }
        .auto-style26 {
            position: absolute;
            margin-left: 200px;
            resize : none;
            top: 180px;
            margin-top: 0px;
            margin-bottom: 0px;
            padding-bottom: 5px;
            left: -1px;
        }
        .auto-style27 {
            margin-left: 14px;
            margin-top: 31px;
            margin-bottom: 0px;
        }
        .auto-style28 {
            margin-left: 421px;
        }
        .auto-style29 {
            position: absolute;
            margin-left: 0px;
            resize : none;
            margin-right: 0px;
            left: 612px;
            top: 175px;
            width: 149px;
            height: 21px;
        }
        .auto-style30 {
            position: absolute;
            margin-left: 0px;
            resize : none;
            margin-right: 0px;
            left: 612px;
            top: 206px;
            width: 149px;
            height: 21px;
        }
    </style>
</head>
<body style="margin-left: 273px">
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
                <asp:Label ID="CheckYourselfLabel" runat="server" CssClass="auto-style8" Height="25px" Text="Проверь себя" Font-Size="Larger" OnInit="CheckYourselfLabel_Init"></asp:Label>
            </div>
        <div class="auto-style5">
            <div class="auto-style2">
                <asp:Label ID="Label6" runat="server" CssClass="auto-style28" Height="25px" Text="Выберите вопрос:"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CssClass="auto-style27" Height="50px" Width="171px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="Новый"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
            <asp:Label ID="QuestionLabel1" runat="server" Text="Вопрос 1" Width="64px" CssClass="auto-style15"></asp:Label>
                <asp:TextBox ID="Question1DescriptionTextBox" runat="server" CssClass="auto-style15" Width="697px" AutoCompleteType="Disabled" EnableTheming="True" TextMode="MultiLine"></asp:TextBox>
                <br />
            <asp:Label ID="Question1EnterLabel" runat="server" CssClass="auto-style4" Height="30px" Text="Введите ответ в текстовое поле:" Width="228px"></asp:Label>
                <asp:TextBox ID="Question1AnswerTextBox" runat="server" Height="25px" Width="368px" AutoCompleteType="Disabled" TextMode="MultiLine" CssClass="auto-style24"></asp:TextBox>
                <br />
                <asp:Button ID="EditAnswerButton1" runat="server" Height="25px" Text="Изменить/Добавить" CssClass="auto-style9" OnClick="GetAnswerButton1_Click" />
                <asp:Label ID="EditResponseLabel1" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
            </div>
            <br />
            <div class="auto-style2">
                <asp:Label ID="Label7" runat="server" CssClass="auto-style28" Height="25px" Text="Выберите вопрос:"></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" CssClass="auto-style27" Height="50px" Width="171px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem Value="Новый"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
            <asp:Label ID="QuestionLabel2" runat="server" Text="Вопрос 2" Width="64px" CssClass="auto-style15"></asp:Label>
                <asp:TextBox ID="Question2DescriptionTextBox" runat="server" CssClass="auto-style15" Width="697px" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
            <asp:Label ID="Question2EnterLabel" runat="server" CssClass="auto-style4" Height="30px" Text="Введите число в текстовое поле:" Width="228px"></asp:Label>
                <asp:TextBox ID="Question2AnswerTextBox" runat="server" Height="25px" Width="364px" AutoCompleteType="Disabled" TextMode="Number" CssClass="auto-style17"></asp:TextBox>
                <br />
                <asp:Button ID="EditGetAnswerButton2" runat="server" Height="25px" Text="Изменить/Добавить" CssClass="auto-style9" OnClick="GetAnswerButton2_Click" />
                <asp:Label ID="EditResponseLabel2" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
            </div>
            <br />
            <div class="auto-style2">
                <asp:Label ID="Label8" runat="server" CssClass="auto-style28" Height="25px" Text="Выберите вопрос:"></asp:Label>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" CssClass="auto-style27" Height="50px" Width="171px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                    <asp:ListItem Value="Новый"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
            <asp:Label ID="QuestionLabel3" runat="server" Text="Вопрос 3" Width="64px" CssClass="auto-style15"></asp:Label>
                <asp:TextBox ID="Question3DescriptionTextBox" runat="server" CssClass="auto-style15" Width="697px" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:RadioButtonList ID="Question3RadioButtonList" runat="server" CssClass="auto-style14" Width="752px" CellPadding="5" RepeatColumns="2" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value=" "> </asp:ListItem>
                    <asp:ListItem Value="  "> </asp:ListItem>
                    <asp:ListItem Value="   "> </asp:ListItem>
                    <asp:ListItem Value="    "> </asp:ListItem>
                </asp:RadioButtonList>
                <asp:TextBox ID="Question3AnswerTextBox3" runat="server" CssClass="auto-style21" AutoCompleteType="Disabled" TextMode="MultiLine" Height="20px"></asp:TextBox>
                <asp:TextBox ID="Question3AnswerTextBox2" runat="server" CssClass="auto-style29" AutoCompleteType="Disabled" TextMode="MultiLine" Height="20px"></asp:TextBox>
                <asp:TextBox ID="Question3AnswerTextBox4" runat="server" CssClass="auto-style30" AutoCompleteType="Disabled" TextMode="MultiLine" Height="20px"></asp:TextBox>
                <asp:TextBox ID="Question3AnswerTextBox1" runat="server" CssClass="auto-style19" AutoCompleteType="Disabled" TextMode="MultiLine" Height="20px"></asp:TextBox>
                <asp:Button ID="EditAnswerButton3" runat="server" Height="25px" Text="Изменить/Добавить" CssClass="auto-style9" OnClick="GetAnswerButton3_Click" />
                <asp:Label ID="EditResponseLabel3" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
            </div>
            <br />
            <div class="auto-style2">
                <asp:Label ID="Label9" runat="server" CssClass="auto-style28" Height="25px" Text="Выберите вопрос:"></asp:Label>
                <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" CssClass="auto-style27" Height="50px" Width="171px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged">
                    <asp:ListItem Value="Новый"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
            <asp:Label ID="QuestionLabel4" runat="server" Text="Вопрос 4" Width="64px" CssClass="auto-style15"></asp:Label>
                <asp:TextBox ID="Question4DescriptionTextBox" runat="server" CssClass="auto-style15" Width="697px" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
            <asp:CheckBox ID="Question4CheckBox1" runat="server" CssClass="auto-style23" Height="30px" Width="23px" />
                <asp:TextBox ID="Question4AnswerTextBox1" runat="server" CssClass="auto-style25" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
            <asp:CheckBox ID="Question4CheckBox2" runat="server" Height="25px" CssClass="auto-style12" Width="20px" />
                <asp:TextBox ID="Question4AnswerTextBox2" runat="server" CssClass="auto-style18" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
            <asp:CheckBox ID="Question4CheckBox3" runat="server" CssClass="auto-style26" Height="30px" Width="23px" />
                <asp:TextBox ID="Question4AnswerTextBox3" runat="server" CssClass="auto-style25" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
            <asp:CheckBox ID="Question4CheckBox4" runat="server" Height="25px" CssClass="auto-style12" Width="20px" />
                <asp:TextBox ID="Question4AnswerTextBox4" runat="server" CssClass="auto-style18" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:Button ID="EditAnswerButton4" runat="server" Height="25px" Text="Изменить/Добавить" CssClass="auto-style9" OnClick="GetAnswerButton4_Click" />
                <asp:Label ID="EditResponseLabel4" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
                <br />
            </div>
            <br />
            <div class="auto-style2">
                <asp:Label ID="Label10" runat="server" CssClass="auto-style28" Height="25px" Text="Выберите вопрос:"></asp:Label>
                <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" CssClass="auto-style27" Height="50px" Width="171px" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
                    <asp:ListItem Value="Новый"></asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
            <asp:Label ID="QuestionLabel5" runat="server" Text="Вопрос 5" Width="64px" CssClass="auto-style15"></asp:Label>
                <asp:TextBox ID="Question5DescriptionTextBox" runat="server" CssClass="auto-style15" Width="697px" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:TextBox ID="Question5TextBox1" runat="server" CssClass="auto-style10" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <asp:DropDownList ID="Question5DropDownList1" runat="server" CssClass="auto-style11" style="margin-right: 160px; margin-bottom: 6px;" Height="25px">
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label2" runat="server" Height="25px" Text="1."></asp:Label>
                <asp:TextBox ID="Question5AnswerTextBox1" runat="server" CssClass="auto-style17" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="Question5TextBox2" runat="server" CssClass="auto-style10" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <asp:DropDownList ID="Question5DropDownList2" runat="server" CssClass="auto-style11" style="margin-bottom: 6px; margin-right: 160px; margin-top: 0px;" Height="25px">
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label3" runat="server" Height="25px" Text="2."></asp:Label>
                <asp:TextBox ID="Question5AnswerTextBox2" runat="server" CssClass="auto-style17" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="Question5TextBox3" runat="server" CssClass="auto-style10" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <asp:DropDownList ID="Question5DropDownList3" runat="server" CssClass="auto-style11" style="margin-bottom: 4px; margin-right: 160px;" Height="25px">
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label4" runat="server" Height="25px" Text="3."></asp:Label>
                <asp:TextBox ID="Question5AnswerTextBox3" runat="server" CssClass="auto-style17" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="Question5TextBox4" runat="server" CssClass="auto-style10" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <asp:DropDownList ID="Question5DropDownList4" runat="server" CssClass="auto-style11" style="margin-bottom: 7px; margin-right: 160px;" Height="25px">
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                    <asp:ListItem Value="4"></asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="Label5" runat="server" Height="25px" Text="4."></asp:Label>
                <asp:TextBox ID="Question5AnswerTextBox4" runat="server" CssClass="auto-style17" AutoCompleteType="Disabled" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="EditGetAnswerButton5" runat="server" Height="25px" Text="Изменить/Добавить" CssClass="auto-style9" OnClick="GetAnswerButton5_Click" />
                <asp:Label ID="EditResponseLabel5" runat="server" Height="25px" Text="Label" Visible="False"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
