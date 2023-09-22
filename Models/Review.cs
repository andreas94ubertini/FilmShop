using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Review
    {
        public int IdReview;
        public string Commento { get; set; }

        public int IdFilm;

        public int IdUser;

        public Review () { }
        public Review (string commento, int idFilm, int idUser)
        {
            Commento = commento;
            IdFilm = idFilm;
            IdUser = idUser;
        }
    }
}