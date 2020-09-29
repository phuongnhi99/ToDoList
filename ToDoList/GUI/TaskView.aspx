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
                                <div class="card-body input-group">
                                    <div class="form-control bd">Special title treatment</div>
                                    <div class="input-group-append">
                                        <button class="btn btn-change-status-inprogress" type="button"><i class="fa fa-arrow-right"></i></button>
                                    </div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body input-group">
                                    <div class="form-control bd">Special title treatment</div>
                                    <div class="input-group-append">
                                        <button class="btn btn-change-status-inprogress" type="button"><i class="fa fa-arrow-right"></i></button>
                                    </div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body input-group">
                                    <div class="form-control bd">Special title treatment</div>
                                    <div class="input-group-append">
                                        <button class="btn btn-change-status-inprogress" type="button"><i class="fa fa-arrow-right"></i></button>
                                    </div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body input-group">
                                    <div class="form-control bd">Special title treatment</div>
                                    <div class="input-group-append">
                                        <button class="btn btn-change-status-inprogress" type="button"><i class="fa fa-arrow-right"></i></button>
                                    </div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body input-group">
                                    <div class="form-control bd">Special title treatment</div>
                                    <div class="input-group-append">
                                        <button class="btn btn-change-status-inprogress" type="button"><i class="fa fa-arrow-right"></i></button>
                                    </div>
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
                    <div class="card-body">
                        <ul class="list-group list-group-flush">
                            <li class="card">
                                <div class="card-body input-group">
                                    <div class="input-group-append">
                                        <button class="btn btn-change-status-done" type="button"><i class="fa fa-arrow-left"></i></button>
                                    </div>
                                    <div class="form-control bd">Special title treatment</div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body input-group">
                                    <div class="input-group-append">
                                        <button class="btn btn-change-status-done" type="button"><i class="fa fa-arrow-left"></i></button>
                                    </div>
                                    <div class="form-control bd">Special title treatment</div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body input-group">
                                    <div class="input-group-append">
                                        <button class="btn btn-change-status-done" type="button"><i class="fa fa-arrow-left"></i></button>
                                    </div>
                                    <div class="form-control bd">Special title treatment</div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body input-group">
                                    <div class="input-group-append">
                                        <button class="btn btn-change-status-done" type="button"><i class="fa fa-arrow-left"></i></button>
                                    </div>
                                    <div class="form-control bd">Special title treatment</div>
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
                    <div class="card-body">
                        <ul class="list-group list-group-flush">
                            <li class="card">
                                <div class="card-body p-1">
                                    <div class="card-title m-0">Special title treatment</div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body p-1">
                                    <div class="card-title m-0">Special title treatment</div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body p-1">
                                    <div class="card-title m-0">Special title treatment</div>
                                </div>
                            </li>
                            <li class="card">
                                <div class="card-body p-1">
                                    <div class="card-title m-0">Special title treatment</div>
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



    <div class="edit-cover" id="edit_cover" runat="server">
       
        <div class="edit-content" runat="server">
            <form>
                <button class="close" runat="server" onserverclick="btnClose_Clicks"><i class="fas fa-times"></i></button>
                <h4>EMPLOYEE</h4>
                 <div class="form-row ">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4">Name</label>
                        <input type="email" class="form-control" id="inputEmail4" placeholder="Email">
                    </div>
                      <div class="form-group col-md-6">
                        <label for="inputEmail4">Description</label>
                        <input type="email" class="form-control" id="inputEmail4" placeholder="Email">
                    </div>
                 </div>
                <div class="form-group row">
                    
                    <div class="col-6">
                        <label for="example-date-input" class="col-2 col-form-label">Start Day</label>
                        <input class="form-control" type="date" value="2011-08-19" id="example-date-input">
                    </div>
                    <div class="col-6">
                        <label for="example-date-input" class="col-2 col-form-label">Đeadline</label>
                        <input class="form-control" type="date" value="2011-08-19" id="example-date-input">
                    </div>
                </div>
     
        <div class="form-row ">
                   
                </div>
                <div class="form-row">
                    <div class="form-group col-md-4">
                        <label for="inputCity">Partner</label>
                        <select id="inputState" class="form-control" multiple>
                            <option selected>Choose...</option>
                            <option>...</option>
                        </select>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="inputState">Status</label>
                        <select id="inputState" class="form-control">
                            <option selected>Choose...</option>
                            <option>...</option>
                        </select>
                    </div>
                    <div class="form-group col-md-4">
                        <label for="inputZip">Visability</label>
                        <select id="inputState" class="form-control">
                            <option selected>Choose...</option>
                            <option>...</option>
                        </select>
                    </div>
                </div>
                <div class="form-group">
                    <label for="exampleInputFile">File input</label>
                    <input type="file" class="form-control-file" id="exampleInputFile" aria-describedby="fileHelp">
                    <small id="fileHelp" class="form-text text-muted">This is some placeholder block-level help text for the above input. It's a bit lighter and easily wraps to a new line.</small>
                </div>
                <button type="submit" class="btn btn-primary">Sign in</button>
            </form>
        </div>
         <div class="blur-bg"</div>
    </div>
</asp:Content>
