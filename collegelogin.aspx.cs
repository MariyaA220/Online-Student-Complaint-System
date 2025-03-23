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
    public partial class collegelogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Myclass m = new Myclass();
            string r = m.CLogin(txtCode.Text,txtPass.Text);

            if (r == "success")
            {
                Session["collegecode"] = txtCode.Text;
                Response.Redirect("collegeadmin.aspx");
            }
            else
            {
                Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
            }

        }
    }
}