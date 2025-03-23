<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="collegereg.aspx.cs" Inherits="Final_task.collegereg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="StyleSheet2.css" rel="stylesheet" />
        
    <script type="text/javascript">
        function validateForm() {
            var cname = document.getElementById('<%= txtCname.ClientID %>').value;
        var code = document.getElementById('<%= txtCode.ClientID %>').value;
        var email = document.getElementById('<%= txtEmail.ClientID %>').value;
        var principle = document.getElementById('<%= txtprinciple.ClientID %>').value;
        var mobile = document.getElementById('<%= txtMobile.ClientID %>').value;
        var password = document.getElementById('<%= txtPass.ClientID %>').value;

            // Check if any of the fields are empty
            if (cname.trim() === '' || code.trim() === '' || email.trim() === '' || principle.trim() === '' || mobile.trim() === '' || password.trim() === '') {
                alert('Please fill in all fields.');
                return false;
            }

            // Email validation
            var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            if (!emailRegex.test(email)) {
                alert('Please enter a valid email address.');
                return false;
            }

            // Mobile validation: Allow only numeric values and check length
            var mobileRegex = /^[0-9]+$/;
            if (!mobileRegex.test(mobile) || mobile.length !== 10) {
                alert('Please enter a valid 10-digit mobile number.');
                return false;
            }

            // Password validation: Check if it's not empty
            if (password.trim() === '') {
                alert('Please enter a password.');
                return false;
            }

            return true;
        }
    </script>



</head>
<body>
    <form id="form1" runat="server">
      <div class="login-box">

  <h2>REGISTRATION</h2>
  
    <div class="user-box">
        <asp:TextBox ID="txtCname" runat="server"></asp:TextBox>
      <label>
        
       Enter College Name</label>&nbsp;&nbsp;
        </div>
       
             <div class="user-box">
        <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
                 <label>
                  College Code
                  </label>
    </div>
    
               <div class="user-box">
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                   <label>
                  Enter Email</label>
    </div>

            <div class="user-box">
        <asp:TextBox ID="txtprinciple" runat="server"></asp:TextBox>
                   <label>
                  Enter Principle Name</label>
    </div>
               <div class="user-box">
        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                   <label>
                 Enter Mobile no</label>
    </div>
               <div class="user-box">
        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                   <label>
                 Enter Password</label>

    </div>
       <div class="user-box">
           <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                   <label>
                 Date</label>
    </div>
          <a >        
      <asp:Button ID="btnSubmit" runat="server" Text="Submit" BackColor="#03E9F4" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="40px" Width="107px" onclick="btnSubmit_Click"  OnClientClick="return validateForm();"/></a>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <a>  <asp:Button ID="btnRegister" runat="server" Text="Login" BackColor="#03E9F4" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="40px" Width="107px" onclick="btnRegister_Click" /></a>
        
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
