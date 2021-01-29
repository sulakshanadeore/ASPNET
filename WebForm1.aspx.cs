using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               Response.Write("Page Loaded First time");
                string name=Request.Cookies["uname"].Value;
                Label1.Text = "Welcome  " + name;
            }
            else
            {
                Response.Write("Page Loaded back as the button was clicked");
            }
        }

        //protected event  void DelName(object sender, EventArgs e) Click;
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('Hello')</script>");
            //embedding js in asp.net

            
        }
    }
}