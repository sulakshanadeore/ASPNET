using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //ListBox1.Items.Add("Pune");
                //ListBox1.Items.Add("Chennai");
                //ListBox1.Items.Add("Mumbai");
                //ListBox1.Items.Add("Hyderabad");
                //ListBox1.Items.Add("Bangalore");
                string  pid=Request.QueryString["prodid"].ToString();
                string pname=
                    Request.QueryString["productname"].ToString();
                string qty =
                    Request.QueryString["quan"].ToString();

                ListBox2.Items.Add(pid);
                ListBox2.Items.Add(pname);
                ListBox2.Items.Add(qty);


                DropDownList1.Items.Add("--Select--");
                ListItem item = new ListItem("Pune", "Hinjawadi");

                ListBox1.Items.Add(item);
                DropDownList1.Items.Add(item);

                item = new ListItem("Bangalore", "Manyata");
                ListBox1.Items.Add(item);
                DropDownList1.Items.Add(item);

                item = new ListItem("Hyderabad", "CyberCity");
                ListBox1.Items.Add(item);
                DropDownList1.Items.Add(item);

                Label3.Text = ListBox1.Items.Count.ToString();

                


            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //TextBox2.Text=ListBox1.SelectedValue;
            string s = "";
            int[] indices=ListBox1.GetSelectedIndices();
            foreach (var item in indices)
            {
                s += ListBox1.Items[item].Value;
                            
            }
            TextBox2.Text=s;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox2.Text = DropDownList1.SelectedValue;
        }
    }
}