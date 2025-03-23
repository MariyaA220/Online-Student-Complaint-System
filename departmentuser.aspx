<%@ Page Title="" Language="C#" MasterPageFile="~/collegeadmin.Master" AutoEventWireup="true" CodeBehind="departmentuser.aspx.cs" Inherits="Final_task.departmentuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 40%;
            border-style: groove;
            border-color: inherit;
            border-width: 5px;
            margin-top: 30px;
            color:white;
            background-color:#0b121b;
            margin:auto;
           
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">


    <table class="auto-style1">
        <tr>
            <td  style="text-align:center">College Name</td>
            <td>
                <asp:TextBox ID="txtclg" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align:center">College Code</td>
            <td>
                <asp:TextBox ID="txtcode" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align:center">Depatmemt Name</td>
            <td>
                <asp:DropDownList ID="DDLdep" runat="server" Height="22px" Width="175px"></asp:DropDownList></td>
        </tr>
        <tr>
            <td style="text-align:center">Faculty Name </td>
            <td>
                <asp:TextBox ID="txtFaculty" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align:center">User Id</td>
            <td>
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align:center">Password</td>
            <td>
                <asp:TextBox ID="txtPass" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align:center">Date</td>
            <td>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT" BackColor="Lime" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="36px" OnClick="btnSubmit_Click" />
&nbsp;&nbsp;
                <asp:Button ID="btnShow" runat="server" Text="SHOW" BackColor="Lime" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="36px" OnClick="btnShow_Click" />
            </td>
        </tr>
       
    </table>

    <br /> 

    <center> <h3 style="color:#0b121b">Select DepartmenT Name - <asp:DropDownList ID="DDLdepartment" runat="server" Height="25px" Width="166px" CssClass="drop" OnSelectedIndexChanged="DDLdepartment_SelectedIndexChanged" Visible="false"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtFind" runat="server" Text="Find" CssClass="button2" Visible="false" />
        </h3></center>

    <br />
    <div style="margin-left:20px">
    <asp:GridView ID="Gvduser" runat="server" Width="836px" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <Columns>
            <asp:TemplateField HeaderText="Sr.No">
                <ItemTemplate>
                     <%# Container.DataItemIndex + 1 %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="College Name">
                <ItemTemplate>
                    <asp:TextBox ID="txtclgname1" runat="server" Text='<%#Eval("collegename") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Department">
               <ItemTemplate>
                   <asp:Label ID="lbldep" runat="server"  Text='<%#Eval("deptname") %>'></asp:Label>
               </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Faculity name">
                <ItemTemplate>
                    <asp:TextBox ID="txtfname" runat="server" Text='<%#Eval("username") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="UserId">
                <ItemTemplate>
                    <asp:TextBox ID="txtuserid" runat="server" Text='<%#Eval("userid") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Password">
                <ItemTemplate>
                    <asp:TextBox ID="txtpass" runat="server" Text='<%#Eval("password") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit"  OnClick="btnEdit_Click" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
               <ItemTemplate>
                   <asp:Button ID="btnDelt" runat="server" Text="Delete" ONCLICK="btnDelt_Click" />
               </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />

    </asp:GridView>
    
</div>

</asp:Content>
