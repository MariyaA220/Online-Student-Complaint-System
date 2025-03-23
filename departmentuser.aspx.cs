using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_task
{
    public partial class departmentuser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                view();
            }
        }
        protected void view()
        {
            txtcode.Text = Session["collegecode"].ToString();
            txtclg.Text = Session["collegename"].ToString();
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            Myclass m1 = new Myclass();
            m1.branch(txtclg.Text);

            DDLdep.DataSource = m1.dr;
            DDLdep.DataTextField = "deptname";
            DDLdep.DataBind();


            DDLdepartment.Items.Insert(0, "Select Department");


            m1.dr.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txtUid = (TextBox)r1.FindControl("txtuserid");
            TextBox txtPass = (TextBox)r1.FindControl("txtPass");
            TextBox txtFN = (TextBox)r1.FindControl("txtfname");

            Myclass m1= new Myclass();
            m1.deptUseredit(txtcode.Text, txtFN.Text, txtUid.Text, txtPass.Text);

            Response.Write("<script language='JavaScript'>alert('Updated Successfull');</script>");
        }

        protected void btnDelt_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txtUid = (TextBox)r1.FindControl("txtuserid");

            Myclass m1 = new Myclass();
            m1.deptUDelete(txtcode.Text, txtUid.Text);

            Response.Write("<script language='JavaScript'>alert('Delete Successfull');</script>");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();

            string r = m1.deptsubmit(txtclg.Text, txtcode.Text, txtFaculty.Text, txtUser.Text, txtPass.Text, DDLdep.SelectedValue, txtDate.Text);

            Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            m1.branch(txtclg.Text);

            DDLdepartment.DataSource = m1.dr;
            DDLdepartment.DataTextField = "deptname";
            DDLdepartment.DataBind();

            DDLdepartment.Items.Insert(0, "Select Department");

            DDLdepartment.Visible = true;

            m1.deptUserTable(txtcode.Text);

            Gvduser.DataSource = m1.dr;
            Gvduser.DataBind();

            m1.dr.Close();
        }

        protected void DDLdepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            m1.deptUserTable2(txtcode.Text, DDLdepartment.SelectedValue);

            Gvduser.DataSource = m1.dr;
            Gvduser.DataBind();

            m1.dr.Close();
        }
    }
}