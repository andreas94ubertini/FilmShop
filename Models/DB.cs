using E_Commerce.Admin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public static class DB
    {
       public static List<Film> getAllFilm()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Films", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Film> films = new List<Film>();
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Film film = new Film();
                film.Id = Convert.ToInt32(sqlDataReader["IdFilm"]);
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
                films.Add(film);
            }

            conn.Close();
            return films;
        }

        public static Film getFilmById(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Films where idFilm = @id", conn);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader sqlDataReader;

            conn.Open();
            sqlDataReader = cmd.ExecuteReader();

            Film film = new Film();
            while (sqlDataReader.Read())
            {
                film.Id = Convert.ToInt32(sqlDataReader["IdFilm"]);
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

        public static List<Film> getFilmsByCategory(string cat)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Films where Category = @cat", conn);
            cmd.Parameters.AddWithValue("cat", cat);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Film> films = new List<Film>();
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Film film = new Film();
                film.Id = Convert.ToInt32(sqlDataReader["IdFilm"]);
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
                films.Add(film);
            }

            conn.Close();
            return films;
        }
        public static void Modify(int id, string title, string production, string category, string year, string duration, string firstActor,
            double price, string fileNameBg, string fileNameCover, string fileNameImg1, string fileNameImg2, string fileNameImg3, string director, double rating)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Films SET Title=@title, Production=@production, Category=@category, Year=@year, Duration=@duration, FirstActor=@firstActor, Price=@price," +
                "BackgroundImg=@fileNameBg, CoverImg=@fileNameCover, Img1=@fileNameImg1, Img2=@fileNameImg2, Img3=@fileNameImg3, Director=@director, Rating=@rating  where IdFilm=@id";
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
            cmd.Parameters.AddWithValue("id", id);
            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void InsertFilm(string title, string production, string category, string year, string duration, string firstActor,
             double price, string fileNameBg, string fileNameCover, string fileNameImg1, string fileNameImg2, string fileNameImg3, string director, double rating)
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

            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
        public static void RemoveFilm(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM Films where IdFilm=@id";
            cmd.Parameters.AddWithValue("id", id);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void SignIn(string name, string surname, string username, string password, string image)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Users VALUES(@name, @surname, @username, @password, @role, @image)";
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("surname", surname);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("role", "user");
                cmd.Parameters.AddWithValue("image", image);
                int IsOk = cmd.ExecuteNonQuery();
                
            }

            catch
            {
                
            }
            finally
            {
                conn.Close();
            }
        }
        public static User getUserByUsername(string username)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Users where Username = @username", conn);
            cmd.Parameters.AddWithValue("username", username);
            SqlDataReader sqlDataReader;

            conn.Open();
            sqlDataReader = cmd.ExecuteReader();

            User user = new User();
            while (sqlDataReader.Read())
            {
                user.Id = Convert.ToInt32(sqlDataReader["IdUser"]);
                user.Name = sqlDataReader["Name"].ToString();
                user.Surname = sqlDataReader["Surname"].ToString();
                user.Username =sqlDataReader["Username"].ToString();
                user.Password = sqlDataReader["Password"].ToString();
                user.Role = sqlDataReader["Role"].ToString();
                user.Image = sqlDataReader["ProfileImg"].ToString();
            }

            conn.Close();
            return user;
        }

        public static User getUserById(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Users where IdUser = @id", conn);
            cmd.Parameters.AddWithValue("IdUser", id);
            SqlDataReader sqlDataReader;

            conn.Open();
            sqlDataReader = cmd.ExecuteReader();

            User user = new User();
            while (sqlDataReader.Read())
            {
                user.Id = Convert.ToInt32(sqlDataReader["IdUser"]);
                user.Name = sqlDataReader["Name"].ToString();
                user.Surname = sqlDataReader["Surname"].ToString();
                user.Username = sqlDataReader["Username"].ToString();
                user.Password = sqlDataReader["Password"].ToString();
                user.Role = sqlDataReader["Role"].ToString();
                user.Image = sqlDataReader["ProfileImg"].ToString();
            }

            conn.Close();
            return user;
        }

        public static List<User> getAllUsers()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Users", conn);
            SqlDataReader sqlDataReader;

            conn.Open();
            sqlDataReader = cmd.ExecuteReader();

            List<User> users = new List<User>();
            while (sqlDataReader.Read())
            {
                User user = new User();
                user.Id = Convert.ToInt32(sqlDataReader["IdUser"]);
                user.Name = sqlDataReader["Name"].ToString();
                user.Surname = sqlDataReader["Surname"].ToString();
                user.Username = sqlDataReader["Username"].ToString();
                user.Role = sqlDataReader["Role"].ToString();
                user.Image = sqlDataReader["ProfileImg"].ToString();
                users.Add(user);
            }

            conn.Close();
            return users;
        }

        public static void writeReview(string text, int idFilm, int idUser)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Reviews VALUES(@text, @idFilm, @idUser)";
                cmd.Parameters.AddWithValue("text", text);
                cmd.Parameters.AddWithValue("idFilm", idFilm);
                cmd.Parameters.AddWithValue("idUser", idUser);
                int IsOk = cmd.ExecuteNonQuery();

            }

            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Review_User> getAllReviewsByIdFilm(int idFilm)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SELECT Commento, Username, ProfileImg, IdFilm FROM Reviews INNER JOIN Users ON Reviews.IdUser = Users.IdUser WHERE IdFilm = @idFilm;", conn);
            cmd.Parameters.AddWithValue("idFilm", idFilm);
            SqlDataReader sqlDataReader;

            conn.Open();
            sqlDataReader = cmd.ExecuteReader();

            List<Review_User> reviews = new List<Review_User>();
            while (sqlDataReader.Read())
            {
                Review_User review = new Review_User();
                review.Text = sqlDataReader["Commento"].ToString();
                review.Username = sqlDataReader["Username"].ToString();
                review.ProfileImg = sqlDataReader["ProfileImg"].ToString();
                reviews.Add(review);
            }

            conn.Close();
            return reviews;
        }

        public static List<Film> SearchFilm(string search)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Films WHERE Title LIKE '%{search}%';", conn);
            SqlDataReader sqlDataReader;
            List<Film> filmsFound = new List<Film>();
            conn.Open();
            sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Film film = new Film();
                film.Id = Convert.ToInt32(sqlDataReader["IdFilm"]);
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
                filmsFound.Add(film);
            }

            conn.Close();
            return filmsFound;
        }
    }
}