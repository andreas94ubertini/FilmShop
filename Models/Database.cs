using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Database
    {
        public static Film GetById(int IdFilm)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Films where IdFilm=@IdFilm", conn);
            cmd.Parameters.AddWithValue("IdFilm", IdFilm);
            SqlDataReader sqlDataReader;

            conn.Open();


            sqlDataReader = cmd.ExecuteReader();
            Film film = new Film();
            while (sqlDataReader.Read())
            {
                film.Title = sqlDataReader["Title"].ToString();
                film.Director = sqlDataReader["Director"].ToString();
                film.Price = Convert.ToDouble(sqlDataReader["Price"]);
                film.Category = sqlDataReader["Category"].ToString();
                film.Duration = sqlDataReader["Duration"].ToString();
                film.Production = sqlDataReader["Production"].ToString();
                film.FirstActor = sqlDataReader["FirstActor"].ToString();
                film.Year = sqlDataReader["Year"].ToString();
                film.Rating = Convert.ToDouble(sqlDataReader["Rating"]);
                film.BackgroundImg = sqlDataReader["BackgroundImg"].ToString();
                film.CoverImg = sqlDataReader["CoverImg"].ToString();
                film.Img1 = sqlDataReader["Img1"].ToString();
                film.Img2 = sqlDataReader["Img2"].ToString();
                film.Img3 = sqlDataReader["Img3"].ToString();
            }
            conn.Close();
            return film;
        }
        public static List<Film> GetAll()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Films", conn);
            SqlDataReader sqlDataReader;

            conn.Open();


            sqlDataReader = cmd.ExecuteReader();
            List<Film> FilmList = new List<Film>();
            while (sqlDataReader.Read())
            {
                Film film = new Film();
                film.Title = sqlDataReader["Title"].ToString();
                film.Director = sqlDataReader["Director"].ToString();
                film.Price = Convert.ToDouble(sqlDataReader["Price"]);
                film.Category = sqlDataReader["Category"].ToString();
                film.Duration = sqlDataReader["Duration"].ToString();
                film.Production = sqlDataReader["Production"].ToString();
                film.FirstActor = sqlDataReader["FirstActor"].ToString();
                film.Year = sqlDataReader["Year"].ToString();
                film.Rating = Convert.ToDouble(sqlDataReader["Rating"]);
                film.BackgroundImg = sqlDataReader["BackgroundImg"].ToString();
                film.CoverImg = sqlDataReader["CoverImg"].ToString();
                film.Img1 = sqlDataReader["Img1"].ToString();
                film.Img2 = sqlDataReader["Img2"].ToString();
                film.Img3 = sqlDataReader["Img3"].ToString();
                FilmList.Add(film);
            }
            conn.Close();
            return FilmList;
        }
        public static void Insert(string title, string production, string category, string year, string duration, string firstActor,
          double price, string fileNameBg, string fileNameCover, string fileNameImg1,string fileNameImg2, string fileNameImg3, string director, double rating  )
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Films VALUES(@Title, @Production, @Category, @Year, @Duration, @FirstActor, @Price, @BackgroundImg, @CoverImg, @Img1, @Img2, @Img3, @Director, @Rating)";
                cmd.Parameters.AddWithValue("Title", title);
                cmd.Parameters.AddWithValue("Production", production);
                cmd.Parameters.AddWithValue("Category", category);
                cmd.Parameters.AddWithValue("Year", year);
                cmd.Parameters.AddWithValue("Duration", duration);
                cmd.Parameters.AddWithValue("FirstActor", firstActor);
                cmd.Parameters.AddWithValue("Price", Convert.ToDouble(price));
                cmd.Parameters.AddWithValue("BackgroundImg", fileNameBg);
                cmd.Parameters.AddWithValue("CoverImg", fileNameCover);
                cmd.Parameters.AddWithValue("Img1", fileNameImg1);
                cmd.Parameters.AddWithValue("Img2", fileNameImg2);
                cmd.Parameters.AddWithValue("Img3", fileNameImg3);
                cmd.Parameters.AddWithValue("Director", director);
                cmd.Parameters.AddWithValue("Rating", Convert.ToDouble(rating));
                int IsOk = cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
        public static void Modify(int id, string title, string production, string category, string year, string duration, string firstActor,
          double price, string fileNameBg, string fileNameCover, string fileNameImg1, string fileNameImg2, string fileNameImg3, string director, double rating)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Films SET Title=@title, Production=@production, Category=@category, Year=@year, Duration=@duration, FirstActor=@firstActor, Price=@price," +
                "BackgroundImage=@fileNameBg CoverImg=@fileNameCover Img1=@fileNameImg1 Img2=@fileNameImg2 Img3=@fileNameImg3 Director=@director Rating=@rating  where IdFilm=@id";
            cmd.Parameters.AddWithValue("title", title);
            cmd.Parameters.AddWithValue("production", production);
            cmd.Parameters.AddWithValue("category", category);
            cmd.Parameters.AddWithValue("year", year);
            cmd.Parameters.AddWithValue("duration", duration);
            cmd.Parameters.AddWithValue("firstActor", firstActor);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Parameters.AddWithValue("fileNameBg", fileNameBg);
            cmd.Parameters.AddWithValue("fileNameCover", fileNameCover);
            cmd.Parameters.AddWithValue("fileNameImg1", fileNameImg1);
            cmd.Parameters.AddWithValue("fileNameImg2", fileNameImg2);
            cmd.Parameters.AddWithValue("fileNameImg3", fileNameImg3);
            cmd.Parameters.AddWithValue("director", director);
            cmd.Parameters.AddWithValue("rating", rating);
            cmd.Parameters.AddWithValue("IdFilm", id);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}