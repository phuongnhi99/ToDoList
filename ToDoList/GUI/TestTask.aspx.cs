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
    public partial class TestTask : System.Web.UI.Page
    {
        //public object GridViewTask { get; private set; }

        //public void Page_Load(object sender, EventArgs e)
        //{
        //    List<Entity.Task> ta = TaskBLL.GetAllTask();
        //    GridViewTask.DataSource = ta.ToList();
        //    GridViewTask.DataBind();
        //}

        //protected void GridViewTask_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    if (Panel1.Visible == true)
        //        Panel1.Visible = false;
        //    else
        //        Panel1.Visible = true;
        //}

        //protected void Button3_Click(object sender, EventArgs e)
        //{
        //    Entity.Task ta = new Entity.Task()
        //    {
        //        TaskId = TextBox1.Text,
        //        Name = TextBox2.Text
        //    };
        //    TaskBLL.AddTask(ta);
        //    Page_Load(sender, e);
        //}

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    if (Panel2.Visible == true)
        //        Panel2.Visible = false;
        //    else
        //        Panel2.Visible = true;
        //}

        //protected void Button4_Click(object sender, EventArgs e)
        //{
        //    Entity.Task ta = new Entity.Task()
        //    {
        //        TaskId = TextBox3.Text,
        //        Name = TextBox4.Text
        //    };
        //    TaskBLL.EditTask(ta);
        //    Page_Load(sender, e);
        //}
    }
}