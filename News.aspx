
<%@ Page Title="" Language="C#" MasterPageFile="~/collegeadmin.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Final_task.News" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            margin:auto; 
            border:5px groove; 
            color:white;
             background-color:#0b121b;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">

    <br />
    <table class="auto-style1">
        <tr>
            <td style="text-align:center">College Code</td>
            <td>
                <asp:Label ID="lblClg" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td style="text-align:center">College Name</td>
            <td>
                <asp:Label ID="lblCname" runat="server" Text="Label"></asp:Label></td>
        </tr>
        <tr>
            <td style="text-align:center">News Title</td>
            <td>
                <asp:TextBox ID="txtNews" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align:center">Message</td>
            <td>
                <asp:TextBox ID="txtMsg" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="text-align:center">Date</td>
            <td>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnsubmit" runat="server" Height="30px" Text="Submit" Width="80px" BackColor="Lime" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="btnsubmit_Click" />
&nbsp;&nbsp;
                <asp:Button ID="btnshow" runat="server" Height="30px" Text="Show" Width="71px" BackColor="Lime" Font-Bold="True" Font-Size="Medium" ForeColor="White" OnClick="btnshow_Click" />
            </td>
        </tr>
    </table>

    <br />
    <br />
    <div  style="margin-left:20px">
    <asp:GridView ID="GridView1" runat="server" Width="519px" AutoGenerateColumns="False" ShowFooter="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
        <Columns>
            <asp:TemplateField HeaderText="Srno">
                <ItemTemplate>
     <%# Container.DataItemIndex + 1 %>
     </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="College Code">
                <ItemTemplate>
                    <asp:TextBox ID="txtCC" runat="server" Text='<%#Eval("collegecode") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:TextBox ID="txtName" runat="server"  Text='<%#Eval("collegename") %>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Title">
                <ItemTemplate>
                    <asp:TextBox ID="txttile" runat="server" Text='<%#Eval("newstitle") %>'></asp:TextBox>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txttitle2" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Message">
                <ItemTemplate>
                    <asp:TextBox ID="txtmsg" runat="server" Text='<%#Eval("message") %>'></asp:TextBox>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtmsg2" runat="server"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Action ">
                <ItemTemplate>
                    <asp:Button ID="btnEdit" runat="server" Text="Edit"  OnClick="btnEdit_Click" BackColor="Goldenrod"/>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="btnsubmit2" runat="server" Text="Submit"  OnClick="btnsubmit2_Click" BackColor="YellowGreen"/>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Action">
               <ItemTemplate>
                   <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" BackColor="red" />
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
