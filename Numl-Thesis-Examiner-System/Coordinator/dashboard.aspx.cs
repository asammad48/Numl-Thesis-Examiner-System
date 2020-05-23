using Newtonsoft.Json;
using BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coordinator.Numl_Thesis_Examiner_System
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                year.Items.Add("All");
                for (int i = DateTime.Now.Year; i >= 2020; i--)
                    year.Items.Add(i.ToString());
            }
        }
        [WebMethod]
        public static string getcount(string year)
        {
            //DataTable dt = new DataTable();
            //dt = new TeacherBAL().getcount(year,HttpContext.Current.Session["PD_ID"].ToString());
            //return JsonConvert.SerializeObject(dt);
            return null;
        }
    }
}