using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTO1
{
    public partial class Registration : System.Web.UI.Page
    {
        Model model = new Model();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginInfo"];
            if (cookie != null)
                Response.Redirect("~/Main.aspx");
        }


        protected void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (model.Student.Where(c => c.Login == LoginTextBox.Text).FirstOrDefault() != null
                || model.Teacher.Where(c => c.Login == LoginTextBox.Text).FirstOrDefault() != null)
            {
                ErrorLabel.Text = "Логин уже занят. Попробуйте другой.";
                ErrorLabel.Visible = true;
            }
            else
            {
                model.Student.Add(new Student
                {
                    Login = LoginTextBox.Text,
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    Patromymic = PatronymicTextBox.Text,
                    Password = PasswordTextBox.Text,
                    Finished = false,
                }) ;
                model.SaveChanges();
                HttpCookie cookie = new HttpCookie("LoginInfo");
                cookie["Login"] = LoginTextBox.Text;
                cookie["Password"] = PasswordTextBox.Text;
                cookie["IsStudent"] = "1";
                Response.Cookies.Add(cookie);
                Response.Redirect("~/Main.aspx");
            }
        }
    }
}