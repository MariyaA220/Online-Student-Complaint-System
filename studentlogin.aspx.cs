using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_task
{
    public partial class studentlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            string r = m1.SLogin(txtEmail.Text, txtPass.Text);

            if (r == "success")
            {
                Session["email"] = txtEmail.Text;
                Response.Redirect("studentpanel.aspx");
            }
            else
            {
                Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
            }

        }
    }
}