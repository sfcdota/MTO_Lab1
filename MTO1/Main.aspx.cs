using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTO1
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginInfo"];
            if (cookie == null)
                Response.Redirect("~/Default.aspx");
            else
            {
                Label1.Text = "Вы авторизовались под ID = " + cookie["Login"] + ". Запомните его!!!";
                Label1.ForeColor = System.Drawing.Color.Red;
                if (cookie["IsStudent"] == "0" && ViewState["FirstTime"] == null)
                {
                    MenuItem item = new MenuItem();
                    item.Value = "Редактирование";
                    item.NavigateUrl = "~/CheckYourselfEdit.aspx";
                    MainMenu0.Items[0].ChildItems[0].ChildItems.Add(item);
                    ViewState["FirstTime"] = 1;
                }
            }
        }

        protected void MainMenu0_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (e.Item == MainMenu0.Items[1])
            {
                HttpCookie cookie = Request.Cookies["LoginInfo"];
                cookie.Expires = DateTime.Now.AddDays(-30);
                Response.Cookies.Add(cookie);
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}