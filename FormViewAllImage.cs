using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace proj_store_image4
{
    public partial class FormViewAllImage : Form
    {
        public FormViewAllImage()
        {
            InitializeComponent();
        }

        private void FormViewAllImage_Load(object sender, EventArgs e)
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
                dataGridViewAllImage.DataSource = null;
                dataGridViewAllImage.DataSource = listClassTableImageData;
                dataGridViewAllImage.Refresh();
                //set row pointer to row 0
                dataGridViewAllImage.Rows[0].Selected = true;
            }
            else
            {
                MessageBox.Show("No data to display.");
                dataGridViewAllImage.DataSource = null;
                dataGridViewAllImage.Refresh();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
