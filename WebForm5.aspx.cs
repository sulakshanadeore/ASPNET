using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ViewState["cnt"] = 0;
                TextBox5.Text = ViewState["cnt"].ToString();
            }
            else
            {
                //ViewState is a Statebag of info that holds data for the page using key/value pair-- dictionary
                int counter= Convert.ToInt32(ViewState["cnt"]);
                counter += 1;
                TextBox5.Text = counter.ToString();
                ViewState["cnt"] = counter;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(TextBox1.Text);
            string pname = TextBox2.Text.Trim();
            int qty = Convert.ToInt32(DropDownList1.SelectedValue);
            Response.Redirect("~/WebForm2.aspx?prodid=" + pid + "&productname=" + pname + "&quan=" + qty);


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(TextBox3.Text);
            string pname = TextBox4.Text.Trim();
            int qty = Convert.ToInt32(DropDownList2.SelectedValue);

            ViewState["id"] = pid;
            ViewState["pname"] = pname;
            ViewState["pqty"] = qty;

            ListBox1.Items.Add(ViewState["id"].ToString());
            ListBox1.Items.Add(ViewState["pname"].ToString());
            ListBox1.Items.Add(ViewState["pqty"].ToString());

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text==HiddenField1.Value)
            {
                Response.Write("Your answer is  correct");
            }
            else
            {
                Response.Write("Your answer is  wrong");
            }
          
        }
    }
}