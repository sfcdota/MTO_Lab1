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
                string login = cookie["Login"];
                if (model.Student.Where(c => (c.Mark == nullint && c.Login == login)).FirstOrDefault() != null)
                {
                    model.GenerationTask.Add(new GenerationTask
                    {
                        StudentLogin = cookie["Login"],
                        GenerationID1 = GenerateEquationID(),
                        GenerationID2 = GenerateEquationID(),
                        Finished = false
                    });
                    model.SaveChanges();
                    int id = model.GenerationTask.Where(d => d.StudentLogin == login).FirstOrDefault().GenerationID1;
                    Generation generation = model.Generation.Where(f => f.ID == id).FirstOrDefault();
                    EquationLabel.Text = generation.a.ToString() + " * x * x " + (generation.b >= 0 ? "+ " + generation.b + "x " : generation.b + "x ")
                        + (generation.c >= 0 ? "+ " + generation.c : generation.c + " ");
                }
                else
                {
                    int id = model.GenerationTask.Where(d => d.StudentLogin == login).FirstOrDefault().GenerationID2;

                    Generation generation = model.Generation.Where(f => f.ID == id).FirstOrDefault();
                    EquationLabel.Text = generation.a.ToString() + " * x * x " + (generation.b >= 0 ? "+ " + generation.b + "x " : generation.b + "x ")
                        + (generation.c >= 0 ? "+ " + generation.c : generation.c + " ");
                    if (model.GenerationTask.Where(c => c.StudentLogin == login).FirstOrDefault().Finished)
                    {
                        AnswerButton.Enabled = false;
                        AnswerTextBox1.Enabled = false;
                    }
                }
            }
        }

        protected void GetAnswerButton1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginInfo"];
            string login = cookie["Login"];

            if (model.Student.Where(c => (c.Mark == nullint && c.Login == login)).FirstOrDefault() != null)
            {
                int id = model.GenerationTask.Where(d => d.StudentLogin == login).FirstOrDefault().GenerationID1;
                Generation generation = model.Generation.Where(f => f.ID == id).FirstOrDefault();
                model.Student.Where(c => c.Login == login).FirstOrDefault().Mark = Answer(generation.ID) == AnswerTextBox1.Text ? 50 : 0;
                model.Student.Where(c => c.Login == login).FirstOrDefault().Last_Test_Date = DateTime.Now.ToUniversalTime();
                AnswerLabel.Text = "Ваш балл за текущее задание = " + model.Student.Where(c => c.Login == login).FirstOrDefault().Mark
                    + "/50. Перейдите к следующему заданию.";
                AnswerLabel.Visible = true;
                NextButton.Visible = true;
                model.SaveChanges();
            }
            else
            {
                int id = model.GenerationTask.Where(d => d.StudentLogin == login).FirstOrDefault().GenerationID2;

                Generation generation = model.Generation.Where(f => f.ID == id).FirstOrDefault();
                model.Student.Where(c => c.Login == login).FirstOrDefault().Mark = Answer(generation.ID) == AnswerTextBox1.Text ?
                    model.Student.Where(c => c.Login == login).FirstOrDefault().Mark + 50 :
                    model.Student.Where(c => c.Login == login).FirstOrDefault().Mark;
                model.Student.Where(c => c.Login == login).FirstOrDefault().Last_Test_Date = DateTime.Now.ToUniversalTime();
                model.SaveChanges();
                GenerationTask generationTask = model.GenerationTask.Where(c => c.StudentLogin == login).FirstOrDefault();
                generationTask.Finished = true;
                AnswerLabel.Text = "Ваш балл за тест равен " + model.Student.Where(c => c.Login == login).FirstOrDefault().Mark + "/100.";
                AnswerLabel.Visible = true;
                AnswerButton.Enabled = false;
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
                    return Math.Round((-b + Math.Sqrt(d)) / (2 * a), 2).ToString();
                else
                if (d > 0)
                    return Math.Round((-b + Math.Sqrt(d)) / (2 * a)).ToString() + " " + Math.Round((-b - Math.Sqrt(d)) / (2 * a), 2).ToString();
                else
                    return "0";
            }
            else
                if (b != 0)
                return Math.Round((- c * 1.0 / b), 2).ToString();
                else
                    return "0";
        }

        protected int GenerateEquationID()
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

            int id = 0;
            foreach (Generation c1 in model.Generation.ToList())
            {
                foreach (Generation c2 in model.Generation.ToList())
                    if (id == c2.ID)
                        id++;
            }
            Generation generation = new Generation
            {
                ID = id,
                a = a,
                b = b,
                c = c
            };
            model.Generation.Add(generation);
            model.SaveChanges();
            return model.Generation.Where(d => (d.a == a && d.b == b && d.c == c)).FirstOrDefault().ID;
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
            AnswerTextBox1.Text = "";
        }
    }
}