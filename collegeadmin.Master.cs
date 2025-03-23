using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_task
{
    public partial class collegeadmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Master();
            }
        }

        protected void Master()
        {
            Myclass m1 = new Myclass();
            m1.Master((string)Session["collegecode"]);

            lblClg.Text = m1.clgname;
            Session["collegename"] = m1.clgname;

            m1.dr.Close();
        }
    }
}