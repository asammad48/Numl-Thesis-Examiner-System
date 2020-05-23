using BAL;
using PROPS;
using pwdHashSami;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Numl_Thesis_Examiner_System
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void login_Click(object sender, EventArgs e)
        {
            AuthPROPS ap = new AuthPROPS();
            ap.Email = email.Text;
            ap.Passowrd = new HashSami().GetHash(password.Text.Trim());
            DataTable dt=new AuthBAL().login(ap);
            if (dt.Rows.Count > 0)
            {
                int AccessLevel = (int)dt.Rows[0]["AccessLevel"];
                Session["Email"] = email;
                Session["PD_ID"] = dt.Rows[0]["U_ID"];
                Session["Name"] = dt.Rows[0]["Name"];
                Session["AccessLevel"] = AccessLevel;
                Session["deptid"] = dt.Rows[0]["Department_ID"];
                Session["dean"] = dt.Rows[0]["Dean"];
                Session["Campus"] = dt.Rows[0]["Campus"];
                if (AccessLevel == 1)
                {
                    Response.Redirect("Coordinator/dashboard.aspx");
                }
                else if (AccessLevel == 2)
                {
                    Response.Redirect("HOD/dashboard.aspx"); 
                }
                else if (AccessLevel == 3)
                {
                    Response.Redirect("DEAN/dashboard.aspx");
                }
                else if (AccessLevel == 4)
                {
                    Response.Redirect("Dir_Acad/dashboard.aspx");
                }
                else if (AccessLevel == 5)
                {
                    Response.Redirect("DG/dashboard.aspx");
                }
                else if (AccessLevel == 6)
                {
                    Response.Redirect("Rector/dashboard.aspx");
                }                
            }
            else
            {
                alert.Text = "Incorrect Email or Password";
                alert.Visible = true;
            }
        }
    }
}