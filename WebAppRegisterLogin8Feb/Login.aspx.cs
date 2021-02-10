using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppRegisterLogin8Feb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["uname"] != null && Session["pass"] != null)
                {
                    txtBoxUserName.Text = Session["uname"].ToString();
                    txtBoxPass.Text = Session["pass"].ToString();

                    Response.Redirect("Welcome.aspx");
                }
            }

            catch (Exception ex)
            {
                Response.Write("Empty fields.");
            }
        }
    }
}