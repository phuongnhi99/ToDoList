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
                        <h5 id="html" runat="server" class="card-title">IN PROGRESS</h5>
                    </div>
                    <div id="progress" runat="server" class="card-body">                        
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
                    </div>
                    <div class="card-footer">
                    </div>
                </div>

                <div class="col card late ">
                    <div class="card-header">
                        <h5 class="card-title">LATE</h5>
                    </div>
                    <div id="late" runat="server" class="card-body">
                    </div>
                    <div class="card-footer">
                    </div>
                </div>
            </div>

        </div>
    </div>


    <div id="edit_cover" runat="server">
        <div class="edit-cover">
            <form>
                <div class="edit-content card" runat="server">
                    <div class="card-header">
                        <button class="close" runat="server" onserverclick="btnClose_Clicks"><i class="fas fa-times"></i></button>
                        <h4>TASK</h4>
                    </div>
                    <div class="card-body" style="overflow: auto">
                        <div class="row">
                            <div class="col">
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
                                        <label for="example-date-input" class="col-6 col-form-label">Start Day</label>
                                        <input class="form-control" type="date" value="2011-08-19" id="example-date-input">
                                    </div>
                                    <div class="col-6">
                                        <label for="example-date-input" class="col-6 col-form-label">Deadline</label>
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
                                <button type="submit" class="btn btn-primary">edit</button>
                                <button type="submit" class="btn btn-primary">back</button>
                            </div>





                            <div class="col">
                                <div class="detailBox">
                                    <div class="titleBox">
                                        <label>Comment Box</label>
                                        <button type="button" class="close" aria-hidden="true">&times;</button>
                                    </div>
                                    <div class="commentBox">

                                        <p class="taskDescription">Lorem Ipsum is simply dummy text of the printing and typesetting industry.</p>
                                    </div>
                                    <div class="actionBox">
                                        <ul class="commentList">
                                            <li>
                                                <div class="commenterImage">
                                                    <img src="http://placekitten.com/50/50" />
                                                </div>
                                                <div class="commentText">
                                                    <p class="">Hello this is a test comment.</p>
                                                    <span class="date sub-text">on March 5th, 2014</span>

                                                </div>
                                            </li>
                                            <li>
                                                <div class="commenterImage">
                                                    <img src="http://placekitten.com/45/45" />
                                                </div>
                                                <div class="commentText">
                                                    <p class="">Hello this is a test comment and this comment is particularly very long and it goes on and on and on.</p>
                                                    <span class="date sub-text">on March 5th, 2014</span>

                                                </div>
                                            </li>
                                            <li>
                                                <div class="commenterImage">
                                                    <img src="http://placekitten.com/40/40" />
                                                </div>
                                                <div class="commentText">
                                                    <p class="">Hello this is a test comment.</p>
                                                    <span class="date sub-text">on March 5th, 2014</span>

                                                </div>
                                            </li>
                                        </ul>
                                        <form class="form-group" role="form">
                                            <div class="input-group mb-3">
                                                <input type="text" class="form-control" placeholder="Recipient's username" aria-label="Recipient's username" aria-describedby="basic-addon2">
                                                
                                                    <button class="btn btn-outline-secondary" type="button">Button</button>
                                                
                                            </div>
                                        </form>
                                    </div>
                                </div>
                            </div>


                        </div>
                    </div>

                    <div class="card-footer">hello</div>
                </div>
            </form>

        </div>
                

         <div class="blur-bg"</div>
    </div>
</asp:Content>
