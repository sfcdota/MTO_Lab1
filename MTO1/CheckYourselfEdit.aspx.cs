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
		Model model = new Model();
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void GetAnswerButton1_Click(object sender, EventArgs e)
		{

		}

		protected void GetAnswerButton2_Click(object sender, EventArgs e)
		{

		}

		protected void GetAnswerButton3_Click(object sender, EventArgs e)
		{

		}

		protected void GetAnswerButton4_Click(object sender, EventArgs e)
		{

		}

		protected void GetAnswerButton5_Click(object sender, EventArgs e)
		{

		}

		protected void CheckYourselfLabel_Init(object sender, EventArgs e)
		{
			List<Task> task1 = model.Task.Where(c => c.Type == 1).ToList();
			List<Task> task2 = model.Task.Where(c => c.Type == 2).ToList();
			List<Task> task3 = model.Task.Where(c => c.Type == 3).ToList();
			List<Task> task4 = model.Task.Where(c => c.Type == 4).ToList();
			List<Task> task5 = model.Task.Where(c => c.Type == 5).ToList();

			foreach(Task c in task1)
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
				question1.Text = "ID" + c.ID + ". " + c.Question_1;
				DropDownList4.Items.Add(question1);
			}

			foreach (Task c in task5)
			{
				ListItem question1 = new ListItem();
				question1.Value = c.ID.ToString();
				question1.Text = "ID" + c.ID + ". " + c.Question_1;
				DropDownList5.Items.Add(question1);
			}
		}
	}
}