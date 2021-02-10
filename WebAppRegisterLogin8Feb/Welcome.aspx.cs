using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppRegisterLogin8Feb
{
    public partial class Welcome1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblDisplayName.Text = Session["fname"].ToString();
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}