<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeView.aspx.cs" Inherits="ToDoList.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 385px;
            height: 255px;
        }
        .auto-style3 {
            width: 88px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>EMPLOYEE</h1>
            <asp:Panel ID="Panel1" runat="server" Width="397px">
                <table class="auto-style1">
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
            <asp:Button ID="btnAdd" runat="server" Text="Thêm" />
            <asp:Button ID="btnEdit" runat="server" Text="Sửa" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Xóa" OnClick="btnDelete_Click" style="height: 26px" />
        </asp:Panel>
    </form>
</body>
</html>
