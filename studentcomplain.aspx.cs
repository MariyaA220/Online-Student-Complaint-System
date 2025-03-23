using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_task
{
    public partial class studentcomplain : System.Web.UI.Page
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
            txtSname.Text = Session["SN"].ToString();
            txtCname.Text = Session["CN"].ToString();
            txtBranch.Text = Session["branch"].ToString();
            txtEmail.Text = Session["email"].ToString();
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
              GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txtMsg = (TextBox)r1.FindControl("txtmsg");
            TextBox txtCT = (TextBox)r1.FindControl("txtcomplainto");

            Myclass m1 = new Myclass();
           string  r = m1.complaintDelete(txtMsg.Text,txtCT.Text);
            if (r == "")
            {
                Response.Write("<script language='JavaScript'>alert('Delete Successfull');</script>");

            }
            else
            {
                Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Desktop\projects\WebApplication1\WebApplication1\App_Data\complaintdb.mdf;Integrated Security=True";
            con = new SqlConnection(path);
            con.Open();

            Myclass m1 = new Myclass();
            string r = m1.complaintSave(txtCname.Text, txtSname.Text, txtEmail.Text, txtBranch.Text, DDLComplain.SelectedValue, txtMessage.Text, txtDate.Text);

            Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            string r = m1.complaintTable(txtEmail.Text);
            if (r == "")
            {
                GV1.DataSource = m1.dr;
                GV1.DataBind();

                m1.dr.Close();
            }
            else
            {
                Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
            }
        }
    }
}