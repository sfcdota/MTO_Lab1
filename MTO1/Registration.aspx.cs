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

        protected void CreateUserWizard1_CreatingUser(object sender, LoginCancelEventArgs e)
        {
        }
    }
}