
<%@ Page Title="" Language="C#" MasterPageFile="~/studentpanel.Master" AutoEventWireup="true" CodeBehind="studentcomplain.aspx.cs" Inherits="Final_task.studentcomplain" %>
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
            <td>College Name</td>
            <td>
                <asp:TextBox ID="txtCname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Student Name</td>
            <td>
                <asp:TextBox ID="txtSname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Branch</td>
            <td>
                <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Complain To</td>
            <td>
                <asp:DropDownList ID="DDLComplain" runat="server" Height="20px" Width="155px">
                    <asp:listitem>Select</asp:listitem>
                 <asp:ListItem>ACCOUNT</asp:ListItem>
                 <asp:ListItem>EXAM</asp:ListItem>
                 <asp:ListItem>SPORT</asp:ListItem>
                 <asp:ListItem>ADMISSION</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Message</td>
            <td>
                <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Date</td>
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
                <asp:Button ID="btnsubmit" runat="server" BackColor="Lime" ForeColor="White" Text="Submit" OnClick="btnsubmit_Click" Height="39px" Width="71px" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnShow" runat="server" BackColor="#66FF33" ForeColor="White" Text="Show" Width="71px" OnClick="btnShow_Click" Height="37px" />
            </td>
        </tr>
    </table>



    <br />
    <div   style="margin-left:10px">
        <asp:GridView ID="GV1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:TemplateField HeaderText="SR.NO">
                    <ItemTemplate>
    <%# Container.DataItemIndex + 1 %>
    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="COLLEGE">
                    <ItemTemplate>
                        <asp:TextBox ID="txtclg" runat="server"  Text='<%#Eval("college") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NAME">
                    <ItemTemplate>
                        <asp:TextBox ID="txtsname" runat="server"  Text='<%#Eval("studentname") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BRANCH">
                    <ItemTemplate>
                        <asp:TextBox ID="txtbranch" runat="server"  Text='<%#Eval("branch") %>' Width="35px"></asp:TextBox>
                    </ItemTemplate> 
                </asp:TemplateField>
                <asp:TemplateField HeaderText="COMPLAIN TO ">
                    <ItemTemplate>
                        <asp:TextBox ID="txtcomplainto" runat="server" Text='<%#Eval("complaintto") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="MESSAGE">
                    <ItemTemplate>
                        <asp:TextBox ID="txtmsg" runat="server" Text='<%#Eval("message") %>' Width="35px"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DATE">
                    <ItemTemplate>
                        <asp:TextBox ID="txtdate" runat="server"  Text='<%#Eval("date") %>' Width="45px"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ACTION">
                    <ItemTemplate>
                        <asp:Button ID="btndelete" runat="server" Text="delete"  OnClick="btndelete_Click" BackColor="red" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        </asp:GridView>
    </div>
   


</asp:Content>
