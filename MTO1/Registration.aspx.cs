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
            int studentid = 0;
            foreach (Student c in model.Student.ToList())
            {
                foreach (Student c1 in model.Student.ToList())
                    if (studentid == c1.ID)
                        studentid++;
            }
            model.Student.Add(new Student
            {
                ID = studentid,
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                Patronymic = PatronymicTextBox.Text,
                Password = PasswordTextBox.Text,
            });
            model.SaveChanges();
            HttpCookie cookie = new HttpCookie("LoginInfo");
            cookie["Login"] = studentid.ToString();
            cookie["Password"] = PasswordTextBox.Text;
            cookie["IsStudent"] = "1";
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Main.aspx");
        }
    }
}