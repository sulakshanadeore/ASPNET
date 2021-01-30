using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideStateMgtDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Is New Session= " + Session.IsNewSession);
            Response.Write("<br/>");

            Response.Write("SessionID" + Session.SessionID);
            Label1.Text="Welcome "+ Session["username"].ToString();
            Label1.Text += " your login time= " +  Session["loginTime"].ToString();
            

            MultiView1.SetActiveView(PersonalInformation);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string filename=FileUpload1.FileName;
                string path = @"~/UploadedDocs/";
                FileUpload1.SaveAs(Server.MapPath(path + filename));
                
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value=DropDownList1.SelectedValue;
            switch (value)
            {
                case "Personal":
                    MultiView1.SetActiveView(PersonalInformation);
            break;
                case "Educational":
                    MultiView1.SetActiveView(EducationalInformation);
                    break;
                case "Other":
                    MultiView1.SetActiveView(OtherInformation);
                    break;
                default:
                    MultiView1.SetActiveView(PersonalInformation);
                    break;
            }
        }
    }
}