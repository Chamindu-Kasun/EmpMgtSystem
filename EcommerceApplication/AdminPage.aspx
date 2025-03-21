<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="EcommerceApplication.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 20px;
        }

        form{
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .container {
            width: 80%
        }

        .titleSection{
            display: flex;
            align-items: center;
            justify-content: space-between;
            width: 100%
        }

        .btnSection{
            display: flex;
            align-items:center;
            justify-content:space-around;
            flex-wrap:wrap;
            margin-top: 50px;
            width: 100%
        }

        .viewEmployees{
            height: 100px;
            width: 200px;
            cursor:pointer;
            background-color:brown;
        }

        .addNewEmployee{
            height: 100px;
            width: 200px;
            cursor:pointer;
            background-color:burlywood;
        }

        .viewLeaveRequests{
            height: 100px;
            width: 200px;
            cursor:pointer;
            background-color:cadetblue;
        }

        .viewAdmins{
            height: 100px;
            width: 200px;
            cursor:pointer;
            background-color:darkgoldenrod;
        }

        .addNewAdmin{
            height: 100px;
            width: 200px;
            cursor:pointer;
            background-color:darkslateblue;
        }

        .employeesDataSection{
            display: flex;
            align-items:center;
            justify-content:center;
            width: 100%;
            margin-top: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="titleSection">
                <h2>Admin Dashboard</h2>
                <div class="logout">
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
                </div>
            </div>
            <div class="btnSection">
                <asp:Button ID="btnViewEmployees" runat="server" Text="View Employees" CssClass="viewEmployees" OnClick="btnViewEmployees_Click"/>
                <asp:Button ID="btnAddNewEmployee" runat="server" Text="Add New Employee" CssClass="addNewEmployee"/>
                <asp:Button ID="btnViewLeaveRequests" runat="server" Text="View Leave Requests" CssClass="viewLeaveRequests"/>
                <asp:Button ID="btnViewAdmins" runat="server" Text="View Admins" CssClass="viewAdmins"/>
                <asp:Button ID="btnAddNewAdmin" runat="server" Text="Add New Admin" CssClass="addNewAdmin"/>
            </div>
            <div class="employeesDataSection">
                <asp:GridView ID="gvEmployees" runat="server" AutoGenerateColumns="False" CssClass="usersTable" BorderWidth="1px" CellPadding="5" GridLines="Both">
                    <Columns>
                        <asp:BoundField DataField="Username" HeaderText="Username" />
                        <asp:BoundField DataField="Role" HeaderText="Role" />
                        <asp:BoundField DataField="Department" HeaderText="Department" />
                        <asp:BoundField DataField="ContactNumber" HeaderText="Contact Number" />
                        <asp:BoundField DataField="Qualifications" HeaderText="Qualifications" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
