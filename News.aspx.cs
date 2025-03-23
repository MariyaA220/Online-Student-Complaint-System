using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_task
{
    public partial class News : System.Web.UI.Page
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

            lblClg.Text = Session["collegecode"].ToString();
            lblCname.Text = Session["collegename"].ToString();
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
            string r = m1.newsSave(lblClg.Text, lblCname.Text, txtNews.Text, txtMsg.Text, txtDate.Text);
            Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
        }

        protected void btnshow_Click(object sender, EventArgs e)
        {
            Myclass m1 = new Myclass();
          
            m1.newsTable(lblClg.Text);

            GridView1.DataSource = m1.dr;
            GridView1.DataBind();

            m1.dr.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {   

            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txttitle = (TextBox)r1.FindControl("txttile");

            Myclass m1 = new Myclass();
            m1.newsDelete(lblClg.Text, txttitle.Text);

            Response.Write("<script language='JavaScript'>alert('Delete Successfull');</script>");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txttitle = (TextBox)r1.FindControl("txttile");
            TextBox txtmsg = (TextBox)r1.FindControl("txtmsg");
            Myclass m1 = new Myclass();
            m1.newsUpdate(lblClg.Text, txttitle.Text, txtmsg.Text);

            Response.Write("<script language='JavaScript'>alert('Edit Successfull');</script>");
        }

        protected void btnsubmit2_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;

            TextBox txttitle = (TextBox)r1.FindControl("txttitle2");
            TextBox txtmsg = (TextBox)r1.FindControl("txtMsg2");

            Myclass m1 = new Myclass();
            string r = m1.newsSave(lblClg.Text, lblCname.Text, txttitle.Text, txtmsg.Text, txtDate.Text);
            Response.Write("<script language='JavaScript'>alert('" + r + "');</script>");
        }
    }
}