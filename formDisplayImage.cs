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
    public partial class formDisplayImage : Form
    {
        public formDisplayImage()
        {
            InitializeComponent();
        }

        private void formDisplayImage_Load(object sender, EventArgs e)
        {
            //form load event handler

            List<model.ClassTableImageData> listClassTableImageData = new List<model.ClassTableImageData>();
            string connString = ConfigurationManager.ConnectionStrings["connectionStringDBStoreImage"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM TableImageData";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.ClassTableImageData classTableImageData = new model.ClassTableImageData
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                ImageData = reader["ImageData"] as byte[],
                                FileName = reader.GetString(reader.GetOrdinal("FileName"))
                            };
                            listClassTableImageData.Add(classTableImageData);
                        }
                    }
                }
            }
            if (listClassTableImageData.Count > 0)
            {
                dataGridViewImageList.DataSource = null;
                dataGridViewImageList.DataSource = listClassTableImageData;
                dataGridViewImageList.Refresh();
                //set row pointer to row 0
                dataGridViewImageList.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("No data to display.");
                dataGridViewImageList.DataSource = null;
                dataGridViewImageList.Refresh();
            }
        }

        private void dataGridViewImageList_SelectionChanged(object sender, EventArgs e)
        {
            //data grid view, selection change event handler
            string connString = ConfigurationManager.ConnectionStrings["connectionStringDBStoreImage"].ConnectionString;
            model.ClassTableImageData classTableImageData = dataGridViewImageList.CurrentRow.DataBoundItem as model.ClassTableImageData;
            if (classTableImageData != null)
            {
                int selectedId = classTableImageData.Id;
                string fileName = classTableImageData.FileName;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT ImageData FROM TableImageData WHERE Id = @selectedId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                pictureBoxDisplayShoeImage.Image = Image.FromStream(ms);
                                pictureBoxDisplayShoeImage.SizeMode = PictureBoxSizeMode.StretchImage;
                                // Get size in bytes
                                long sizeInBytes = ms.Length;
                                // Convert to kilobytes
                                double sizeInKB = sizeInBytes / 1024.0;
                                //write to file size
                                labelImageSize.Text = "Image Size: " + sizeInKB.ToString() + " kB";
                            }
                            //write to shoe id
                            labelShoeId.Text = "Shoe Id: " + selectedId.ToString();
                            //write to shoe name
                            labelShoeName.Text = "File Name: " + fileName;

                            
                            

                        }
                    }
                }
            }
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            //button add image
            formAddImage formAddImageOri = new formAddImage();
            formAddImageOri.ShowDialog();

            List<model.ClassTableImageData> listClassTableImageData = new List<model.ClassTableImageData>();
            string connString = ConfigurationManager.ConnectionStrings["connectionStringDBStoreImage"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM TableImageData";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            model.ClassTableImageData classTableImageData = new model.ClassTableImageData
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                ImageData = reader["ImageData"] as byte[],
                                FileName = reader.GetString(reader.GetOrdinal("FileName"))
                            };
                            listClassTableImageData.Add(classTableImageData);
                        }
                    }
                }
            }
            if (listClassTableImageData.Count > 0)
            {
                dataGridViewImageList.DataSource = null;
                dataGridViewImageList.DataSource = listClassTableImageData;
                dataGridViewImageList.Refresh();
                //set row pointer to row 0
                dataGridViewImageList.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("No data to display.");
                dataGridViewImageList.DataSource = null;
                dataGridViewImageList.Refresh();
            }
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            //delete image button
            string connString = ConfigurationManager.ConnectionStrings["connectionStringDBStoreImage"].ConnectionString;
            model.ClassTableImageData classTableImageData = dataGridViewImageList.CurrentRow.DataBoundItem as model.ClassTableImageData;
            if (classTableImageData != null)
	        {
		        int selectedId = classTableImageData.Id;
		        using (SqlConnection conn = new SqlConnection(connString))
                {
			        conn.Open();
                    string query = "DELETE FROM TableImageData WHERE  Id = @selectedId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);
                        object result = cmd.ExecuteScalar();
                    }
                }
                MessageBox.Show("Image item deleted successfully.", "Delete Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<model.ClassTableImageData> listClassTableImageData = new List<model.ClassTableImageData>();
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT * FROM TableImageData";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                model.ClassTableImageData classTableImageData2 = new model.ClassTableImageData
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    ImageData = reader["ImageData"] as byte[],
                                    FileName = reader.GetString(reader.GetOrdinal("FileName"))
                                };
                                listClassTableImageData.Add(classTableImageData2);
                            }
                        }
                    }
                }
                if (listClassTableImageData.Count > 0)
                {
                    dataGridViewImageList.DataSource = null;
                    dataGridViewImageList.DataSource = listClassTableImageData;
                    dataGridViewImageList.Refresh();
                    //set row pointer to row 0
                    dataGridViewImageList.Rows[0].Selected = true;
                }
                else
                {
                    MessageBox.Show("No data to display.");
                    dataGridViewImageList.DataSource = null;
                    dataGridViewImageList.Refresh();
                }
            }
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            FormViewAllImage formViewAllImage = new FormViewAllImage();
            formViewAllImage.ShowDialog();  
        }
    }
}
