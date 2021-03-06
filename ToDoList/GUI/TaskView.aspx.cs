﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ToDoList.BLL;
using ToDoList.Entity;
using Xceed.Wpf.AvalonDock.Converters;

namespace ToDoList.GUI
{
    public partial class WebForm1 : System.Web.UI.Page
    { 
        public List<Task> DataSourceTask { get; set; }
        public List<Comment> DataSourceCmt { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                if (Request.Form["btnInprogress"] != null)
                {
                    string btnInprogress = Request.Form["btnInprogress"];
                    TaskBLL.ChangeStatusToDone(btnInprogress);
                    Page_Load1(sender, e);
                }
                if (Request.Form["btnDone"] != null)
                {
                    string btnDone = Request.Form["btnDone"];
                    TaskBLL.ChangeStatusToInprogress(btnDone);
                    Page_Load1(sender, e);
                }
                if (Request.Form["editInprogress"] != null)
                {
                    int editInprogress = Convert.ToInt32(Request.Form["editInprogress"]);
                    Task task = TaskBLL.GetTask(editInprogress);
                    inputName.Value = task.Name;
                    start_date.Value = String.Format("{0:yyyy-MM-dd}", task.StartDay);
                    deadline.Value = String.Format("{0:yyyy-MM-dd}", task.Deadline);
                    //  deadline.Value = Convert.ToString(task.Deadline);
                    inputDescription.Value = task.Description;
                    File.Value = task.Attachment;
                    id_task.Value = Request.Form["editInprogress"];
                    edit_cover.Visible = true;
                    btnsave.InnerText = "Edit";
                    Page_Load1(sender, e);
                }
                if (Request.Form["editDone"] != null)
                {
                    int editDone = Convert.ToInt32(Request.Form["editDone"]);
                    Task task = TaskBLL.GetTask(editDone);
                    inputName.Value = task.Name;
                    start_date.Value = String.Format("{0:yyyy-MM-dd}", task.StartDay);
                    deadline.Value = String.Format("{0:yyyy-MM-dd}", task.Deadline);
                    inputDescription.Value = task.Description;
                    File.Value = task.Attachment;
                    id_task.Value = Request.Form["editDone"];
                    edit_cover.Visible = true;
                    btnsave.InnerText = "Edit";
                    Page_Load1(sender, e);
                }
                if (Request.Form["editLate"] != null)
                {
                    int editLate = Convert.ToInt32(Request.Form["editLate"]);
                    Task task = TaskBLL.GetTask(editLate);
                    inputName.Value = task.Name;
                    start_date.Value = String.Format("{0:yyyy-MM-dd}", task.StartDay);
                    deadline.Value = String.Format("{0:yyyy-MM-dd}", task.Deadline);
                    inputDescription.Value = task.Description;
                    File.Value = task.Attachment;
                    id_task.Value = Request.Form["editLate"];
                    edit_cover.Visible = true;
                    btnsave.InnerText = "Edit";
                    Page_Load1(sender, e);
                }
            }
            progress.InnerHtml = "";
            done.InnerHtml = "";
            late.InnerHtml = "";
            cmtbox.InnerHtml = "";
            List<Entity.Task> taskProgress = TaskBLL.GetTaskProgress();
            List<Entity.Task> taskDone = TaskBLL.GetTaskDone();
            List<Entity.Task> taskLate = TaskBLL.GetTaskLate();
            List<Entity.Comment> cmt = CommentBLL.GetAll();
            DataSourceTask = taskProgress.ToList();
            DataSourceTask = taskDone.ToList();
            DataSourceTask = taskLate.ToList();
            DataSourceCmt = cmt.ToList();
            DataBind();


            foreach (Entity.Comment comment in cmt)
                cmtbox.InnerHtml = cmtbox.InnerHtml +
                "<li>" +
                    "<div class=\"commenterImage\">" +
                        "<img src = \"https://image.freepik.com/free-vector/enthusiastic-concept-illustration_114360-3478.jpg\" />" +
                    "</div>" +
                    "<div class=\"commentText\">" +
                        "<p>" + comment.Description +"</p>" +
                        "<span class=\"date sub-text\">" + comment.Name + "</span>" +
                    "</div>" +
                "</li>";
            foreach (Entity.Task task_progress in taskProgress)
                progress.InnerHtml = progress.InnerHtml +

                    "<ul class=\"list-group list-group-flush\">" +
                        "<li class=\"card\" >" +
                                "<div class=\"card-body input-group\">" +
                                "<Button class='btn edit-task' id='btn_edit_task' runat='server' name='editInprogress' value=" + task_progress.ID + "><i class=\"fas fa-ellipsis-v\"></i></Button>" +
                                "<div class=\"form-control bd\">" +
                                    task_progress.Name +
                                 "</div>" +
                                    "<div class=\"input-group-append\">" +
                                        "<button name='btnInprogress' runat='server' value=" + task_progress.ID + " class=\"btn btn-change-status-inprogress\" type=\"submit\"><i class=\"fa fa-arrow-right\"></i></button>" +
                                    "</div>" +
                                "</div>" +
                            "</li>" +
                    "</ul>";

            foreach (Entity.Task task_done in taskDone)
                done.InnerHtml = done.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                          "<li class=\"card\">" +
                                "<div class=\"card-body input-group\">" +
                                
                                    "<div class=\"input-group-append\">" +
                                        "<button name='btnDone' runat='server' id='btn_edit_done' value=" + task_done.ID + " class=\"btn btn-change-status-done\" type=\"submit\"><i class=\"fa fa-arrow-left\"></i></button>" +
                                    "</div>" +
                                    "<div class=\"form-control bd\">" +
                                        task_done.Name +
                                    "</div>" +
                                    "<Button name='editDone' runat='server' id='btn_edit_done' value=" + task_done.ID + " class='btn edit-task '><i class=\"fas fa-ellipsis-v\"></i></Button>" +
                                "</div>" +
                            "</li>" +
                    "</ul>";


            foreach (Entity.Task task_late in taskLate)
                late.InnerHtml = late.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                        "<a name='editLate' id='btn_edit_late' runat='server' value=" + task_late.ID + " type='submit'>" +
                            "<li class=\"card\">" +
                                "<div class=\"card-body p-1\">" +
                                    "<div class=\"card-title m-0\">" +
                                        task_late.Name +
                                    "</div>" +
                                     "<Button name='editLate' runat='server' id='btn_edit_late' value=" + task_late.ID + " class='btn edit-task '><i class=\"fas fa-ellipsis-v\"></i></Button>" +
                                "</div>" +
                            "</li>" +
                        "</a>" +
                    "</ul>";
        }
        protected void Page_Load1(object sender, EventArgs e)
        {            
            progress.InnerHtml = "";
            done.InnerHtml = "";
            late.InnerHtml = "";
            cmtbox.InnerHtml = "";
            List<Entity.Task> taskProgress = TaskBLL.GetTaskProgress();
            List<Entity.Task> taskDone = TaskBLL.GetTaskDone();
            List<Entity.Task> taskLate = TaskBLL.GetTaskLate();
            DataSourceTask = taskProgress.ToList();
            DataSourceTask = taskDone.ToList();
            DataSourceTask = taskLate.ToList();
            List<Comment> cmt = CommentBLL.GetAll();
            DataSourceCmt = cmt.ToList();
            DataBind();
            foreach (Entity.Task task_progress in taskProgress)
                progress.InnerHtml = progress.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                        "<li class=\"card\">" +
                            "<div class=\"card-body input-group\">" +
                             "<div class=\"form-control bd\">" +
                                task_progress.Name +
                             "</div>" +
                                "<div class=\"input-group-append\">" +
                                    "<button name='btn' runat='server' value=" + task_progress.ID + " class=\"btn btn-change-status-inprogress\" type=\"submit\"><i class=\"fa fa-arrow-right\"></i></button>" +
                                "</div>" +
                            "</div>" +
                        "</li>" +
                    "</ul>";

            foreach (Entity.Task task_done in taskDone)
                done.InnerHtml = done.InnerHtml +
                    "<ul class=\"list-group list-group-flush\">" +
                        "<li class=\"card\">" +
                            "<div class=\"card-body input-group\">" +
                                "<div class=\"input-group-append\">" +
                                    "<button class=\"btn btn-change-status-done\" type=\"button\"><i class=\"fa fa-arrow-left\"></i></button>" +
                                "</div>" +
                                "<div class=\"form-control bd\">" +
                                    task_done.Name +
                                "</div>" +
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


            //edit_cover.Visible = false;
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


        protected void newtask_ServerClick(object sender, EventArgs e)
        {
            edit_cover.Visible = true;
            btnsave.InnerText = "ADD";

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            if (btnsave.InnerText == "ADD")
            {
               string a= (string)Session.Contents["Email"];
                Entity.Employee idemp = EmployeeBLL.GetIDbyEmail(a);
                Task task = new Task()
                {

                    Name = inputName.Value,
                    OwnerId = idemp.ID,
                    StartDay = Convert.ToDateTime(start_date.Value),
                    Deadline = Convert.ToDateTime(deadline.Value),
                    Description = inputDescription.Value,
                    Attachment = FileUpload1.FileName,
                    Visability = Visability.Value,
                    Status = "Chưa hoàn thành",
                };
                if (FileUpload1.HasFile)
                {
                    string fileName = FileUpload1.FileName;
                    string filePath = Server.MapPath(@"File\" + fileName);
                    FileUpload1.SaveAs(filePath);
                }
                TaskBLL.AddTask(task);
                Page_Load(sender, e);
            }//if(btnsave.InnerText == "EDIT")
            else 
            {
                int id = Convert.ToInt32(id_task.Value);
               Task t = TaskBLL.GetTask(id);
                if (FileUpload1.HasFile)
                {
                    string fileName = FileUpload1.FileName;
                    string filePath = Server.MapPath(@"File\" + fileName);
                    FileUpload1.SaveAs(filePath);
                    Task task = new Task()
                    {

                        Name = inputName.Value,
                        OwnerId = TaskBLL.GetTask(id).OwnerId,
                        StartDay = Convert.ToDateTime(start_date.Value),
                        Deadline = Convert.ToDateTime(deadline.Value),
                        Description = inputDescription.Value,
                        Attachment = FileUpload1.FileName,
                        Visability = Visability.Value,
                        Status = TaskBLL.GetTask(id).Status,
                        ID = id,
                    };

                    TaskBLL.EditTask(task);
                    Page_Load(sender, e);
                }
                else
                {
                    Task task = new Task()
                    {
                        Name = inputName.Value,
                        OwnerId = TaskBLL.GetTask(id).OwnerId,
                        StartDay = Convert.ToDateTime(start_date.Value),
                        Deadline = Convert.ToDateTime(deadline.Value),
                        Description = inputDescription.Value,
                        Attachment = FileUpload1.FileName,
                        Visability = Visability.Value,
                        Status = TaskBLL.GetTask(id).Status,
                        ID=t.ID,
                    };

                    TaskBLL.EditTask(task);
                    Page_Load(sender, e);
                }
                
            }

        }
        protected void backtask_ServerClick(object sender, EventArgs e)
        {
            edit_cover.Visible = false;
            Page_Load(sender, e);
        }

        protected void addcomment_ServerClick(object sender, EventArgs e)
        {
            string a = (string)Session.Contents["Email"];
            Entity.Employee idemp = EmployeeBLL.GetIDbyEmail(a);
            int i = Convert.ToInt32(id_task.Value);
            Comment comment = new Comment()
            {
                IdTask=i,
                IdEmployee=idemp.ID,
                Description=valuedescription.Value,
            };
            CommentBLL.AddComment(comment);
            Page_Load(sender, e);
        }

        //protected void hello(object sender, EventArgs e)
        //{
        //    html.InnerHtml = "byebye";
        //    //HtmlButton button = (HtmlButton)sender;
        //    //TaskBLL.ChangeStatusToDone(button.ID);
        //}

    }
}