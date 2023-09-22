using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce.Admin
{
    public partial class AddNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            string fileNameBg = "";
            if (BackgroundUpload.HasFile)
            {
                fileNameBg = BackgroundUpload.FileName;
                BackgroundUpload.SaveAs(Server.MapPath($"/Content/img/{BackgroundUpload.FileName}"));
            }
            string fileNameCover = "";
            if (CoverImgUpload.HasFile)
            {
                fileNameCover = CoverImgUpload.FileName;
                CoverImgUpload.SaveAs(Server.MapPath($"/Content/img/{CoverImgUpload.FileName}"));
            }
            string fileNameImg1 = "";
            if (Img1Upload.HasFile)
            {
                fileNameImg1 = Img1Upload.FileName;
                Img1Upload.SaveAs(Server.MapPath($"/Content/img/{Img1Upload.FileName}"));
            }
            string fileNameImg2 = "";
            if (Img2Upload.HasFile)
            {
                fileNameImg2 = Img2Upload.FileName;
                Img2Upload.SaveAs(Server.MapPath($"/Content/img/{Img2Upload.FileName}"));
            }
            string fileNameImg3 = "";
            if (Img3Upload.HasFile)
            {
                fileNameImg3 = Img3Upload.FileName;
                Img3Upload.SaveAs(Server.MapPath($"/Content/img/{Img3Upload.FileName}"));
            }

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Films VALUES(@Title, @Production, @Category, @Year, @Duration, @FirstActor, @Price, @BackgroundImg, @CoverImg, @Img1, @Img2, @Img3, @Director, @Rating)";
                cmd.Parameters.AddWithValue("Title", TitleBox.Text);
                cmd.Parameters.AddWithValue("Production", ProductionBox.Text);
                cmd.Parameters.AddWithValue("Category", CategoryBox.Text);
                cmd.Parameters.AddWithValue("Year", YearBox.Text);
                cmd.Parameters.AddWithValue("Duration", DurationBox.Text);
                cmd.Parameters.AddWithValue("FirstActor", FirstActorBox.Text);
                cmd.Parameters.AddWithValue("Price", Convert.ToDouble(PriceBox.Text));
                cmd.Parameters.AddWithValue("BackgroundImg", fileNameBg);
                cmd.Parameters.AddWithValue("CoverImg", fileNameCover);
                cmd.Parameters.AddWithValue("Img1", fileNameImg1);
                cmd.Parameters.AddWithValue("Img2", fileNameImg2);
                cmd.Parameters.AddWithValue("Img3", fileNameImg3);
                cmd.Parameters.AddWithValue("Director", DirectorBox.Text);
                cmd.Parameters.AddWithValue("Rating", Convert.ToDouble(RatingBox.Text));


                int IsOk = cmd.ExecuteNonQuery();

                if (IsOk > 0)
                {
                    Response.Redirect("Default");
                }
            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}