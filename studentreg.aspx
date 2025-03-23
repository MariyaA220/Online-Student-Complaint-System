<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentreg.aspx.cs" Inherits="Final_task.studentreg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet2.css" rel="stylesheet" />
    <style>
         .login-box{
            height:700px;
            margin-top:10px;
           
        }
    </style>
   
</head>
<body>
    <form id="form1" runat="server">
         <div class="login-box">

  <h2>REGISTRATION</h2>
  
    <div>
        <asp:DropDownList ID="DDLclg" runat="server" CssClass="custom-dropdown" OnSelectedIndexChanged="DDLclg_SelectedIndexChanged"></asp:DropDownList>
     
        </div>
             <br />
       
             <div class="user-box">
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                 <label>
                  Student Name
                  </label>
    </div>

             <div>
        <asp:DropDownList ID="DDLbranch" runat="server" CssClass="custom-dropdown"></asp:DropDownList>
      
        </div>
    <br />
               <div class="user-box">
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                   <label>
                  Enter Email</label>
    </div>

          
               <div class="user-box">
        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                   <label>
                 Enter Mobile no</label>
    </div>

               <div class="user-box">
        <asp:TextBox ID="txtSem" runat="server"></asp:TextBox>
                   <label>
                  Semester</label>
    </div>
               <div class="user-box">
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                   <label>
                 Enter Password</label>

    </div>
       <div class="user-box">
           <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                   <label>
                 Date</label>
    </div>
          <a >        
      <asp:Button ID="btnSubmit" runat="server" Text="Submit" BackColor="#03E9F4" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="40px" Width="107px"  OnClick="btnSubmit_Click" /></a>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <a>  <asp:Button ID="btnlogin" runat="server" Text="Login" BackColor="#03E9F4" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="40px" Width="107px" onclick="btnRegister_Click" /></a>
        
   <br />
             <br />
              <br />
             <div>
             </div>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
  
          
  
&nbsp;</div>
    </form>
</body>
</html>
