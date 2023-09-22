using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Film
    {
        public int Id;
        public string Title { get; set; }
        public string Production { get; set; }
        public string Category { get; set; }
        public string Year { get; set; }
        public string Duration { get; set; }
        public string FirstActor { get; set; }
        public double Price { get; set; }
        public string BackgroundImg { get; set; }
        public string CoverImg { get; set; }
        public string Img1 { get; set; }
        public string Img2 { get; set; }
        public string Img3 { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }

        public string Language;

        public Film() { }

        public Film(string title, string production, string category, string year, string duration, string firstActor, double price, string backgroundImg, string coverImg, string director, double rating)
        {
            Title = title;
            Production = production;
            Category = category;
            Year = year;
            Duration = duration;
            FirstActor = firstActor;
            Price = price;
            BackgroundImg = backgroundImg;
            CoverImg = coverImg;
            Director = director;
            Rating = rating;
        }

        public Film(string title, string production, string category, string year, string duration, string firstActor, double price, string backgroundImg, string coverImg, string img1, string director, double rating)
        {
            Title = title;
            Production = production;
            Category = category;
            Year = year;
            Duration = duration;
            FirstActor = firstActor;
            Price = price;
            BackgroundImg = backgroundImg;
            CoverImg = coverImg;
            Img1 = img1;
            Director = director;
            Rating = rating;
        }

        public Film(string title, string production, string category, string year, string duration, string firstActor, double price, string backgroundImg, string coverImg, string img1, string img2, string director, double rating)
        {
            Title = title;
            Production = production;
            Category = category;
            Year = year;
            Duration = duration;
            FirstActor = firstActor;
            Price = price;
            BackgroundImg = backgroundImg;
            CoverImg = coverImg;
            Img1 = img1;
            Img2 = img2;
            Director = director;
            Rating = rating;
        }
        public Film(string title, string production, string category, string year, string duration, string firstActor, double price, string backgroundImg, string coverImg, string img1, string img2, string img3, string director, double rating)
        {
            Title = title;
            Production = production;
            Category = category;
            Year = year;
            Duration = duration;
            FirstActor = firstActor;
            Price = price;
            BackgroundImg = backgroundImg;
            CoverImg = coverImg;
            Img1 = img1;
            Img2 = img2;
            Img3 = img3;
            Director = director;
            Rating = rating;
        }
    }
}