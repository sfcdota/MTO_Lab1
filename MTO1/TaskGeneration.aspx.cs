using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTO1
{
    public partial class TaskGeneration : System.Web.UI.Page
    {
        Model model = new Model();
        Random random = new Random();
        int? nullint = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginInfo"];
            if (cookie == null)
                Response.Redirect("~/Default.aspx");
            else if (cookie["IsStudent"] == "0")
                Response.Redirect("~/TaskGenerationResults.aspx");
            else
            {
                if (Request.Cookies["StudentMark"] == null)
                {
                    HttpCookie studentMark = new HttpCookie("Mark");
                    studentMark["Login"] = cookie["Login"];
                    studentMark["EquationNumber"] = "1";
                    studentMark["EquationID"] = "";
                    studentMark.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(studentMark);
                }
                HttpCookie mark = Request.Cookies["StudentMark"];
                if (mark["EquationNumber"] == "1" || mark["EquationNumber"] == "2")
                {
                    if (mark["EquationID"] == "")
                    {
                        mark["EquationID"] = GenerateEquationID();
                        Response.Cookies["StudentMark"]["EquationID"] = mark["EquationID"];
                    }
                    int currentID = Convert.ToInt32(mark["EquationID"]);
                    Generation generation = model.Generation.Where(c => c.ID == currentID).FirstOrDefault();
                    EquationLabel.Text = generation.a.ToString() + "x * x " + generation.b.ToString() + "x " + generation.c.ToString() + " = 0";
                }
                else
                {
                    int currentid = Convert.ToInt32(mark["CurrentEquationID"]);
                    Generation generation = model.Generation.Where(c => c.ID == currentid).FirstOrDefault();
                    EquationLabel.Text = generation.a.ToString() + "x * x " + generation.b.ToString() + "x " + generation.c.ToString() + " = 0";
                    AnswerLabel.Text = "Ваша оценка " + model.Student.Where(d => d.Login == cookie["Login"]).FirstOrDefault().Mark + " баллов";
                    AnswerButton.Enabled = false;
                    AnswerLabel.Visible = true;
                }
            }
        }

        protected void GetAnswerButton1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginInfo"];
            HttpCookie mark = Request.Cookies["StudentMark"];
            int equationID = Convert.ToInt32(mark["EquationID"]);
            string login = cookie["Login"];
            if (mark["EquationNumber"] == "1")
            {
                model.Student.Where(c => c.Login == login).FirstOrDefault().Mark = Answer(equationID) == AnswerTextBox1.Text ? 50 : 0;
                AnswerLabel.Text = "Ответ отправлен. Ваша оценка за текущее задание = " + model.Student.Where(c => c.Login == login).FirstOrDefault().Mark +
                    "/50 баллов. Перейти к следующему заданию?";
                AnswerLabel.Visible = true;
                NextButton.Visible = true;
            }
            if (mark["EquationNumber"] == "2")
            {
                model.Student.Where(c => c.Login == login).FirstOrDefault().Mark = Answer(equationID) == AnswerTextBox1.Text ?
                    model.Student.Where(c => c.Login == login).FirstOrDefault().Mark + 50 :
                    model.Student.Where(c => c.Login == login).FirstOrDefault().Mark;
                model.Student.Where(c => c.Login == login).FirstOrDefault().Last_Test_Date = DateTime.Now.Date;
                AnswerLabel.Text = "Ваша оценка " + model.Student.Where(c => c.Login == login).FirstOrDefault().Mark + " баллов";
                AnswerLabel.Visible = true;
            }
           model.SaveChanges();
        }

        protected string Answer(int equationID)
        {
            int a = model.Generation.Where(e => e.ID == equationID).FirstOrDefault().a;
            int b = model.Generation.Where(e => e.ID == equationID).FirstOrDefault().b;
            int c = model.Generation.Where(e => e.ID == equationID).FirstOrDefault().c;
            double d;
            if (a != 0)
            {
                d = Math.Pow(b, 2) - 4 * a * c;
                if (d == 0)
                    return ((-b + Math.Sqrt(d)) / (2 * a)).ToString();
                else
                if (d > 0)
                    return ((-b + Math.Sqrt(d)) / (2 * a)).ToString() + " " + ((-b - Math.Sqrt(d)) / (2 * a)).ToString();
                else
                    return "0";
            }
            else
                if (b != 0)
                return (-c * 1.0 / b).ToString();
                else
                    return "0";
        }

        protected string GenerateEquationID()
        {
            int a = random.Next(-20, 20);
            int b = random.Next(-20, 20);
            int c = random.Next(-20, 20);

            while (model.Generation.Where(d => (d.a == a && d.b == b && d.c == c)).FirstOrDefault() != null)
            {
                a = random.Next(-20, 20);
                b = random.Next(-20, 20);
                c = random.Next(-20, 20);
            }
            Generation generation = new Generation
            {
                ID = 228,
                a = a,
                b = b,
                c = c
            };
            model.Generation.Add(generation);
            model.SaveChanges();
            return model.Generation.Where(d => (d.a == a && d.b == b && d.c == c)).FirstOrDefault().ID.ToString();
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

        protected void NextButton_Click(object sender, EventArgs e)
        {
            NextButton.Visible = false;
            AnswerLabel.Visible = false;
            HttpCookie mark = Request.Cookies["StudentMark"];
            Response.Cookies["StudentMark"]["EquationNumber"] = (Convert.ToInt32(Response.Cookies["StudentMark"]["EquationNumber"]) + 1).ToString();
            Response.Cookies["StudentMark"]["EquationID"] = "";
        }
    }
}