<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MTO1.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 250px;
            margin-top: 310px;
            width: 337px;
            margin-left: 676px;
        }
                .auto-style2 {
            margin-left: 30px;
            text-align:center;
        }
        .auto-style4 {
            margin-left: 15px;
            margin-bottom: 0px;
        }
        .auto-style5 {
            margin-left: 25px;
            margin-top: 10px;
            margin-bottom: 0px;
        }
        .auto-style7 {
            margin-left: 30px;
            margin-right: 5px;
            text-align: right;
        }
        .auto-style8 {
            margin-left: 69px;
            margin-top: 0px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
        <div class="auto-style1" style="background-color : cornsilk">
            <asp:Label ID="RegistrationLabel" runat="server" CssClass="auto-style2" Text="Регистрация нового пользователя" Height="25px" Width="274px"></asp:Label>
            <br />
            <asp:Label ID="LoginLabel" runat="server" CssClass="auto-style7" Height="25px" Text="Логин" Width="110px"></asp:Label>
            <asp:TextBox ID="LoginTextBox" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredNameValidator0" runat="server" ControlToValidate="LoginTextBox" ErrorMessage="Поле не может быть пустым." ToolTip="Поле не может быть пустым.">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="NameLabel" runat="server" CssClass="auto-style7" Height="25px" Text="Имя" Width="110px"></asp:Label>
            <asp:TextBox ID="NameTextBox" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredNameValidator" runat="server" ControlToValidate="NameTextBox" ErrorMessage="Поле не может быть пустым." ToolTip="Поле не может быть пустым.">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="SurnameLabel" runat="server" CssClass="auto-style7" Height="25px" Text="Фамилия" Width="110px"></asp:Label>
            <asp:TextBox ID="SurnameTextBox" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredSurnameValidator" runat="server" ControlToValidate="SurnameTextBox" ErrorMessage="Поле не может быть пустым." ToolTip="Поле не может быть пустым.">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="PatronymicLabel" runat="server" CssClass="auto-style7" Height="25px" Text="Отчество" Width="110px"></asp:Label>
            <asp:TextBox ID="PatronymicTextBox" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredPatronymicValidator" runat="server" ControlToValidate="PatronymicTextBox" ErrorMessage="Поле не может быть пустым." ToolTip="Поле не может быть пустым.">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="PatronymicLabel0" runat="server" CssClass="auto-style7" Height="25px" Text="Пароль" Width="110px"></asp:Label>
            <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredPasswordValidator" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="Поле не может быть пустым." ToolTip="Поле не может быть пустым.">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="PatronymicLabel1" runat="server" CssClass="auto-style7" Height="25px" Text="Повтор пароля" Width="110px"></asp:Label>
            <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" TextMode="Password" AutoCompleteType="Disabled"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredConfirmPasswordValidator" runat="server" ControlToValidate="ConfirmPasswordTextBox" ErrorMessage="Поле не может быть пустым." ToolTip="Поле не может быть пустым.">*</asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="RegistrationButton" runat="server" BackColor="#D9ECFF" CssClass="auto-style5" Height="25px" Text="Регистрация" OnClick="RegistrationButton_Click" />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="ConfirmPasswordTextBox" ControlToValidate="PasswordTextBox" CssClass="auto-style4" ErrorMessage="Пароли не совпадают" ForeColor="#FF3300" Height="20px"></asp:CompareValidator>
            <br />
            <asp:Label ID="ErrorLabel" runat="server" CssClass="auto-style8" ForeColor="Red" Text="Label" Visible="False" Width="200px"></asp:Label>
            <br />
        </div>
        </div>
    </form>
</body>
</html>
