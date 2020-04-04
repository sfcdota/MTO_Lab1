using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MTO1
{
	public partial class CheckYourselfEdit : System.Web.UI.Page
	{
		static Model model = new Model();

		List<TextQuestion> task1 = model.TextQuestion.ToList();
		List<NumberQuestion> task2 = model.NumberQuestion.ToList();
		List<ChoiceQuestion> task3 = model.ChoiceQuestion.ToList();
		List<MultipleChoiceQuestion> task4 = model.MultipleChoiceQuestion.ToList();
		List<ComplianceQuestion> task5 = model.ComplianceQuestion.ToList();
		int currentID;
		protected void Page_Load(object sender, EventArgs e)
		{
			Page.MaintainScrollPositionOnPostBack = true;
			HttpCookie cookie = Request.Cookies["LoginInfo"];
			if (cookie == null)
				Response.Redirect("~/Default.aspx");
			if (cookie["IsStudent"] == "0" && ViewState["FirstTime"] == null)
			{
				MenuItem item = new MenuItem();
				item.Value = "Редактирование";
				item.NavigateUrl = "~/CheckYourselfEdit.aspx";
				MainMenu0.Items[0].ChildItems[0].ChildItems.Add(item);
				ViewState["FirstTime"] = 1;
			}
		}

		protected void GetAnswerButton1_Click(object sender, EventArgs e)
		{
			if (DropDownList1.SelectedIndex == 0)
			{
				int id = 0;
				foreach (TextQuestion c in task1)
				{
					foreach (TextQuestion c1 in task1)
						if (id == c1.ID)
							id++;
				}
				TextQuestion textquestion = new TextQuestion
				{
					ID = id,
					Question = Question1DescriptionTextBox.Text,
					Answer = Question1AnswerTextBox.Text,
				};
				task1.Add(textquestion);
				model.TextQuestion.Add(textquestion);
				DropDownList1.Items.Add(new ListItem("ID" + textquestion.ID + ". " + textquestion.Question, textquestion.ID.ToString()));
				DropDownList1.SelectedValue = textquestion.ID.ToString();
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList1.SelectedValue);
				TextQuestion textquestion = task1.FirstOrDefault(c => c.ID == currentID);
				textquestion.Question = Question1DescriptionTextBox.Text;
				textquestion.Answer = Question1AnswerTextBox.Text;

				textquestion = model.TextQuestion.Where(c => c.ID == currentID).FirstOrDefault();
				textquestion.Question = Question1DescriptionTextBox.Text;
				textquestion.Answer = Question1AnswerTextBox.Text;
				DropDownList1.SelectedItem.Text = "ID" + textquestion.ID + ". " + textquestion.Question;
			}
			model.SaveChanges();
		}

		protected void GetAnswerButton2_Click(object sender, EventArgs e)
		{
			if (DropDownList2.SelectedIndex == 0)
			{
				int id = 0;
				foreach (NumberQuestion c in task2)
				{
					foreach (NumberQuestion c1 in task2)
						if (id == c1.ID)
							id++;
				}
				NumberQuestion numberquestion = new NumberQuestion
				{
					ID = id,
					Question = Question2DescriptionTextBox.Text,
					Answer = Convert.ToInt32(Question2AnswerTextBox.Text),
				};
				task2.Add(numberquestion);
				model.NumberQuestion.Add(numberquestion);
				DropDownList2.Items.Add(new ListItem("ID" + numberquestion.ID + ". " + numberquestion.Question, numberquestion.ID.ToString()));
				DropDownList2.SelectedValue = numberquestion.ID.ToString();
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList2.SelectedValue);
				NumberQuestion numberquestion = task2.FirstOrDefault(c => c.ID == currentID);
				numberquestion.Question = Question2DescriptionTextBox.Text;
				numberquestion.Answer = Convert.ToInt32(Question2AnswerTextBox.Text);

				numberquestion = model.NumberQuestion.Where(c => c.ID == currentID).FirstOrDefault();
				numberquestion.Question = Question2DescriptionTextBox.Text;
				numberquestion.Answer = Convert.ToInt32(Question2AnswerTextBox.Text);
				DropDownList2.SelectedItem.Text = "ID" + numberquestion.ID + ". " + numberquestion.Question;
			}
			model.SaveChanges();
		}

		protected void GetAnswerButton3_Click(object sender, EventArgs e)
		{
			if (DropDownList3.SelectedIndex == 0)
			{
				int correctAnswer = 0;
				for (int i = 0; i < Question3RadioButtonList.Items.Count; i++)
					if (Question3RadioButtonList.Items[i].Selected)
						correctAnswer = i;
				int id = 0;
				foreach (ChoiceQuestion c in task3)
				{
					foreach (ChoiceQuestion c1 in task3)
						if (id == c1.ID)
							id++;
				}
				ChoiceQuestion task = new ChoiceQuestion
				{
					ID = id,
					Question = Question3DescriptionTextBox.Text,
					Answer1 = Question3AnswerTextBox1.Text,
					Answer2 = Question3AnswerTextBox2.Text,
					Answer3 = Question3AnswerTextBox3.Text,
					Answer4 = Question3AnswerTextBox4.Text,
					CorrectAnswer = correctAnswer + 1
				};
				task3.Add(task);
				model.ChoiceQuestion.Add(task);
				DropDownList3.Items.Add(new ListItem("ID" + task.ID + ". " + task.Question, task.ID.ToString()));
				DropDownList3.SelectedValue = task.ID.ToString();
				for (int i = 0; i < Question3RadioButtonList.Items.Count; i++)
					if (i != correctAnswer)
						Question3RadioButtonList.Items[i].Selected = false;
					else
						Question3RadioButtonList.Items[i].Selected = true;
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList3.SelectedValue);
				ChoiceQuestion task = task3.FirstOrDefault(c => c.ID == currentID);
				string temp;

				temp = Question3RadioButtonList.SelectedItem.Value;
				task.Question = Question3DescriptionTextBox.Text;
				task.Answer1 = Question3AnswerTextBox1.Text;
				task.Answer2 = Question3AnswerTextBox2.Text;
				task.Answer3 = Question3AnswerTextBox3.Text;
				task.Answer4 = Question3AnswerTextBox4.Text;
				int correctAnswer = 0;
				for (int i = 0; i < Question3RadioButtonList.Items.Count; i++)
					if (Question3RadioButtonList.Items[i].Selected)
						correctAnswer = i;

				task = model.ChoiceQuestion.Where(c => c.ID == currentID).FirstOrDefault();
				task.Question = Question3DescriptionTextBox.Text;
				task.Answer1 = Question3AnswerTextBox1.Text;
				task.Answer2 = Question3AnswerTextBox2.Text;
				task.Answer3 = Question3AnswerTextBox3.Text;
				task.Answer4 = Question3AnswerTextBox4.Text;
				for (int i = 0; i < Question3RadioButtonList.Items.Count; i++)
					if (Question3RadioButtonList.Items[i].Selected)
						correctAnswer = i;
				DropDownList3.SelectedItem.Text = "ID" + task.ID + ". " + task.Question;


				for (int i = 0; i < Question3RadioButtonList.Items.Count; i++)
					if (i != correctAnswer)
						Question3RadioButtonList.Items[i].Selected = false;
					else
						Question3RadioButtonList.Items[i].Selected = true;
			}
			model.SaveChanges();
		}

		protected void GetAnswerButton4_Click(object sender, EventArgs e)
		{
			if (DropDownList4.SelectedIndex == 0)
			{
				int id = 0;
				foreach (MultipleChoiceQuestion c in task4)
				{
					foreach (MultipleChoiceQuestion c1 in task4)
						if (id == c1.ID)
							id++;
				}
				MultipleChoiceQuestion task = new MultipleChoiceQuestion
				{
					ID = id,
					Answer1 = Question4AnswerTextBox1.Text,
					Answer2 = Question4AnswerTextBox2.Text,
					Answer3 = Question4AnswerTextBox3.Text,
					Answer4 = Question4AnswerTextBox4.Text,
					CorrectAnswer1 = Question4CheckBox1.Checked,
					CorrectAnswer2 = Question4CheckBox2.Checked,
					CorrectAnswer3 = Question4CheckBox3.Checked,
					CorrectAnswer4 = Question4CheckBox4.Checked,
					Question = "Выберете верные утверждения"
				};
				task4.Add(task);
				model.MultipleChoiceQuestion.Add(task);
				DropDownList4.Items.Add(new ListItem("ID" + task.ID + ". " + task.Question, task.ID.ToString()));
				DropDownList4.SelectedValue = task.ID.ToString();

				Question4CheckBox1.Checked = task.CorrectAnswer1;
				Question4CheckBox2.Checked = task.CorrectAnswer2;
				Question4CheckBox3.Checked = task.CorrectAnswer3;
				Question4CheckBox4.Checked = task.CorrectAnswer4;
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList4.SelectedValue);
				MultipleChoiceQuestion task = task4.FirstOrDefault(c => c.ID == currentID);
				task.Answer1 = Question4AnswerTextBox1.Text;
				task.Answer2 = Question4AnswerTextBox2.Text;
				task.Answer3 = Question4AnswerTextBox3.Text;
				task.Answer4 = Question4AnswerTextBox4.Text;
				task.CorrectAnswer1 = Question4CheckBox1.Checked;
				task.CorrectAnswer2 = Question4CheckBox2.Checked;
				task.CorrectAnswer3 = Question4CheckBox3.Checked;
				task.CorrectAnswer4 = Question4CheckBox4.Checked;

				task = model.MultipleChoiceQuestion.Where(c => c.ID == currentID).FirstOrDefault();
				task.Answer1 = Question4AnswerTextBox1.Text;
				task.Answer2 = Question4AnswerTextBox2.Text;
				task.Answer3 = Question4AnswerTextBox3.Text;
				task.Answer4 = Question4AnswerTextBox4.Text;
				task.CorrectAnswer1 = Question4CheckBox1.Checked;
				task.CorrectAnswer2 = Question4CheckBox2.Checked;
				task.CorrectAnswer3 = Question4CheckBox3.Checked;
				task.CorrectAnswer4 = Question4CheckBox4.Checked;
				DropDownList4.SelectedItem.Text = "ID" + task.ID + ". " + task.Question;

				Question4CheckBox1.Checked = task.CorrectAnswer1;
				Question4CheckBox2.Checked = task.CorrectAnswer2;
				Question4CheckBox3.Checked = task.CorrectAnswer3;
				Question4CheckBox4.Checked = task.CorrectAnswer4;
			}
			model.SaveChanges();
		}

		protected void GetAnswerButton5_Click(object sender, EventArgs e)
		{
			if (DropDownList5.SelectedIndex == 0)
			{
				int id = 0;
				foreach (ComplianceQuestion c in task5)
				{
					foreach (ComplianceQuestion c1 in task5)
						if (id == c1.ID)
							id++;
				}
				ComplianceQuestion task = new ComplianceQuestion
				{
					ID = id,
					Question1 = Question5TextBox1.Text,
					Question2 = Question5TextBox2.Text,
					Question3 = Question5TextBox3.Text,
					Question4 = Question5TextBox4.Text,
					CorrectAnswer1 = Convert.ToInt32(Question5DropDownList1.SelectedValue),
					CorrectAnswer2 = Convert.ToInt32(Question5DropDownList2.SelectedValue),
					CorrectAnswer3 = Convert.ToInt32(Question5DropDownList3.SelectedValue),
					CorrectAnswer4 = Convert.ToInt32(Question5DropDownList4.SelectedValue),
					Answer1 = Question5AnswerTextBox1.Text,
					Answer2 = Question5AnswerTextBox2.Text,
					Answer3 = Question5AnswerTextBox3.Text,
					Answer4 = Question5AnswerTextBox4.Text,
					Description = "Поставьте в соответствие утверждения из первого столбца с номером утверждения из второго"
				};
				task5.Add(task);
				model.ComplianceQuestion.Add(task);
				DropDownList5.Items.Add(new ListItem("ID" + task.ID + ". " + task.Description, task.ID.ToString()));
				DropDownList5.SelectedValue = task.ID.ToString();

				Question5DropDownList1.SelectedValue = task.CorrectAnswer1.ToString();
				Question5DropDownList2.SelectedValue = task.CorrectAnswer2.ToString();
				Question5DropDownList3.SelectedValue = task.CorrectAnswer3.ToString();
				Question5DropDownList4.SelectedValue = task.CorrectAnswer4.ToString();

			}
			else
			{
				currentID = Convert.ToInt32(DropDownList5.SelectedValue);
				ComplianceQuestion task = task5.FirstOrDefault(c => c.ID == currentID);
				task.Question1 = Question5TextBox1.Text;
				task.Question2 = Question5TextBox2.Text;
				task.Question3 = Question5TextBox3.Text;
				task.Question4 = Question5TextBox4.Text;
				task.CorrectAnswer1 = Convert.ToInt32(Question5DropDownList1.SelectedValue);
				task.CorrectAnswer2 = Convert.ToInt32(Question5DropDownList2.SelectedValue);
				task.CorrectAnswer3 = Convert.ToInt32(Question5DropDownList3.SelectedValue);
				task.CorrectAnswer4 = Convert.ToInt32(Question5DropDownList4.SelectedValue);
				task.Answer1 = Question5AnswerTextBox1.Text;
				task.Answer2 = Question5AnswerTextBox2.Text;
				task.Answer3 = Question5AnswerTextBox3.Text;
				task.Answer4 = Question5AnswerTextBox4.Text;

				task = model.ComplianceQuestion.Where(c => c.ID == currentID).FirstOrDefault();
				task.Question1 = Question5TextBox1.Text;
				task.Question2 = Question5TextBox2.Text;
				task.Question3 = Question5TextBox3.Text;
				task.Question4 = Question5TextBox4.Text;
				task.CorrectAnswer1 = Convert.ToInt32(Question5DropDownList1.SelectedValue);
				task.CorrectAnswer2 = Convert.ToInt32(Question5DropDownList2.SelectedValue);
				task.CorrectAnswer3 = Convert.ToInt32(Question5DropDownList3.SelectedValue);
				task.CorrectAnswer4 = Convert.ToInt32(Question5DropDownList4.SelectedValue);
				task.Answer1 = Question5AnswerTextBox1.Text;
				task.Answer2 = Question5AnswerTextBox2.Text;
				task.Answer3 = Question5AnswerTextBox3.Text;
				task.Answer4 = Question5AnswerTextBox4.Text;
				DropDownList5.SelectedItem.Text = "ID" + task.ID + ". " + task.Description;

				Question5DropDownList1.SelectedValue = task.CorrectAnswer1.ToString();
				Question5DropDownList2.SelectedValue = task.CorrectAnswer2.ToString();
				Question5DropDownList3.SelectedValue = task.CorrectAnswer3.ToString();
				Question5DropDownList4.SelectedValue = task.CorrectAnswer4.ToString();
			}
			model.SaveChanges();
		}

		protected void CheckYourselfLabel_Init(object sender, EventArgs e)
		{
			foreach (TextQuestion c in task1)
			{
				ListItem question = new ListItem();
				question.Value = c.ID.ToString();
				question.Text = "ID" + c.ID + ". " + c.Question;
				DropDownList1.Items.Add(question);
			}

			foreach (NumberQuestion c in task2)
			{
				ListItem question = new ListItem();
				question.Value = c.ID.ToString();
				question.Text = "ID" + c.ID + ". " + c.Question;
				DropDownList2.Items.Add(question);
			}

			foreach (ChoiceQuestion c in task3)
			{
				ListItem question = new ListItem();
				question.Value = c.ID.ToString();
				question.Text = "ID" + c.ID + ". " + c.Question;
				DropDownList3.Items.Add(question);
			}

			foreach (MultipleChoiceQuestion c in task4)
			{
				ListItem question = new ListItem();
				question.Value = c.ID.ToString();
				question.Text = "ID" + c.ID + ". " + c.Question;
				DropDownList4.Items.Add(question);
			}

			foreach (ComplianceQuestion c in task5)
			{
				ListItem question = new ListItem();
				question.Value = c.ID.ToString();
				question.Text = "ID" + c.ID + ". " + c.Description;
				DropDownList5.Items.Add(question);
			}
		}

		protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DropDownList1.SelectedIndex == 0)
			{
				Question1DescriptionTextBox.Text = string.Empty;
				Question1AnswerTextBox.Text = string.Empty;
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList1.SelectedValue);
				Question1DescriptionTextBox.Text = task1.FirstOrDefault(c => c.ID == currentID).Question;
				Question1AnswerTextBox.Text = task1.FirstOrDefault(c => c.ID == currentID).Answer;
			}
		}

		protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DropDownList2.SelectedIndex == 0)
			{
				Question2DescriptionTextBox.Text = string.Empty;
				Question2AnswerTextBox.Text = string.Empty;
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList2.SelectedValue);
				Question2DescriptionTextBox.Text = task2.FirstOrDefault(c => c.ID == currentID).Question;
				Question2AnswerTextBox.Text = task2.FirstOrDefault(c => c.ID == currentID).Answer.ToString();
			}
		}

		protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DropDownList3.SelectedIndex == 0)
			{
				Question3DescriptionTextBox.Text = string.Empty;
				Question3AnswerTextBox1.Text = string.Empty;
				Question3AnswerTextBox2.Text = string.Empty;
				Question3AnswerTextBox3.Text = string.Empty;
				Question3AnswerTextBox4.Text = string.Empty;
				Question3RadioButtonList.Items[0].Selected = true;
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList3.SelectedValue);
				Question3DescriptionTextBox.Text = task3.FirstOrDefault(c => c.ID == currentID).Question;
				Question3AnswerTextBox1.Text = task3.FirstOrDefault(c => c.ID == currentID).Answer1;
				Question3AnswerTextBox2.Text = task3.FirstOrDefault(c => c.ID == currentID).Answer2;
				Question3AnswerTextBox3.Text = task3.FirstOrDefault(c => c.ID == currentID).Answer3;
				Question3AnswerTextBox4.Text = task3.FirstOrDefault(c => c.ID == currentID).Answer4;
				for (int i = 0; i < Question3RadioButtonList.Items.Count; i++)
					Question3RadioButtonList.Items[i].Selected = i == task3.FirstOrDefault(c => c.ID == currentID).CorrectAnswer - 1 ? true : false;
			}
		}

		protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DropDownList4.SelectedIndex == 0)
			{
				Question4DescriptionTextBox.Text = string.Empty;
				Question4AnswerTextBox1.Text = string.Empty;
				Question4AnswerTextBox2.Text = string.Empty;
				Question4AnswerTextBox3.Text = string.Empty;
				Question4AnswerTextBox4.Text = string.Empty;
				Question4CheckBox1.Checked = false;
				Question4CheckBox2.Checked = false;
				Question4CheckBox3.Checked = false;
				Question4CheckBox4.Checked = false;

			}
			else
			{
				currentID = Convert.ToInt32(DropDownList4.SelectedValue);
				Question4DescriptionTextBox.Text = task4.FirstOrDefault(c => c.ID == currentID).Question;
				Question4AnswerTextBox1.Text = task4.FirstOrDefault(c => c.ID == currentID).Answer1;
				Question4AnswerTextBox2.Text = task4.FirstOrDefault(c => c.ID == currentID).Answer2;
				Question4AnswerTextBox3.Text = task4.FirstOrDefault(c => c.ID == currentID).Answer3;
				Question4AnswerTextBox4.Text = task4.FirstOrDefault(c => c.ID == currentID).Answer4;
				Question4CheckBox1.Checked = task4.FirstOrDefault(c => c.ID == currentID).CorrectAnswer1;
				Question4CheckBox2.Checked = task4.FirstOrDefault(c => c.ID == currentID).CorrectAnswer2;
				Question4CheckBox3.Checked = task4.FirstOrDefault(c => c.ID == currentID).CorrectAnswer3;
				Question4CheckBox4.Checked = task4.FirstOrDefault(c => c.ID == currentID).CorrectAnswer4;
			}
		}

		protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DropDownList5.SelectedIndex == 0)
			{
				Question5DescriptionTextBox.Text = string.Empty;
				Question5AnswerTextBox1.Text = string.Empty;
				Question5AnswerTextBox2.Text = string.Empty;
				Question5AnswerTextBox3.Text = string.Empty;
				Question5AnswerTextBox4.Text = string.Empty;
				Question5TextBox1.Text = string.Empty;
				Question5TextBox2.Text = string.Empty;
				Question5TextBox3.Text = string.Empty;
				Question5TextBox4.Text = string.Empty;
				Question5DropDownList1.SelectedValue = "1";
				Question5DropDownList2.SelectedValue = "1";
				Question5DropDownList3.SelectedValue = "1";
				Question5DropDownList4.SelectedValue = "1";

			}
			else
			{
				currentID = Convert.ToInt32(DropDownList5.SelectedValue);
				Question5DescriptionTextBox.Text = task5.FirstOrDefault(c => c.ID == currentID).Description;
				Question5TextBox1.Text = task5.FirstOrDefault(c => c.ID == currentID).Question1;
				Question5TextBox2.Text = task5.FirstOrDefault(c => c.ID == currentID).Question2;
				Question5TextBox3.Text = task5.FirstOrDefault(c => c.ID == currentID).Question3;
				Question5TextBox4.Text = task5.FirstOrDefault(c => c.ID == currentID).Question4;
				Question5AnswerTextBox1.Text = task5.FirstOrDefault(c => c.ID == currentID).Answer1;
				Question5AnswerTextBox2.Text = task5.FirstOrDefault(c => c.ID == currentID).Answer2;
				Question5AnswerTextBox3.Text = task5.FirstOrDefault(c => c.ID == currentID).Answer3;
				Question5AnswerTextBox4.Text = task5.FirstOrDefault(c => c.ID == currentID).Answer4;
				Question5DropDownList1.SelectedValue = task5.FirstOrDefault(c => c.ID == currentID).CorrectAnswer1.ToString();
				Question5DropDownList2.SelectedValue = task5.FirstOrDefault(c => c.ID == currentID).CorrectAnswer2.ToString();
				Question5DropDownList3.SelectedValue = task5.FirstOrDefault(c => c.ID == currentID).CorrectAnswer3.ToString();
				Question5DropDownList4.SelectedValue = task5.FirstOrDefault(c => c.ID == currentID).CorrectAnswer4.ToString();
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