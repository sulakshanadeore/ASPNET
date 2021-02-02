using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CachingDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack)
            //{


            //    Response.Write(DropDownList1.SelectedItem.Value);
            //    Response.Write("<br/>");
            //    Response.Write(DropDownList1.SelectedItem.Text);

            //    Response.Write("<br/>");

            //}

            //Response.Write("Will be displayed shortly");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write(DropDownList1.SelectedItem.Value);
            Response.Write("<br/>");
            Response.Write(DropDownList1.SelectedItem.Text);

            Response.Write("<br/>");

        }
    }
}