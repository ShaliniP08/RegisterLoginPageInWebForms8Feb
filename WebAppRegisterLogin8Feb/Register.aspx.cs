using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppRegisterLogin8Feb
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxFirstName.Text.Equals(null) && txtBoxUsername.Text.Equals(null) && txtBoxPass.Text.Equals(null))
                {
                    Response.Redirect("Default.aspx");
                    
                }
                else
                {
                    Session["fname"] = txtBoxFirstName.Text;
                    Session["uname"] = txtBoxUsername.Text;
                    Session["pass"] = txtBoxPass.Text;

                    Response.Redirect("Login.aspx");
                }
                    
            }
            catch(Exception ex)
            {
                //code
            }
        }
    }
}