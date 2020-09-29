using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToDoList.BLL;
using ToDoList.Entity;

namespace ToDoList.GUI
{
    public partial class TaskTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Task> task = TaskBLL.GetAllTask();
            GridView1.DataSource = task.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Task task = new Task()
            //{
            //    ID = txtID.Text,
            //    Name = txtName.Text,
            //    OwnerId = txtOwnerId.Text,
            //    StartDay = Convert.ToDateTime(txtStartDay.Text),
            //    Deadline = Convert.ToDateTime(txtDeadline.Text),
            //    Description = txtDescription.Text,
            //    Attachment = txtAttachment.Text,
            //    Visability = txtVisibility.Text,
            //    Status = txtStatus.Text,
            //    Partner = txtPartner.Text,
            //    Comment = txtComment.Text,
            //};
            //TaskBLL.AddTask(task);
            //Page_Load(sender, e);
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            //string a = edit.Text;
            //Task t= TaskBLL.GetTask(a);
            //txtID.Text = t.ID;
            //txtName.Text = t.Name;
            //txtOwnerId.Text = t.OwnerId;
            //txtStartDay.Text = Convert.ToString(t.StartDay);
            //txtDeadline.Text = Convert.ToString(t.Deadline);
            //txtDescription.Text = t.Description;
            //txtAttachment.Text = t.Attachment;
            //txtComment.Text = t.Comment;
            //txtStatus.Text = t.Status;
            //txtPartner.Text = t.Partner;
            //txtVisibility.Text = t.Visability;
            //Page_Load(sender, e);
        }

        protected void sua_Click(object sender, EventArgs e)
        {
            //Task task = new Task()
            //{
            //    ID = txtID.Text,
            //    Name = txtName.Text,
            //    OwnerId = txtOwnerId.Text,
            //    StartDay = Convert.ToDateTime(txtStartDay.Text),
            //    Deadline = Convert.ToDateTime(txtDeadline.Text),
            //    Description = txtDescription.Text,
            //    Attachment = txtAttachment.Text,
            //    Visability = txtVisibility.Text,
            //    Status = txtStatus.Text,
            //    Partner = txtPartner.Text,
            //    Comment = txtComment.Text,
            //};
            //TaskBLL.EditTask(task);
            //Page_Load(sender, e);
        }
    }
}
