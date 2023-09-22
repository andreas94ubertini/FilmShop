using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

        protected void signInButton_Click(object sender, EventArgs e)
        {
            List<User> users = DB.getAllUsers();

            User user = DB.getUserByUsername(username.Text);
            if (user.Username == null) {
                string filename = "";
                if (avatar.HasFile)
                {
                    filename = avatar.FileName;
                    avatar.SaveAs(Server.MapPath($"/Content/assets/{avatar.FileName}"));
                }
                else filename = "default-avatar.jpg";

                DB.SignIn(name.Text, surname.Text, username.Text, password.Text, filename);
                FormsAuthentication.SetAuthCookie(username.Text, false);
                HttpCookie auth = new HttpCookie("username");
                auth.Value = username.Text;
                Response.Cookies.Add(auth);
                Response.Redirect("Default.aspx");
            } else errorMessage.Visible = true;
           
        }
    }
}