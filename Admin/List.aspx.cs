using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin
{
    public partial class List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {

                if (!IsPostBack)
                {
                    List<Film> films = DB.getAllFilm();
                    Repeater1.DataSource = films;
                    Repeater1.DataBind();
                   
                }


            }

        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = Convert.ToInt32(btn.CommandArgument.ToString());
            DB.RemoveFilm(id);
            Response.Redirect("List.aspx");
        }
    }
}