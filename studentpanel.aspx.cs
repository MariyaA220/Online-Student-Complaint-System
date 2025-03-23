using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_task
{
    public partial class studentpanel1 : System.Web.UI.Page
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
            string r = m1.news("JHULELAL INSTITUTE OF TECHNOLOGY");

            if (r == "")
            {
                Rep1.DataSource = m1.dr;
                Rep1.DataBind();

                m1.dr.Close();
            }
            else
            {
                Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
            }

        }

    }   


}