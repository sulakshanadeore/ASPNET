using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSideStateMgtDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Time Out (Minutes)  " + Session.Timeout);
            Response.Write("<br/>");
            Response.Write("Is New Session= " + Session.IsNewSession);
            Response.Write("<br/>");
            Session["username"] = TextBox1.Text;
            Session.Add("loginTime", DateTime.Now.ToLocalTime());
            Response.Write(Session.SessionID);
            //Response.Redirect("~/WebForm1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}