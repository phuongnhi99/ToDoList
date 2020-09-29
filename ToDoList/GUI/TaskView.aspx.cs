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
    public partial class WebForm1 : System.Web.UI.Page
    { 
        public List<Task> DataSource { get; private set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            progress.InnerHtml = "";
            done.InnerHtml = "";
            late.InnerHtml = "";
            List<Entity.Task> taskProgress = TaskBLL.GetTaskProgress();
            List<Entity.Task> taskDone = TaskBLL.GetTaskDone();
            List<Entity.Task> taskLate = TaskBLL.GetTaskLate();
            DataSource = taskProgress.ToList();
            DataSource = taskDone.ToList();
            DataSource = taskLate.ToList();
            DataBind();
            foreach (Entity.Task task_progress in taskProgress)
                progress.InnerHtml = progress.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                        "<li class=\"card\">" +
                            "<div class=\"card-body p-1\">" +
                                "<div class=\"card-title m-0\">" +
                                    task_progress.Name +
                                "</div>" +
                                "<button class=\"btn p-1 float-md-right status-progress-btn\"><i class=\"fa fa-arrow-right\"></i></button>" +
                            "</div>" +
                        "</li>" +
                    "</ul>";

            foreach (Entity.Task task_done in taskDone)
                done.InnerHtml = done.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                        "<li class=\"card\">" +
                            "<div class=\"card-body p-1\">" +
                                "<div class=\"card-title m-0\">" +
                                    task_done.Name +
                                "</div>" +
                                "<button class=\"btn p-1 status-done-btn\"><i class=\"fa fa-arrow-left\"></i></button>" +
                            "</div>" +
                        "</li>" +
                    "</ul>";

            foreach (Entity.Task task_late in taskLate)
                late.InnerHtml = late.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                        "<li class=\"card\">" +
                            "<div class=\"card-body p-1\">" +
                                "<div class=\"card-title m-0\">" +
                                    task_late.Name +
                                "</div>" +                   
                            "</div>" +
                        "</li>" +
                    "</ul>";
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }
        protected void btnClose_Clicks(object sender, EventArgs e)
        {
            if(edit_cover.Visible == true)
            edit_cover.Visible = false;
        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}