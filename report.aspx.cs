using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_task
{
    public partial class report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                display();
            }
        }

         public void display()
        {
            Myclass m1 = new Myclass(); 
            m1.branch((string)Session["collegename"]);

            DDL1.DataSource = m1.dr;
            DDL1.DataTextField = "deptname";
            DDL1.DataBind();


            DDL1.Items.Insert(0, "Select Department");

            m1.dr.Close();
        }
        protected void Btnfindall_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            m1.complaintTable2((string)Session["collegename"]);

            GD1.DataSource = m1.dr;
            GD1.DataBind();

            m1.dr.Close();

            foreach (GridViewRow r1 in GD1.Rows)
            {

                m1.deptUser((string)Session["collegename"]);

                DropDownList ddl = (DropDownList)r1.FindControl("DDLresolve");

                ddl.DataSource = m1.dr;
                ddl.DataTextField = "username";
                ddl.DataBind();


                ddl.Items.Insert(0, "Select");

                m1.dr.Close();
            }

        }

        protected void Btnfind_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            m1.complaintTable3((string)Session["collegename"], DDL1.SelectedValue);

            GD1.DataSource = m1.dr;
            GD1.DataBind();

            m1.dr.Close();
            foreach (GridViewRow r1 in GD1.Rows)
            {

                m1.deptUser((string)Session["collegename"]);

                DropDownList ddl = (DropDownList)r1.FindControl("DDLresolve");

                ddl.DataSource = m1.dr;
                ddl.DataTextField = "username";
                ddl.DataBind();


                ddl.Items.Insert(0, "Select");

                m1.dr.Close();
            }

        }

       
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txtMsg = (TextBox)r1.FindControl("txtMsg");
            TextBox txtCT = (TextBox)r1.FindControl("txtCT2");
            DropDownList ddlstatus = (DropDownList)r1.FindControl("DDLStatus");
            DropDownList ddlDeptuser = (DropDownList)r1.FindControl("DDLresolve");

            Myclass m1 = new Myclass();
            m1.complaintUpdate(ddlDeptuser.SelectedValue, ddlstatus.SelectedValue, txtMsg.Text, txtCT.Text);

            Response.Write("<script language='JavaScript'>alert('Record Update Successfull');</script>");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txtMsg = (TextBox)r1.FindControl("txtMsg");
            TextBox txtCT = (TextBox)r1.FindControl("txtCT2");

            Myclass m1 = new Myclass();
            m1.complaintDelete(txtMsg.Text, txtCT.Text);

            Response.Write("<script language='JavaScript'>alert('Record Delete Successfull');</script>");
        }
    }
}