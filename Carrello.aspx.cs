using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        List<Film> carrello = new List<Film>();
        double tot = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            carrello = (List<Film>)Session["Carrello"];

            if(carrello != null && carrello.Count > 0)
            {
                foreach (Film film in carrello) tot += film.Price;
                totale.InnerText = $"Totale: {String.Format("{0:0.00 €}",tot)}";
                message.Visible = false;
                SvuotaCarrello.Visible = true;
                Repeater1.DataSource = carrello;
                Repeater1.DataBind();
            } else
            {
                SvuotaCarrello.Visible = false;
                message.Visible = true;
            }

        }

        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            carrello.Clear();
            Response.Redirect("Default.aspx");
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            int id = Convert.ToInt32(btn.CommandArgument);
            foreach (Film film in carrello)
            {
                if (film.Id == id)
                {
                    carrello.Remove(film);
                    Response.Redirect("carrello.aspx");
                    break;
                }
            }
        }
    }
}