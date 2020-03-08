using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTO1
{
    public partial class Default : System.Web.UI.Page
    {
        Model model = new Model();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginInfo"];
            if (cookie != null)
                Response.Redirect("~/Main.aspx");
        }

        protected void LoginForm_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (model.Student.Where(c => c.ID == Convert.ToInt32(LoginForm.UserName))
                .Where(c => c.Password == LoginForm.Password).FirstOrDefault() != null
                || 
                model.Teacher.Where(c => c.ID == Convert.ToInt32(LoginForm.UserName))
                .Where(c => c.Password == LoginForm.Password).FirstOrDefault() != null)
            {
                HttpCookie cookie = new HttpCookie("LoginInfo");
                cookie["Login"] = LoginForm.UserName;
                cookie["Password"] = LoginForm.Password;
                cookie["IsStudent"] = model.Student.Where(c => c.ID == Convert.ToInt32(LoginForm.UserName))
                    .FirstOrDefault() != null ? "1" : "0";
                cookie.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(cookie);
                Response.Redirect("~/Main.aspx");
            }
        }
    }
}