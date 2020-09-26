<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeView.aspx.cs" Inherits="ToDoList.Employee"  MasterPageFile="~/GUI/Site.Master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
     <script>
         $(document).ready(function () {
             $('#example').DataTable();
         });
         alert("hello");
     </script>
    
    
        <div>
            <h1>EMPLOYEE</h1>
            <asp:Panel ID="Panel1" runat="server" Width="397px">


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
                        </td>
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




                  <table runat="server" id="example" class="table table-striped table-bordered" style="width:100%">
                     <thead>
                    <tr>
                      <th class="th-sm">ID
                      </th>
                      <th class="th-sm">Email
                      </th>
                      <th class="th-sm">PassWord
                      </th>
                      <th class="th-sm">Name
                      </th>
                      <th class="th-sm">DateOfBirth
                      </th>
                      <th class="th-sm">PhoneNumber
                      </th>
                        <th class="th-sm">Position
                      </th>
                        <th class="th-sm">Level
                      </th>
                    </tr>
                  </thead>
                  <tbody>
   
  
                    <tr>
                      <td>Suki Burks</td>
                      <td>Developer</td>
                      <td>London</td>
                      <td>53</td>
                      <td>2009/10/22</td>
                      <td>$114,500</td>
                    </tr>
                    <tr>
                      <td>Prescott Bartlett</td>
                      <td>Technical Author</td>
                      <td>London</td>
                      <td>27</td>
                      <td>2011/05/07</td>
                      <td>$145,000</td>
                    </tr>
                    <tr>
                      <td>Gavin Cortez</td>
                      <td>Team Leader</td>
                      <td>San Francisco</td>
                      <td>22</td>
                      <td>2008/10/26</td>
                      <td>$235,500</td>
                    </tr>
                    <tr>
                      <td>Martena Mccray</td>
                      <td>Post-Sales support</td>
                      <td>Edinburgh</td>
                      <td>46</td>
                      <td>2011/03/09</td>
                      <td>$324,050</td>
                    </tr>
                    <tr>
                      <td>Unity Butler</td>
                      <td>Marketing Designer</td>
                      <td>San Francisco</td>
                      <td>47</td>
                      <td>2009/12/09</td>
                      <td>$85,675</td>
                    </tr>
                    <tr>
                      <td>Howard Hatfield</td>
                      <td>Office Manager</td>
                      <td>San Francisco</td>
                      <td>51</td>
                      <td>2008/12/16</td>
                      <td>$164,500</td>
                    </tr>
                    <tr>
                      <td>Hope Fuentes</td>
                      <td>Secretary</td>
                      <td>San Francisco</td>
                      <td>41</td>
                      <td>2010/02/12</td>
                      <td>$109,850</td>
                    </tr>
  
  
                    <tr>
                      <td>Michael Bruce</td>
                      <td>Javascript Developer</td>
                      <td>Singapore</td>
                      <td>29</td>
                      <td>2011/06/27</td>
                      <td>$183,000</td>
                    </tr>
                    <tr>
                      <td>Donna Snider</td>
                      <td>Customer Support</td>
                      <td>New York</td>
                      <td>27</td>
                      <td>2011/01/25</td>
                      <td>$112,000</td>
                    </tr>
                  </tbody>
                </table>



            </asp:Panel>

        </div>
        <asp:Panel ID="Panel2" runat="server" Width="397px">
            <asp:GridView ID="tblEmployee" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
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

    </asp:Content>