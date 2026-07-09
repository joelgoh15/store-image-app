using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace proj_store_image4
{
    public partial class formAddImage : Form
    {
        public formAddImage()
        {
            InitializeComponent();
        }
        private void formAddImage_Load(object sender, EventArgs e)
        {
            //form load event handler

            //empty all current textbox entries
            textBoxFileId.Text = string.Empty;
            textBoxFileImage.Text = string.Empty;
            textBoxfileName.Text = string.Empty;
            textBoxFileId.Focus();
        }


        private void buttonSelectImageFile_Click(object sender, EventArgs e)
        {
            //button to select image  file
            // Create and configure OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Image",
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Multiselect = false
                
            };

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("user click cancel");
                return;
            }

            // Show dialog and check if user clicked OK
            if (dialogResult == DialogResult.OK)
            {
                // Write full file path into the TextBox
                textBoxFileImage.Text = openFileDialog.FileName;
                // Extract only the file name
                string fileName = Path.GetFileName(openFileDialog.FileName);
                textBoxfileName.Text = fileName;
            }

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //submit button
            if (textBoxFileId.Text == string.Empty)
            {
                MessageBox.Show("File Id must not be empty.", "File Id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxFileImage.Text == string.Empty)
            {
                MessageBox.Show("File image entry must not be empty.", "File Id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxfileName.Text == string.Empty)
            {
                MessageBox.Show("File name entry must not be empty.", "File Id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!System.IO.File.Exists(textBoxFileImage.Text))
            {
                MessageBox.Show("image file does not exists.", "Imgae File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int fileId;
            if (!int.TryParse(textBoxFileId.Text, out fileId))
            {
                MessageBox.Show("file  id is not valid.", "File Id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            fileId = Convert.ToInt32(textBoxFileId.Text.Trim());
            byte[] imageData = System.IO.File.ReadAllBytes(textBoxFileImage.Text.Trim());
            string fileName = textBoxfileName.Text;
            string connString = ConfigurationManager.ConnectionStrings["connectionStringDBStoreImage"].ConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO TableImageData (Id, ImageData, FileName) VALUES (@id, @imageData, @fileName)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = fileId;
                        cmd.Parameters.Add("@imageData", System.Data.SqlDbType.VarBinary).Value = imageData;
                        cmd.Parameters.Add("@fileName", System.Data.SqlDbType.VarChar).Value = fileName;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                MessageBox.Show("file id provided is not unique.", "File id", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("shoe item added successfully.", "Shoe Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxFileId.Text = string.Empty;
            textBoxFileImage.Text = string.Empty;
            textBoxfileName.Text = string.Empty;
            textBoxFileId.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
