using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Final_task
{
    public partial class collegereg : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            // page refreshment
            if (!IsPostBack)
            {
                // Set current date to txtDate
                txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            string r= m1.Insertclg(txtCname.Text, txtCode.Text, txtEmail.Text, txtprinciple.Text, txtMobile.Text, txtPass.Text, txtDate.Text);
            //Response.Write(m1.msg);
            Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("collegelogin.aspx");
        }
    }
}