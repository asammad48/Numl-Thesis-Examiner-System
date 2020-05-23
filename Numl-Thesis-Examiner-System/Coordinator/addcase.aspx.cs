using BAL;
using Newtonsoft.Json;
using PROPS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Numl_Thesis_Examiner_System
{
    public partial class addcase : System.Web.UI.Page
    {
        Program p = new Program();
        protected void Page_Load(object sender, EventArgs e)
        {
            ProgramBAL program = new ProgramBAL();
            DataTable dt = new DataTable();
            dt = program.GetProgram(p);
            foreach (DataRow row in dt.Rows)
            {
                programddl.Items.Add(row["Name"].ToString()); 
                   
            }
            //HttpContext.Current.Session["emails"] = new TeacherBAL().Getemails();
            //if (!IsPostBack) {
            //    research_area.DataSource = new TeacherBAL().GetRarea();
            //    research_area.DataTextField = "Research_Area";
            //    research_area.DataBind();
            //}
        }



        protected void submit_Click(object sender, EventArgs e)
        {          
         //TeacherPROPS tp=new TeacherPROPS();
         //String val = Session["ans"].ToString();
         //tp.Ptitle= papertitle.Text.Trim() ;
         //tp.Pjname= journalname.Text.Trim();
         //tp.Name1 = Name.Text.Trim();
         //tp.Pvolume= volume.Text.Trim();
         //tp.Pissue= issue.Text.Trim();
         //tp.Ppno= pageno1.Text.Trim()+" - "+pageno2.Text.Trim();
         //tp.Particleid= articleid.Text.Trim();
         //tp.Pdoi= doi.Text.Trim();
         //tp.Presearch= research_area.SelectedItem.Text.Trim();
         //tp.Ptype=category.SelectedValue.ToString().Trim() ;
         //tp.Pimpact=impactfactor.Text.Trim() ;
         //tp.Psindex= similarityindex.Text.Trim();
         //tp.Pdate= datepicker.Text.Trim();
         //tp.Pissn=issn.Text.Trim() ;
         //tp.Purl=url.Text.Trim() ;
         //   //Author Type
         //if (authtype1.Checked)
         //    tp.Authtype = 1;
         //else
         //    tp.Authtype = 2;
         //   //
         //tp.Email1 = cuemail.Text.Trim();
         //   //some time 1st author email and some time 2nd
         //tp.Pcemail=coauthornuml.Text.Trim();
         //tp.Psemail = coauthor.Text.Trim();
         //tp.Pqval=val ;
         //   //pq10 is question 10 user specified question
         //tp.Pq10 = HttpContext.Current.Session["pq10"].ToString();
         //tp.Department1 = Convert.ToInt32(Session["deptid"].ToString());
         //tp.Exclusions = exclusions.Text.Trim();
         //tp.PD_ID1 = Convert.ToInt32(Session["PD_ID"].ToString());
         //  //Amount Calculation not completed
         //  int amount=0;
         //    //calculate amount for Current Author

         //   tp.Camount=amount;
         //   //calculate amount for Other Author

         //   tp.Samount = amount;
         //int i=new TeacherBAL().AddPaper(tp);
         //if (i >0)
         //{
         //    int count = 0;
         //    if (paper.HasFile)
         //    {
         //        string extension = System.IO.Path.GetExtension(paper.FileName);
         //        if (extension == ".pdf")
         //        {
         //            paper.SaveAs(Server.MapPath("Paper_Repository/") + i+".pdf");
         //            count++;
         //        }                
         //    }
         //    if (report.HasFile)
         //    {
         //        string extension = System.IO.Path.GetExtension(report.FileName);
         //        if (extension == ".pdf")
         //        {
         //            report.SaveAs(Server.MapPath("Report_Repository/") + i + ".pdf");
         //            count++;
         //        }
         //    }
         //    alert.Text = "Your Paper fowarded for approval. "+count+" file uploaded.";
         //    alert.Visible = true;
         //}
         //else
         //{
         //    alert.Attributes["class"] = "col-sm-12 text-center alert alert-danger";
         //    alert.Visible = true;
         //    alert.Text = "Paper already exists."; 
         //}
         //  HttpContext.Current.Session["ans"] = "";
         //  HttpContext.Current.Session["pq10"] = "";
        }

       
    }
}