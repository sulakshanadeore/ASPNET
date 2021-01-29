using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserBAL.UserLogin login = new UserBAL.UserLogin();
            login.Username = txtusername.Text.Trim();

            login.Password = txtpwd.Text.Trim();
            DAL.UserLoginDAL dal = new DAL.UserLoginDAL();
            bool status=dal.ValidateUser(login);
            if (status)
            {
                HttpCookie cookie = new HttpCookie("uname");
                cookie.Value = login.Username;
                cookie.Expires = DateTime.Now.AddMinutes(10);
                Response.Cookies.Add(cookie);

                //Response.Write("Successfull");
                Response.Redirect("~/WebForm1.aspx");
            }
            else
            {
                Response.Write("Not valid ");
            }
        }
    }
}