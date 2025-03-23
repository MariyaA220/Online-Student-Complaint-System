<%@ Page Title="" Language="C#" MasterPageFile="~/studentpanel.Master" AutoEventWireup="true" CodeBehind="studentpanel.aspx.cs" Inherits="Final_task.studentpanel1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplaceholder1" runat="server">
    <div style="width : 1300px; height: 470px">
        <div style=" margin-top:180px; margin-left:700px;font-size:25px; width:500px; color:#0b121b;">
            
            <asp:Repeater ID="Rep1" runat="server">
                <itemtemplate>
                     <div class="marquee-container">
            <marquee direction="up" scrollamount="2" class="marquee-text"><%# Eval("message") %></marquee>
                </itemtemplate>
            </asp:Repeater>
            
            </div>
       </div>
</asp:Content>
