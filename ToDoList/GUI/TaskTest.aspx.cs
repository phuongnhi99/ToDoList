using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToDoList.BLL;

namespace ToDoList.GUI
{
    public partial class TaskTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Entity.Task> task = TaskBLL.GetAllTask();
            GridView1.DataSource = task.ToList();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}