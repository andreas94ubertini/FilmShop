using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string psw = password.Text;
            User loggedUser = DB.getUserByUsername(user);
            if (loggedUser != null && loggedUser.Password == psw && loggedUser.Role == "admin") {
                FormsAuthentication.SetAuthCookie(username.Text, false);
                Response.Redirect(FormsAuthentication.DefaultUrl);
            } else if (loggedUser != null && loggedUser.Password == psw)
            {
                FormsAuthentication.SetAuthCookie(username.Text, false);
                Response.Redirect("Default.aspx");
            }
            else errorMessage.Visible = true;
        }
    }
}