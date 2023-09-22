using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["query"] != null)
                {
                    string query = Request.QueryString["query"].ToString();
                    List<Film> FilmsFound = DB.SearchFilm(query);
                    if (FilmsFound.Count > 0)
                    {
                        messageRow.Visible = false;
                        RepeaterFound.DataSource = FilmsFound;
                        RepeaterFound.DataBind();
                    }
                }
            }
        }


    }
}