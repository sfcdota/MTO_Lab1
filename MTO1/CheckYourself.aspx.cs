using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Data.Entity.SqlServer;

namespace MTO1
{
    public partial class CheckYourself : System.Web.UI.Page
    {
        Model model = new Model();
        int[] questionid = new int[5];

        protected void GetAnswerButton1_Click(object sender, EventArgs e)
        {
            if (AnswerTextBox1.Text == string.Empty)
            {
                AnswerLabel1.Text = "Вы ввели пустой ответ";
                AnswerLabel1.ForeColor = System.Drawing.Color.Red;
                AnswerLabel1.Visible = true;
            }
            else
            {
                int currentid = questionid[0];
                if (AnswerTextBox1.Text.ToLower() == model.TextQuestion.Where(c => c.ID == currentid).FirstOrDefault().Answer.ToLower())
                {
                    AnswerLabel1.Text = "Ответ верный";
                    AnswerLabel1.ForeColor = System.Drawing.Color.Green;
                    AnswerLabel1.Visible = true;
                }
                else
                {
                    AnswerLabel1.Text = "Ответ неверный";
                    AnswerLabel1.ForeColor = System.Drawing.Color.Red;
                    AnswerLabel1.Visible = true;
                }
            }
        }

        protected void GetAnswerButton2_Click(object sender, EventArgs e)
        {
            if (AnswerTextBox2.Text == string.Empty)
            {
                AnswerLabel2.Text = "Вы ввели пустой ответ";
                AnswerLabel2.ForeColor = System.Drawing.Color.Red;
                AnswerLabel2.Visible = true;
            }
            else
            {
                int currentid = questionid[1];
                if (AnswerTextBox2.Text.ToLower() == model.NumberQuestion.Where(c => c.ID == currentid).FirstOrDefault().Answer.ToString())
                {
                    AnswerLabel2.Text = "Ответ верный";
                    AnswerLabel2.ForeColor = System.Drawing.Color.Green;
                    AnswerLabel2.Visible = true;
                }
                else
                {
                    AnswerLabel2.Text = "Ответ неверный";
                    AnswerLabel2.ForeColor = System.Drawing.Color.Red;
                    AnswerLabel2.Visible = true;
                }
            }
        }

        protected void GetAnswerButton3_Click(object sender, EventArgs e)
        {
            if (Question3RadioButtonList.Items[0].Selected == false && Question3RadioButtonList.Items[1].Selected == false
    && Question3RadioButtonList.Items[2].Selected == false && Question3RadioButtonList.Items[3].Selected == false)
            {
                AnswerLabel3.Text = "Вы ввели пустой ответ";
                AnswerLabel3.ForeColor = System.Drawing.Color.Red;
                AnswerLabel3.Visible = true;
            }
            else
            {
                int currentid = questionid[2];
                if (Question3RadioButtonList.Items[model.ChoiceQuestion.Where(c => c.ID == currentid).FirstOrDefault().CorrectAnswer - 1].Selected)
                {
                    AnswerLabel3.Text = "Ответ верный";
                    AnswerLabel3.ForeColor = System.Drawing.Color.Green;
                    AnswerLabel3.Visible = true;
                }
                else
                {
                    AnswerLabel3.Text = "Ответ неверный";
                    AnswerLabel3.ForeColor = System.Drawing.Color.Red;
                    AnswerLabel3.Visible = true;
                }
            }
        }

        protected void GetAnswerButton4_Click(object sender, EventArgs e)
        {
            if (Question4CheckBox1.Checked == false && Question4CheckBox2.Checked == false
    && Question4CheckBox3.Checked == false && Question4CheckBox4.Checked == false)
            {
                AnswerLabel4.Text = "Вы ввели пустой ответ";
                AnswerLabel4.ForeColor = System.Drawing.Color.Red;
                AnswerLabel4.Visible = true;
            }
            else
            {
                int currentid = questionid[3];
                if (Question4CheckBox1.Checked == model.MultipleChoiceQuestion.Where(c => c.ID == currentid).FirstOrDefault().CorrectAnswer1
                    && Question4CheckBox2.Checked == model.MultipleChoiceQuestion.Where(c => c.ID == currentid).FirstOrDefault().CorrectAnswer2
                    && Question4CheckBox3.Checked == model.MultipleChoiceQuestion.Where(c => c.ID == currentid).FirstOrDefault().CorrectAnswer3
                    && Question4CheckBox4.Checked == model.MultipleChoiceQuestion.Where(c => c.ID == currentid).FirstOrDefault().CorrectAnswer4)
                {
                    AnswerLabel4.Text = "Ответ верный";
                    AnswerLabel4.ForeColor = System.Drawing.Color.Green;
                    AnswerLabel4.Visible = true;
                }
                else
                {
                    AnswerLabel4.Text = "Ответ неверный";
                    AnswerLabel4.ForeColor = System.Drawing.Color.Red;
                    AnswerLabel4.Visible = true;
                }
            }
        }

        protected void GetAnswerButton5_Click(object sender, EventArgs e)
        {
            int currentid = questionid[4];
            if (Convert.ToInt32(Question5DropDownList1.SelectedValue) == model.ComplianceQuestion.Where(c => c.ID == currentid).FirstOrDefault().CorrectAnswer1
                && Convert.ToInt32(Question5DropDownList2.SelectedValue) == model.ComplianceQuestion.Where(c => c.ID == currentid).FirstOrDefault().CorrectAnswer2
                && Convert.ToInt32(Question5DropDownList3.SelectedValue) == model.ComplianceQuestion.Where(c => c.ID == currentid).FirstOrDefault().CorrectAnswer3
                && Convert.ToInt32(Question5DropDownList4.SelectedValue) == model.ComplianceQuestion.Where(c => c.ID == currentid).FirstOrDefault().CorrectAnswer4)
            {
                AnswerLabel5.Text = "Ответ верный";
                AnswerLabel5.ForeColor = System.Drawing.Color.Green;
                AnswerLabel5.Visible = true;
            }
            else
            {
                AnswerLabel5.Text = "Ответ неверный";
                AnswerLabel5.ForeColor = System.Drawing.Color.Red;
                AnswerLabel5.Visible = true;
            }
        }

        protected void CheckYourselfLabel_Init(object sender, EventArgs e)
        {
        }

        protected void LoadTask()
        {

            int index = questionid[0];
            QuestionLabel1.Text = "Вопрос 1: " + model.TextQuestion.Where(c => c.ID == index).First().Question;
            index = questionid[1];
            QuestionLabel2.Text = "Вопрос 2: " + model.NumberQuestion.Where(c => c.ID == index).First().Question;

            index = questionid[2];
            QuestionLabel3.Text = "Вопрос 3: " + model.ChoiceQuestion.Where(c => c.ID == index).First().Question;
            Question3RadioButtonList.Items[0].Text = model.ChoiceQuestion.Where(c => c.ID == index).First().Answer1;
            Question3RadioButtonList.Items[1].Text = model.ChoiceQuestion.Where(c => c.ID == index).First().Answer2;
            Question3RadioButtonList.Items[2].Text = model.ChoiceQuestion.Where(c => c.ID == index).First().Answer3;
            Question3RadioButtonList.Items[3].Text = model.ChoiceQuestion.Where(c => c.ID == index).First().Answer4;

            index = questionid[3];
            QuestionLabel4.Text = "Вопрос 4: " + model.MultipleChoiceQuestion.Where(c => c.ID == index).First().Question;
            Question4CheckBox1.Text = model.MultipleChoiceQuestion.Where(c => c.ID == index).First().Answer1;
            Question4CheckBox2.Text = model.MultipleChoiceQuestion.Where(c => c.ID == index).First().Answer2;
            Question4CheckBox3.Text = model.MultipleChoiceQuestion.Where(c => c.ID == index).First().Answer3;
            Question4CheckBox4.Text = model.MultipleChoiceQuestion.Where(c => c.ID == index).First().Answer4;

            index = questionid[4];
            QuestionLabel5.Text = "Вопрос 5: " + model.ComplianceQuestion.Where(c => c.ID == index).First().Description;
            Question5Label1.Text = model.ComplianceQuestion.Where(c => c.ID == index).First().Question1;
            Question5Label2.Text = model.ComplianceQuestion.Where(c => c.ID == index).First().Question2;
            Question5Label3.Text = model.ComplianceQuestion.Where(c => c.ID == index).First().Question3;
            Question5Label4.Text = model.ComplianceQuestion.Where(c => c.ID == index).First().Question4;

            Question5Label5.Text = "1. " + model.ComplianceQuestion.Where(c => c.ID == index).First().Answer1;
            Question5Label6.Text = "2. " + model.ComplianceQuestion.Where(c => c.ID == index).First().Answer2;
            Question5Label7.Text = "3. " + model.ComplianceQuestion.Where(c => c.ID == index).First().Answer3;
            Question5Label8.Text = "4. " + model.ComplianceQuestion.Where(c => c.ID == index).First().Answer4;

            int maxlength = 0;
            if (Question5Label1.Text.Length > maxlength)
                maxlength = Question5Label1.Text.Length;
            Question5Label2.Text = model.ComplianceQuestion.Where(c => c.ID == index).First().Question2;
            if (Question5Label2.Text.Length > maxlength)
                maxlength = Question5Label2.Text.Length;
            Question5Label3.Text = model.ComplianceQuestion.Where(c => c.ID == index).First().Question3;
            if (Question5Label3.Text.Length > maxlength)
                maxlength = Question5Label3.Text.Length;
            Question5Label4.Text = model.ComplianceQuestion.Where(c => c.ID == index).First().Question4;
            if (Question5Label4.Text.Length > maxlength)
                maxlength = Question5Label4.Text.Length;
            Question5Label1.Width = Convert.ToInt32(7 * 1.33 * maxlength);
            Question5Label2.Width = Convert.ToInt32(7 * 1.33 * maxlength);
            Question5Label3.Width = Convert.ToInt32(7 * 1.33 * maxlength);
            Question5Label4.Width = Convert.ToInt32(7 * 1.33 * maxlength);
        }

        protected void Randomize()
        {
            Random rand = new Random();
            questionid[0] = model.TextQuestion.ToList()[rand.Next(model.TextQuestion.ToList().Count)].ID;
            questionid[1] = model.NumberQuestion.ToList()[rand.Next(model.NumberQuestion.ToList().Count)].ID;
            questionid[2] = model.ChoiceQuestion.ToList()[rand.Next(model.ChoiceQuestion.ToList().Count)].ID;
            questionid[3] = model.MultipleChoiceQuestion.ToList()[rand.Next(model.MultipleChoiceQuestion.ToList().Count)].ID;
            questionid[4] = model.ComplianceQuestion.ToList()[rand.Next(model.ComplianceQuestion.ToList().Count)].ID;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
            HttpCookie cookie = Request.Cookies["LoginInfo"];
            if (cookie == null)
                Response.Redirect("~/Default.aspx");
            else
            {
                if (cookie["IsStudent"] == "0" && ViewState["FirstTime"] == null)
                {
                    MenuItem item = new MenuItem();
                    item.Value = "Редактирование";
                    item.NavigateUrl = "~/CheckYourselfEdit.aspx";
                    MainMenu0.Items[0].ChildItems[0].ChildItems.Add(item);
                }
                if (ViewState["FirstTime"] == null)
                {
                    Randomize();
                    LoadTask();
                    ViewState["ID0"] = questionid[0].ToString();
                    ViewState["ID1"] = questionid[1].ToString();
                    ViewState["ID2"] = questionid[2].ToString();
                    ViewState["ID3"] = questionid[3].ToString();
                    ViewState["ID4"] = questionid[4].ToString();
                    ViewState["FirstTime"] = 1;
                }
                else
                {
                    questionid[0] = Convert.ToInt32(ViewState["ID0"]);
                    questionid[1] = Convert.ToInt32(ViewState["ID1"]);
                    questionid[2] = Convert.ToInt32(ViewState["ID2"]);
                    questionid[3] = Convert.ToInt32(ViewState["ID3"]);
                    questionid[4] = Convert.ToInt32(ViewState["ID4"]);
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