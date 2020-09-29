<%@ Page Title="" Language="C#" MasterPageFile="~/GUI/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="TaskView.aspx.cs" Inherits="ToDoList.GUI.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-cover">
        <div class="container">
            <div class="row d-flex justify-content-end m-1">
                <button type="button" class="btn btn-dark p-2 cal-btn"><i class="fa fa-calendar"></i>TODAY</button>
                <button type="button" class="btn btn-dark p-2 cal-btn"><i class="fa fa-calendar"></i>THIS WEEK</button>
            </div>

            <div class="row">
                <div class="col card inprogress ">
                    <div class="card-header">
                        <h5 class="card-title">IN PROGRESS</h5>
                    </div>
                    <div id="progress" runat="server" class="card-body">
                        <ul class="list-group list-group-flush">
                            <li class="card">
                                <div class="card-body p-1">
                                    <div class="card-title m-0"></div>
                                    <button class="btn p-1 float-md-right status-progress-btn"><i class="fa fa-arrow-right"></i></button>
                                </div>
                            </li>                  
                        </ul>
                    </div>
                    <div class="card-footer">
                        <button class="btn add-btn"><i class="fa fa-plus"></i>ADD NEW TASK</button>
                    </div>
                </div>

                <div class="col card done ">
                    <div class="card-header">
                        <h5 class="card-title">DONE</h5>
                    </div>
                    <div id="done" runat="server" class="card-body">
                        <ul class="list-group list-group-flush">
                            <li class="card">
                                <div class="card-body p-1">
                                    <div class="card-title m-0"></div>
                                    <button class="btn p-1 status-done-btn"><i class="fa fa-arrow-left"></i></button>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class="card-footer">
                    </div>
                </div>

                <div class="col card late ">
                    <div class="card-header">
                        <h5 class="card-title">LATE</h5>
                    </div>
                    <div id="late" runat="server" class="card-body">
                        <ul class="list-group list-group-flush">
                            <li class="card">
                                <div class="card-body p-1">
                                    <div class="card-title m-0"></div>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class="card-footer">
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
