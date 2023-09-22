using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Review_User
    {
        public string Text;
        public string Username;
        public string ProfileImg;
        
        public Review_User() { }
        public Review_User(string text, string username, string profileImg)
        {
            this.Text = text;
            this.Username = username;
            this.ProfileImg = profileImg;
        }
    }
}