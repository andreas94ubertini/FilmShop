using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                List<Film> actionFilms = new List<Film>();
                actionFilms = DB.getFilmsByCategory("Azione");
                RepeaterAzione.DataSource = actionFilms;
                RepeaterAzione.DataBind();

                List<Film> fantascienzaFilms = new List<Film>();
                fantascienzaFilms = DB.getFilmsByCategory("Fantascienza");
                RepeaterFantascienza.DataSource = fantascienzaFilms;
                RepeaterFantascienza.DataBind();

                List<Film> horrorFilms = new List<Film>();
                horrorFilms = DB.getFilmsByCategory("Horror");
                RepeaterHorror.DataSource = horrorFilms;
                RepeaterHorror.DataBind();

                List<Film> fantasyFilms = new List<Film>();
                fantasyFilms = DB.getFilmsByCategory("Fantasy");
                RepeaterFantasy.DataSource = fantasyFilms;
                RepeaterFantasy.DataBind();

                List<Film> commediaFilms = new List<Film>();
                commediaFilms = DB.getFilmsByCategory("Commedia");
                RepeaterCommedia.DataSource = commediaFilms;
                RepeaterCommedia.DataBind();

                if (Request.Cookies[".ASPXAUTH"] != null) title.InnerText = $"Ciao {HttpContext.Current.User.Identity.Name}!";
            }
        }
    }
}