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


    public partial class studentreg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                clg();
            }
        }

        protected void clg()
        {
            Myclass m1 = new Myclass();
            m1.clg();

            DDLclg.DataSource = m1.dr;
            DDLclg.DataTextField = "collegename";
            DDLclg.DataBind();

            DDLclg.Items.Insert(0, "Select College");
            DDLbranch.Items.Insert(0, "Select Branch");

            m1.dr.Close();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            string r = m1.stuSave(DDLclg.SelectedValue,txtName.Text,DDLbranch.SelectedValue,txtEmail.Text,txtMobile.Text,txtPass.Text,txtDate.Text,txtSem.Text);

            Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentlogin.aspx");
        }

        protected void DDLclg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            m1.branch(DDLclg.SelectedValue);

            DDLbranch.DataSource = m1.dr;
            DDLbranch.DataTextField = "deptname";
            DDLbranch.DataBind();
           DDLbranch.Items.Insert(0, "Select Branch");
            m1.dr.Close();
        }
    }
}