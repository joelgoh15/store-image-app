using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proj_store_image4
{
    public partial class formTest : Form
    {
        public formTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath + "\\image\\" + "shoe_image4.png";
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("file dont exists. file path:" + filePath);
                return;
            }
            int id = 4;
            byte[] imageData = System.IO.File.ReadAllBytes(filePath);
            string fileName = "shoe_image4.png";
            string connString = ConfigurationManager.ConnectionStrings["connectionStringDBStoreImage"].ConnectionString;
            //// Replace |DataDirectory| with the actual resolved path
            //string resolvedConnStr = connString.Replace("|DataDirectory|", AppDomain.CurrentDomain.GetData("DataDirectory").ToString());
            //System.Diagnostics.Debug.WriteLine("Resolved Connection String:");
            //System.Diagnostics.Debug.WriteLine(resolvedConnStr);
            

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "INSERT INTO TableImageData (Id, ImageData, FileName) VALUES (@id, @imageData, @fileName)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@imageData", System.Data.SqlDbType.VarBinary).Value = imageData;
                    cmd.Parameters.Add("@fileName", System.Data.SqlDbType.VarChar).Value = fileName;
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["connectionStringDBStoreImage"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT ImageData FROM TableImageData WHERE Id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int id = 4;
                    cmd.Parameters.AddWithValue("@id", id);
                    //byte[] imageBytes = (byte[])cmd.ExecuteScalar();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])result;

                        // Convert bytes back to Image
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No image found.");
                    }



                }
            }
        }
    }
}
