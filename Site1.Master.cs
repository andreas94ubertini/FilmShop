using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.Cookies[".ASPXAUTH"] != null)
                {
                    loginButton.Text = "Logout";
                    signInButton.Visible = false;
                    User user = DB.getUserByUsername(HttpContext.Current.User.Identity.Name);
                    profileImg.ImageUrl = $"~/Content/assets/{user.Image}";
                    if (user.Role == "admin") adminBtn.Visible = true;
                    else adminBtn.Visible = false;
                }
                else
                {
                    loginButton.Text = "Login";
                    adminBtn.Visible = false;
                    signInButton.Visible = true;
                    profileImg.Visible = false;
                }
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            if(loginButton.Text == "Login")
            Response.Redirect(FormsAuthentication.LoginUrl);
            else
            {
                FormsAuthentication.SignOut();
                Session.Clear();
                Response.Redirect("Default.aspx");
            }
        }

        protected void premium_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Premium.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/List.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ModFilm.aspx");
        }

        protected void signInButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            string query = ToSearch.Text;
            Response.Redirect($"~/search.aspx?query={query}");
        }
    }
}