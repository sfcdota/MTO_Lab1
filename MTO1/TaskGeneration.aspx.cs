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
                int studentid = Convert.ToInt32(cookie["Login"]);
                Generation generation = model.Generation.Where(c => c.StudentID == studentid).FirstOrDefault();
                if (generation == null)
                {
                    int a11 = random.Next(-15, 15);
                    int a12 = random.Next(-15, 15);
                    int a21 = random.Next(-15, 15);
                    int a22 = random.Next(-15, 15);

                    while (model.Generation.Where(a => (a.a11 == a11 && a.a12 == a12 && a.a21 == a21 && a.a22 == a22)).FirstOrDefault() != null)
                    {
                        a11 = random.Next(-15, 15);
                        a12 = random.Next(-15, 15);
                        a21 = random.Next(-15, 15);
                        a22 = random.Next(-15, 15);
                    }
                    A11Label.Text = a11.ToString();
                    A12Label.Text = a12.ToString();
                    A21Label.Text = a21.ToString();
                    A22Label.Text = a22.ToString();
                    int id = 0;
                    foreach (Generation c in model.Generation.ToList())
                    {
                        foreach (Generation c1 in model.Generation.ToList())
                            if (id == c1.ID)
                                id++;
                    }
                    generation = new Generation
                    {
                        ID = id,
                        a11 = a11,
                        a12 = a12,
                        a21 = a21,
                        a22 = a22,
                        Answer = nullint,
                        StudentID = studentid
                    };
                    model.Generation.Add(generation);
                    model.SaveChanges();
                }
                else
                {
                    A11Label.Text = generation.a11.ToString();
                    A12Label.Text = generation.a12.ToString();
                    A21Label.Text = generation.a21.ToString();
                    A22Label.Text = generation.a22.ToString();
                    AnswerLabel.Text = "Ответ отправлен. Ваша оценка " + model.Student.Where(c => c.ID == studentid).FirstOrDefault().Mark + " баллов";
                    AnswerButton.Enabled = false;
                    AnswerLabel.Visible = true;
                }
            }
        }

        protected void GetAnswerButton1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginInfo"];
            int studentid = Convert.ToInt32(cookie["Login"]);
            Generation generation = model.Generation.Where(c => c.StudentID == studentid).FirstOrDefault();
            if (generation.Answer == null || generation.Answer == nullint)
            {
                if (Convert.ToInt32(AnswerTextBox1.Text) == generation.a11 * generation.a22 - generation.a12 * generation.a21)
                    model.Student.Where(c => c.ID == studentid).FirstOrDefault().Mark = 100;
                else
                    model.Student.Where(c => c.ID == studentid).FirstOrDefault().Mark = 0;
                model.Student.Where(c => c.ID == studentid).FirstOrDefault().Last_Test_Date = DateTime.Now.Date;
                model.SaveChanges();
                AnswerLabel.Text = "Ответ отправлен. Ваша оценка " + model.Student.Where(c => c.ID == studentid).FirstOrDefault().Mark + " баллов";
                AnswerLabel.Visible = true;
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