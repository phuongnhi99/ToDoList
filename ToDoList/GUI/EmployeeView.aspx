<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeView.aspx.cs" Inherits="ToDoList.Employee"  MasterPageFile="~/GUI/Site.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="content-cover">
    <div class="container">
            <h1>EMPLOYEE</h1>
            <asp:Panel ID="Panel1" runat="server" Width="100%">
            <table id="paginationSimpleNumbers" class="table" width="100%">
                        <thead>
                            <tr>
                                <th class="th-sm">
                                    ID
                                </th>
                                <th class="th-sm">
                                    Name
                                </th>
                                <th class="th-sm">
                                    Mail
                                </th>
                                <th class="th-sm">
                                    Phone Number
                                </th>
                                <th class="th-sm">
                                    Birthday
                                </th>
                                <th class="th-sm">
                                    Position
                                </th>
                                <th class="th-lg">
                                </th>
                            </tr>
                        </thead>
                        <tbody id="abc" runat="server">
                        </tbody>
                    </table>

    

                  <table id="example1" class="table table-striped table-bordered" style="width:100%">
                    <tr>
                        <td class="auto-style3">ID</td>
                        <td>
                            <asp:TextBox ID="txtID" runat="server" Width="295px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Email</td>
                        <td>
                            <asp:TextBox ID="txtEmail" runat="server" Width="296px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">PassWord</td>
                        <td>
                            <asp:TextBox ID="txtPassWord" runat="server" Width="296px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Name</td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server" Width="296px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">DateOfBirth</td>
                        <td>
                            <asp:TextBox ID="txtDateOfBirth" runat="server" Width="296px"></asp:TextBox>
                        </td>s
                    </tr>
                    <tr>
                        <td class="auto-style3">PhoneNumber</td>
                        <td>
                            <asp:TextBox ID="txtPhoneNumber" runat="server" Width="296px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Position</td>
                        <td>
                            <asp:TextBox ID="txtPosition" runat="server" Width="295px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">Level</td>
                        <td>
                            <asp:TextBox ID="txtLevel" runat="server" Width="297px"></asp:TextBox>
                        </td>
                    </tr>
                </table>


            </asp:Panel>

        

        <asp:Panel ID="Panel2" runat="server" Width="397px">
            <asp:GridView ID="tblEmployee" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" AutoGenerateSelectButton="True">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:ButtonField ButtonType="Button" Text="Button" />
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" Height="83px">
            <asp:Button ID="btnAdd" runat="server" Text="Thêm" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Sửa" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Xóa" OnClick="btnDelete_Click" style="height: 26px" />
        </asp:Panel>
</div>
</div>

    <div class="edit-cover">    
        <div class="edit-content">
            <form>
                <div class="close"><i class="fa fa-arrow-left lg"></i></div>
                 <div class="form-row ">
                    <div class="form-group col-md-6">
                        <label for="inputEmail4">Name</label>
                        <input type="text" class="form-control" id="username" placeholder="Full name">
                        <label class="valid-feedback"></label>
                    </div>
                      <div class="form-group col-md-6">
                        <label for="inputEmail4">Email</label>
                        <input type="email" class="form-control" id="inputEmail4" placeholder="Email">
                        <label class="valid-feedback"></label>
                    </div>
                 </div>
                <div class="form-group row">
                    <div class="col-6">
                        <label for="password" class="col-2 col-form-label">Password</label>
                        <input class="form-control" type="password" id="password">
                        <label class="valid-feedback"></label>
                    </div>
                    <div class="col-6">
                        <label for="example-date-input" class="col-2 col-form-label">Confirm Password</label>
                        <input class="form-control" type="password" id="confirm_password">
                        <label class="valid-feedback"></label>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-4">
                        <label for="phonenumber" class="col-form-label">Phone Number</label>
                        <input class="form-control" type="text" id="phone_number">
                        <label class="valid-feedback"></label>
                    </div>
                    <div class="col-4">
                        <label for="example-date-input" class="col-2 col-form-label">Birthday</label>
                        <input class="form-control" type="date" id="birthday">
                    </div>
                    <div class="col-4">
                        <label for="position" class="col-2 col-form-label">Position</label>
                        <input class="form-control" type="date" id="position">
                    </div>
                </div>
                <button type="submit" class="btn btn-primary">Add</button>
            </form>
        </div>
    </div>
    </asp:Content>