using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_task
{
    public partial class studentpanel : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                display();
            }
        }


        protected void display()
        {
            Myclass m1 = new Myclass();
            string r = m1.stuInfo((string)Session["email"]);

            if (r == "")
            {
                lblClg.Text = Session["email"].ToString();

                Session["SN"] = m1.studentname;
                Session["branch"] = m1.branc;
                Session["CN"] = m1.clgname;
            }
            else
            {
                Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
            }


        }
    }
}