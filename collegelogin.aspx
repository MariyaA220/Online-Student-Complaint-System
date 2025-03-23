<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="collegelogin.aspx.cs" Inherits="Final_task.collegelogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="StyleSheet2.css" rel="stylesheet" />
    <style>
        .login-box{
            height:350px;
           
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="login-box">
  <h2>Login</h2>
  
    <div class="user-box">
        <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
      <label>Enter College Code</label>
    </div>
    <div class="user-box">
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
      <label>Enter Password</label>
    </div>
           
 
             
    <a >
      <span>&nbsp;</span><asp:Button ID="btnLogin" runat="server" Text="LOGIN" BackColor="#03e9f4" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="40px" Width="107px"  OnClick="btnLogin_Click" />
       
        
    </a>
           <br />
           <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Underline="False" ForeColor="#03e9f4" PostBackUrl="~/collegereg.aspx">Not Register Yet ? Click Here..</asp:LinkButton>
  
&nbsp;</div>
           
    </form>
</body>
</html>
