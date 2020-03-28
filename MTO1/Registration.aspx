<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MTO1.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
            width: 132px;
        }
        .auto-style2 {
            height: 30px;
            width: 178px;
        }
        .auto-style3 {
            width: 178px;
        }
        .auto-style4 {
            width: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:CreateUserWizard ID="CreateUserWizard" runat="server" OnCreatingUser="CreateUserWizard1_CreatingUser">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td align="center" colspan="2">Sign Up for Your New Account</td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style1">
                                    <asp:Label ID="NameLabel" runat="server" AssociatedControlID="UserName">Name:</asp:Label>
                                </td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style4">
                                    <asp:Label ID="SurnameLabel" runat="server" AssociatedControlID="UserName">Surname:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="SurnameTextBox" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired0" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style4">
                                    <asp:Label ID="PatronymicLabel" runat="server" AssociatedControlID="UserName">Patronymic:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="PatronymicTextBox" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired1" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style4">
                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                </td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style4">
                                    <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
                                </td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." ToolTip="Confirm Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" class="auto-style4">
                                    <asp:Label ID="TeacherLabel" runat="server" AssociatedControlID="ConfirmPassword">Teacher?</asp:Label>
                                </td>
                                <td class="auto-style3">
                                    <asp:CheckBox ID="TeacherCheckBox" runat="server" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2">
                                    <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The Password and Confirmation Password must match." ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" style="color:Red;">
                                    <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard>
    </form>
</body>
</html>
