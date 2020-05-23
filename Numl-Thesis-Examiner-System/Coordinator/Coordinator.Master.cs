using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coordinator.Numl_Thesis_Examiner_System
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["email"] == null || Session["AccessLevel"].ToString() != "1")
            //{
            //    Response.Redirect("login.aspx");
            //}
            //else if (!IsPostBack)
            //{
            //    name.Text = Session["Name"].ToString();
            //    userid.Text = Session["U_ID"].ToString();
            //}
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //Session.Clear();
            //Session.Abandon();
            Server.Transfer("login.aspx");
        }
    }
}