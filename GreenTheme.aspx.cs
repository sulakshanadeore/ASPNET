using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesDemo
{
    public partial class GreenTheme : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            this.Theme = "Green";
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}