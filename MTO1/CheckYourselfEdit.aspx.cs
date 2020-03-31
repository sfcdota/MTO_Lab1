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

		List<Task> task1 = model.Task.Where(c => c.Type == 1).ToList();
		List<Task> task2 = model.Task.Where(c => c.Type == 2).ToList();
		List<Task> task3 = model.Task.Where(c => c.Type == 3).ToList();
		List<Task> task4 = model.Task.Where(c => c.Type == 4).ToList();
		List<Task> task5 = model.Task.Where(c => c.Type == 5).ToList();
		List<Task> tasks = model.Task.ToList();
		int currentID;
		protected void Page_Load(object sender, EventArgs e)
		{
			Page.MaintainScrollPositionOnPostBack = true;
			HttpCookie cookie = Request.Cookies["LoginInfo"];
			if (cookie["IsStudent"] == "0" && ViewState["FirstTime"] == null)
			{
				MenuItem item = new MenuItem();
				item.Value = "Редактирование";
				item.NavigateUrl = "~/CheckYourselfEdit.aspx";
				MainMenu0.Items[0].ChildItems[0].ChildItems.Add(item);
				ViewState["FirstTime"] = 1;
			}
		}
		protected int Generate_ID()
		{
			int id = 0;
			foreach(Task c in tasks)
			{
				foreach (Task c1 in tasks)
					if (id == c1.ID)
						id++;
			}
			return id;
		}
		protected void GetAnswerButton1_Click(object sender, EventArgs e)
		{
			if (DropDownList1.SelectedIndex == 0)
			{
				Task task = new Task
				{
					ID = Generate_ID(),
					Question_1 = Question1DescriptionTextBox.Text,
					AnswerDescription1 = Question1AnswerTextBox.Text,
					Type = 1
				};
				task1.Add(task);
				tasks.Add(task);
				model.Task.Add(task);
				DropDownList1.Items.Add(new ListItem("ID" + task.ID + ". " + task.Question_1, task.ID.ToString()));
				DropDownList1.SelectedValue = task.ID.ToString();
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList1.SelectedValue);
				Task task = task1.FirstOrDefault(c => c.ID == currentID);
				task.Question_1 = Question1DescriptionTextBox.Text;
				task.AnswerDescription1 = Question1AnswerTextBox.Text;

				task = model.Task.Where(c => c.ID == currentID).FirstOrDefault();
				task.Question_1 = Question1DescriptionTextBox.Text;
				task.AnswerDescription1 = Question1AnswerTextBox.Text;
				DropDownList1.SelectedItem.Text = "ID" + task.ID + ". " + task.Question_1;
			}
			model.SaveChanges();
		}

		protected void GetAnswerButton2_Click(object sender, EventArgs e)
		{
			if (DropDownList2.SelectedIndex == 0)
			{
				Task task = new Task
				{
					ID = Generate_ID(),
					Question_1 = Question2DescriptionTextBox.Text,
					AnswerDescription1 = Question2AnswerTextBox.Text,
					Type = 2
				};
				task2.Add(task);
				tasks.Add(task);
				model.Task.Add(task);
				DropDownList2.Items.Add(new ListItem("ID" + task.ID + ". " + task.Question_1, task.ID.ToString()));
				DropDownList2.SelectedValue = task.ID.ToString();
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList2.SelectedValue);
				Task task = task2.FirstOrDefault(c => c.ID == currentID);
				task.Question_1 = Question2DescriptionTextBox.Text;
				task.AnswerDescription1 = Question2AnswerTextBox.Text;

				task = model.Task.Where(c => c.ID == currentID).FirstOrDefault();
				task.Question_1 = Question2DescriptionTextBox.Text;
				task.AnswerDescription1 = Question2AnswerTextBox.Text;
				DropDownList2.SelectedItem.Text = "ID" + task.ID + ". " + task.Question_1;
			}
			model.SaveChanges();
		}

		protected void GetAnswerButton3_Click(object sender, EventArgs e)
		{
			if (DropDownList3.SelectedIndex == 0)
			{
				Task task = new Task
				{
					ID = Generate_ID(),
					Question_1 = Question3DescriptionTextBox.Text,
					AnswerDescription1 = Question3AnswerTextBox1.Text,
					AnswerDescription2 = Question3AnswerTextBox2.Text,
					AnswerDescription3 = Question3AnswerTextBox3.Text,
					AnswerDescription4 = Question3AnswerTextBox4.Text,
					Answer_1 = Convert.ToInt32(Question3RadioButtonList.Items[0].Selected),
					Answer_2 = Convert.ToInt32(Question3RadioButtonList.Items[1].Selected),
					Answer_3 = Convert.ToInt32(Question3RadioButtonList.Items[2].Selected),
					Answer_4 = Convert.ToInt32(Question3RadioButtonList.Items[3].Selected),
					Type = 3
				};
				task3.Add(task);
				tasks.Add(task);
				model.Task.Add(task);
				DropDownList3.Items.Add(new ListItem("ID" + task.ID + ". " + task.Question_1, task.ID.ToString()));
				DropDownList3.SelectedValue = task.ID.ToString();
				Question3RadioButtonList.Items[0].Selected = Convert.ToBoolean(task.Answer_1);
				Question3RadioButtonList.Items[1].Selected = Convert.ToBoolean(task.Answer_2);
				Question3RadioButtonList.Items[2].Selected = Convert.ToBoolean(task.Answer_3);
				Question3RadioButtonList.Items[3].Selected = Convert.ToBoolean(task.Answer_4);
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList3.SelectedValue);
				Task task = task3.FirstOrDefault(c => c.ID == currentID);
				string temp;

				temp = Question3RadioButtonList.SelectedItem.Value;
				task.Question_1 = Question3DescriptionTextBox.Text;
				task.AnswerDescription1 = Question3AnswerTextBox1.Text;
				task.AnswerDescription2 = Question3AnswerTextBox2.Text;
				task.AnswerDescription3 = Question3AnswerTextBox3.Text;
				task.AnswerDescription4 = Question3AnswerTextBox4.Text;
				task.Answer_1 = Convert.ToInt32(Question3RadioButtonList.Items[0].Selected);
				task.Answer_2 = Convert.ToInt32(Question3RadioButtonList.Items[1].Selected);
				task.Answer_3 = Convert.ToInt32(Question3RadioButtonList.Items[2].Selected);
				task.Answer_4 = Convert.ToInt32(Question3RadioButtonList.Items[3].Selected);

				task = model.Task.Where(c => c.ID == currentID).FirstOrDefault();
				task.Question_1 = Question3DescriptionTextBox.Text;
				task.AnswerDescription1 = Question3AnswerTextBox1.Text;
				task.AnswerDescription2 = Question3AnswerTextBox2.Text;
				task.AnswerDescription3 = Question3AnswerTextBox3.Text;
				task.AnswerDescription4 = Question3AnswerTextBox4.Text;
				task.Answer_1 = Convert.ToInt32(Question3RadioButtonList.Items[0].Selected);
				task.Answer_2 = Convert.ToInt32(Question3RadioButtonList.Items[1].Selected);
				task.Answer_3 = Convert.ToInt32(Question3RadioButtonList.Items[2].Selected);
				task.Answer_4 = Convert.ToInt32(Question3RadioButtonList.Items[3].Selected);
				DropDownList3.SelectedItem.Text = "ID" + task.ID + ". " + task.Question_1;


				Question3RadioButtonList.Items[0].Selected = Convert.ToBoolean(task.Answer_1);
				Question3RadioButtonList.Items[1].Selected = Convert.ToBoolean(task.Answer_2);
				Question3RadioButtonList.Items[2].Selected = Convert.ToBoolean(task.Answer_3);
				Question3RadioButtonList.Items[3].Selected = Convert.ToBoolean(task.Answer_4);
			}
			model.SaveChanges();
		}

		protected void GetAnswerButton4_Click(object sender, EventArgs e)
		{
			if (DropDownList4.SelectedIndex == 0)
			{
				Task task = new Task
				{
					ID = Generate_ID(),
					Question_1 = Question4AnswerTextBox1.Text,
					Question_2 = Question4AnswerTextBox2.Text,
					Question_3 = Question4AnswerTextBox3.Text,
					Question_4 = Question4AnswerTextBox4.Text,
					Answer_1 = Convert.ToInt32(Question4CheckBox1.Checked),
					Answer_2 = Convert.ToInt32(Question4CheckBox2.Checked),
					Answer_3 = Convert.ToInt32(Question4CheckBox3.Checked),
					Answer_4 = Convert.ToInt32(Question4CheckBox4.Checked),
					Type = 4,
					Description = "Выберете верные утверждения"
				};
				task4.Add(task);
				tasks.Add(task);
				model.Task.Add(task);
				DropDownList4.Items.Add(new ListItem("ID" + task.ID + ". " + task.Description, task.ID.ToString()));
				DropDownList4.SelectedValue = task.ID.ToString();

				Question4CheckBox1.Checked = Convert.ToBoolean(task.Answer_1);
				Question4CheckBox2.Checked = Convert.ToBoolean(task.Answer_2);
				Question4CheckBox3.Checked = Convert.ToBoolean(task.Answer_3);
				Question4CheckBox4.Checked = Convert.ToBoolean(task.Answer_4);
			}
			else
			{
				currentID = Convert.ToInt32(DropDownList4.SelectedValue);
				Task task = task4.FirstOrDefault(c => c.ID == currentID);
				task.Question_1 = Question4AnswerTextBox1.Text;
				task.Question_2 = Question4AnswerTextBox2.Text;
				task.Question_3 = Question4AnswerTextBox3.Text;
				task.Question_4 = Question4AnswerTextBox4.Text;
				task.Answer_1 = Convert.ToInt32(Question4CheckBox1.Checked);
				task.Answer_2 = Convert.ToInt32(Question4CheckBox2.Checked);
				task.Answer_3 = Convert.ToInt32(Question4CheckBox3.Checked);
				task.Answer_4 = Convert.ToInt32(Question4CheckBox4.Checked);

				task = model.Task.Where(c => c.ID == currentID).FirstOrDefault();
				task.Question_1 = Question4AnswerTextBox1.Text;
				task.Question_2 = Question4AnswerTextBox2.Text;
				task.Question_3 = Question4AnswerTextBox3.Text;
				task.Question_4 = Question4AnswerTextBox4.Text;
				task.Answer_1 = Convert.ToInt32(Question4CheckBox1.Checked);
				task.Answer_2 = Convert.ToInt32(Question4CheckBox2.Checked);
				task.Answer_3 = Convert.ToInt32(Question4CheckBox3.Checked);
				task.Answer_4 = Convert.ToInt32(Question4CheckBox4.Checked);
				DropDownList4.SelectedItem.Text = "ID" + task.ID + ". " + task.Description;

				Question4CheckBox1.Checked = Convert.ToBoolean(task.Answer_1);
				Question4CheckBox2.Checked = Convert.ToBoolean(task.Answer_2);
				Question4CheckBox3.Checked = Convert.ToBoolean(task.Answer_3);
				Question4CheckBox4.Checked = Convert.ToBoolean(task.Answer_4);
			}
			model.SaveChanges();
		}

		protected void GetAnswerButton5_Click(object sender, EventArgs e)
		{
			if (DropDownList5.SelectedIndex == 0)
			{
				Task task = new Task
				{
					ID = Generate_ID(),
					Question_1 = Question5TextBox1.Text,
					Question_2 = Question5TextBox2.Text,
					Question_3 = Question5TextBox3.Text,
					Question_4 = Question5TextBox4.Text,
					Answer_1 = Convert.ToInt32(Question5DropDownList1.SelectedValue),
					Answer_2 = Convert.ToInt32(Question5DropDownList2.SelectedValue),
					Answer_3 = Convert.ToInt32(Question5DropDownList3.SelectedValue),
					Answer_4 = Convert.ToInt32(Question5DropDownList4.SelectedValue),
					AnswerDescription1 = Question5AnswerTextBox1.Text,
					AnswerDescription2 = Question5AnswerTextBox2.Text,
					AnswerDescription3 = Question5AnswerTextBox3.Text,
					AnswerDescription4 = Question5AnswerTextBox4.Text,
					Type = 5,
					Description = "Поставьте в соответствие утверждения из первого столбца с номером утверждения из второго"
				};
				task5.Add(task);
				tasks.Add(task);
				model.Task.Add(task);
				DropDownList5.Items.Add(new ListItem("ID" + task.ID + ". " + task.Description, task.ID.ToString()));
				DropDownList5.SelectedValue = task.ID.ToString();

				Question5DropDownList1.SelectedValue = task.Answer_1.ToString();
				Question5DropDownList2.SelectedValue = task.Answer_2.ToString();
				Question5DropDownList3.SelectedValue = task.Answer_3.ToString();
				Question5DropDownList4.SelectedValue = task.Answer_4.ToString();

			}
			else
			{
				currentID = Convert.ToInt32(DropDownList5.SelectedValue);
				Task task = task5.FirstOrDefault(c => c.ID == currentID);
				task.Question_1 = Question5TextBox1.Text;
				task.Question_2 = Question5TextBox2.Text;
				task.Question_3 = Question5TextBox3.Text;
				task.Question_4 = Question5TextBox4.Text;
				task.Answer_1 = Convert.ToInt32(Question5DropDownList1.SelectedValue);
				task.Answer_2 = Convert.ToInt32(Question5DropDownList2.SelectedValue);
				task.Answer_3 = Convert.ToInt32(Question5DropDownList3.SelectedValue);
				task.Answer_4 = Convert.ToInt32(Question5DropDownList4.SelectedValue);
				task.AnswerDescription1 = Question5AnswerTextBox1.Text;
				task.AnswerDescription2 = Question5AnswerTextBox2.Text;
				task.AnswerDescription3 = Question5AnswerTextBox3.Text;
				task.AnswerDescription4 = Question5AnswerTextBox4.Text;

				task = model.Task.Where(c => c.ID == currentID).FirstOrDefault();
				task.Question_1 = Question5TextBox1.Text;
				task.Question_2 = Question5TextBox2.Text;
				task.Question_3 = Question5TextBox3.Text;
				task.Question_4 = Question5TextBox4.Text;
				task.Answer_1 = Convert.ToInt32(Question5DropDownList1.SelectedValue);
				task.Answer_2 = Convert.ToInt32(Question5DropDownList2.SelectedValue);
				task.Answer_3 = Convert.ToInt32(Question5DropDownList3.SelectedValue);
				task.Answer_4 = Convert.ToInt32(Question5DropDownList4.SelectedValue);
				task.AnswerDescription1 = Question5AnswerTextBox1.Text;
				task.AnswerDescription2 = Question5AnswerTextBox2.Text;
				task.AnswerDescription3 = Question5AnswerTextBox3.Text;
				task.AnswerDescription4 = Question5AnswerTextBox4.Text;
				DropDownList5.SelectedItem.Text = "ID" + task.ID + ". " + task.Description;

				Question5DropDownList1.SelectedValue = task.Answer_1.ToString();
				Question5DropDownList2.SelectedValue = task.Answer_2.ToString();
				Question5DropDownList3.SelectedValue = task.Answer_3.ToString();
				Question5DropDownList4.SelectedValue = task.Answer_4.ToString();
			}
			model.SaveChanges();
		}

		protected void CheckYourselfLabel_Init(object sender, EventArgs e)
		{
			foreach (Task c in task1)
			{
				ListItem question1 = new ListItem();
				question1.Value = c.ID.ToString();
				question1.Text = "ID" + c.ID + ". " + c.Question_1;
				DropDownList1.Items.Add(question1);
			}

			foreach (Task c in task2)
			{
				ListItem question1 = new ListItem();
				question1.Value = c.ID.ToString();
				question1.Text = "ID" + c.ID + ". " + c.Question_1;
				DropDownList2.Items.Add(question1);
			}

			foreach (Task c in task3)
			{
				ListItem question1 = new ListItem();
				question1.Value = c.ID.ToString();
				question1.Text = "ID" + c.ID + ". " + c.Question_1;
				DropDownList3.Items.Add(question1);
			}

			foreach (Task c in task4)
			{
				ListItem question1 = new ListItem();
				question1.Value = c.ID.ToString();
				question1.Text = "ID" + c.ID + ". " + c.Description;
				DropDownList4.Items.Add(question1);
			}

			foreach (Task c in task5)
			{
				ListItem question1 = new ListItem();
				question1.Value = c.ID.ToString();
				question1.Text = "ID" + c.ID + ". " + c.Description;
				DropDownList5.Items.Add(question1);
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
				Question1DescriptionTextBox.Text = task1.FirstOrDefault(c => c.ID == currentID).Question_1;
				Question1AnswerTextBox.Text = task1.FirstOrDefault(c => c.ID == currentID).AnswerDescription1;
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
				Question2DescriptionTextBox.Text = task2.FirstOrDefault(c => c.ID == currentID).Question_1;
				Question2AnswerTextBox.Text = task2.FirstOrDefault(c => c.ID == currentID).AnswerDescription1;
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
				Question3DescriptionTextBox.Text = task3.FirstOrDefault(c => c.ID == currentID).Question_1;
				Question3AnswerTextBox1.Text = task3.FirstOrDefault(c => c.ID == currentID).AnswerDescription1;
				Question3AnswerTextBox2.Text = task3.FirstOrDefault(c => c.ID == currentID).AnswerDescription2;
				Question3AnswerTextBox3.Text = task3.FirstOrDefault(c => c.ID == currentID).AnswerDescription3;
				Question3AnswerTextBox4.Text = task3.FirstOrDefault(c => c.ID == currentID).AnswerDescription4;
				Question3RadioButtonList.Items[0].Selected = Convert.ToBoolean(task3.FirstOrDefault(c => c.ID == currentID).Answer_1);
				Question3RadioButtonList.Items[1].Selected = Convert.ToBoolean(task3.FirstOrDefault(c => c.ID == currentID).Answer_2);
				Question3RadioButtonList.Items[2].Selected = Convert.ToBoolean(task3.FirstOrDefault(c => c.ID == currentID).Answer_3);
				Question3RadioButtonList.Items[3].Selected = Convert.ToBoolean(task3.FirstOrDefault(c => c.ID == currentID).Answer_4);
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
				Question4DescriptionTextBox.Text = task4.FirstOrDefault(c => c.ID == currentID).Description;
				Question4AnswerTextBox1.Text = task4.FirstOrDefault(c => c.ID == currentID).Question_1;
				Question4AnswerTextBox2.Text = task4.FirstOrDefault(c => c.ID == currentID).Question_2;
				Question4AnswerTextBox3.Text = task4.FirstOrDefault(c => c.ID == currentID).Question_3;
				Question4AnswerTextBox4.Text = task4.FirstOrDefault(c => c.ID == currentID).Question_4;
				Question4CheckBox1.Checked = Convert.ToBoolean(task4.FirstOrDefault(c => c.ID == currentID).Answer_1);
				Question4CheckBox2.Checked = Convert.ToBoolean(task4.FirstOrDefault(c => c.ID == currentID).Answer_2);
				Question4CheckBox3.Checked = Convert.ToBoolean(task4.FirstOrDefault(c => c.ID == currentID).Answer_3);
				Question4CheckBox4.Checked = Convert.ToBoolean(task4.FirstOrDefault(c => c.ID == currentID).Answer_4);
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
				Question5TextBox1.Text = task5.FirstOrDefault(c => c.ID == currentID).Question_1;
				Question5TextBox2.Text = task5.FirstOrDefault(c => c.ID == currentID).Question_2;
				Question5TextBox3.Text = task5.FirstOrDefault(c => c.ID == currentID).Question_3;
				Question5TextBox4.Text = task5.FirstOrDefault(c => c.ID == currentID).Question_4;
				Question5AnswerTextBox1.Text = task5.FirstOrDefault(c => c.ID == currentID).AnswerDescription1;
				Question5AnswerTextBox2.Text = task5.FirstOrDefault(c => c.ID == currentID).AnswerDescription2;
				Question5AnswerTextBox3.Text = task5.FirstOrDefault(c => c.ID == currentID).AnswerDescription3;
				Question5AnswerTextBox4.Text = task5.FirstOrDefault(c => c.ID == currentID).AnswerDescription4;
				Question5DropDownList1.SelectedValue = task5.FirstOrDefault(c => c.ID == currentID).Answer_1.ToString();
				Question5DropDownList2.SelectedValue = task5.FirstOrDefault(c => c.ID == currentID).Answer_2.ToString();
				Question5DropDownList3.SelectedValue = task5.FirstOrDefault(c => c.ID == currentID).Answer_3.ToString();
				Question5DropDownList4.SelectedValue = task5.FirstOrDefault(c => c.ID == currentID).Answer_4.ToString();
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