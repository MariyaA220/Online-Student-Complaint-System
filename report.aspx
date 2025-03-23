<%@ Page Title="" Language="C#" MasterPageFile="~/collegeadmin.Master" AutoEventWireup="true" CodeBehind="report.aspx.cs" Inherits="Final_task.report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
    <br />


<center><b>Select Department -</b><asp:DropDownList ID="DDL1" runat="server" Height="26px" Width="168px" CssClass="drop"></asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Btnfind" runat="server"  CssClass="button2"  Text="Find" OnClick="Btnfind_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Btnfindall" runat="server" Text="FIND ALL"   CssClass="button2" OnClick="Btnfindall_Click" />
    </center> 
    <br /><br />
    <asp:GridView ID="GD1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" >
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:TemplateField HeaderText="Sr.No">
                 <ItemTemplate>
    <%# Container.DataItemIndex + 1 %>
    </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="College Code">
                <ItemTemplate>
                    <asp:Label ID="lblCC" runat="server"  Text='<%#Eval("college") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                    <asp:TextBox ID="txtSN" runat="server" Text='<%#Eval("Studentname") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email Id">
                <ItemTemplate>
                    <asp:TextBox ID="txtEmail" runat="server" Text='<%#Eval("email") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Department">
                <ItemTemplate>
                    <asp:TextBox ID="txtDep" runat="server" Text='<%#Eval("branch") %>'></asp:TextBox>
                </ItemTemplate>
               
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Complain To">
                <ItemTemplate> 
                    <asp:TextBox ID="txtCT2" runat="server"  Text='<%#Eval("complaintto") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Message">
                <ItemTemplate>
                    <asp:TextBox ID="txtMsg" runat="server"  Text='<%#Eval("message") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Resolve By ">
                <ItemTemplate>
                    <asp:DropDownList ID="DDLresolve" runat="server" ></asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:DropDownList ID="DDLStatus" runat="server" >
                        <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>CLOSE</asp:ListItem>
                            <asp:ListItem>PENDING</asp:ListItem>
                            <asp:ListItem>FORWORD</asp:ListItem>
                    </asp:DropDownList>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update"  onclick="btnUpdate_Click"  />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate> 
                    <asp:Button ID="btnDelete" runat="server" Text="Delete"  onclick="btnDelete_Click"/>
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

</asp:Content>
