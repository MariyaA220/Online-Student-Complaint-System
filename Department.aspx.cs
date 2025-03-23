using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_task
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {   
                btnDlt.Visible=false;
                display();
            }
        }



        protected void display()
        {

            txtCode.Text = Session["collegecode"].ToString();
            txtCname.Text = Session["collegename"].ToString();

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            m1.deptTable(txtCode.Text);

            GVDEP.DataSource = m1.dr;
            GVDEP.DataBind();

            m1.dr.Close();

            btnDlt.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            string r = m1.deptment(txtCname.Text, txtCode.Text, txtDep.Text);

            Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
        }

        protected void btnDlt_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r1 in GVDEP.Rows)
            {
                CheckBox c = (CheckBox)r1.FindControl("CBAction");
                Label lblDept = (Label)r1.FindControl("lbldep");

                if (c.Checked)
                {
                   Myclass m1 = new Myclass();
                    m1.deptDelete(txtCode.Text, lblDept.Text);

                }

            }

            Response.Write("<script language='JavaScript'>alert('Department Delete Successfully');</script>");

        }
    }
}