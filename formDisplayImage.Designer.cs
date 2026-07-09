namespace proj_store_image4
{
    partial class formDisplayImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxDisplayShoeImage = new System.Windows.Forms.PictureBox();
            this.labelShoeId = new System.Windows.Forms.Label();
            this.labelShoeName = new System.Windows.Forms.Label();
            this.labelImageSize = new System.Windows.Forms.Label();
            this.dataGridViewImageList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTableImageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayShoeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImageList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTableImageDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplayShoeImage
            // 
            this.pictureBoxDisplayShoeImage.Location = new System.Drawing.Point(356, 12);
            this.pictureBoxDisplayShoeImage.Name = "pictureBoxDisplayShoeImage";
            this.pictureBoxDisplayShoeImage.Size = new System.Drawing.Size(395, 436);
            this.pictureBoxDisplayShoeImage.TabIndex = 0;
            this.pictureBoxDisplayShoeImage.TabStop = false;
            // 
            // labelShoeId
            // 
            this.labelShoeId.AutoSize = true;
            this.labelShoeId.Location = new System.Drawing.Point(352, 456);
            this.labelShoeId.Name = "labelShoeId";
            this.labelShoeId.Size = new System.Drawing.Size(69, 20);
            this.labelShoeId.TabIndex = 1;
            this.labelShoeId.Text = "Shoe Id:";
            // 
            // labelShoeName
            // 
            this.labelShoeName.AutoSize = true;
            this.labelShoeName.Location = new System.Drawing.Point(352, 476);
            this.labelShoeName.Name = "labelShoeName";
            this.labelShoeName.Size = new System.Drawing.Size(84, 20);
            this.labelShoeName.TabIndex = 2;
            this.labelShoeName.Text = "File Name:";
            // 
            // labelImageSize
            // 
            this.labelImageSize.AutoSize = true;
            this.labelImageSize.Location = new System.Drawing.Point(352, 496);
            this.labelImageSize.Name = "labelImageSize";
            this.labelImageSize.Size = new System.Drawing.Size(93, 20);
            this.labelImageSize.TabIndex = 3;
            this.labelImageSize.Text = "Image Size:";
            // 
            // dataGridViewImageList
            // 
            this.dataGridViewImageList.AllowUserToAddRows = false;
            this.dataGridViewImageList.AllowUserToDeleteRows = false;
            this.dataGridViewImageList.AllowUserToResizeRows = false;
            this.dataGridViewImageList.AutoGenerateColumns = false;
            this.dataGridViewImageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageDataDataGridViewImageColumn,
            this.fileNameDataGridViewTextBoxColumn});
            this.dataGridViewImageList.DataSource = this.classTableImageDataBindingSource;
            this.dataGridViewImageList.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewImageList.Name = "dataGridViewImageList";
            this.dataGridViewImageList.ReadOnly = true;
            this.dataGridViewImageList.RowHeadersWidth = 62;
            this.dataGridViewImageList.RowTemplate.Height = 28;
            this.dataGridViewImageList.Size = new System.Drawing.Size(338, 436);
            this.dataGridViewImageList.TabIndex = 4;
            this.dataGridViewImageList.SelectionChanged += new System.EventHandler(this.dataGridViewImageList_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // imageDataDataGridViewImageColumn
            // 
            this.imageDataDataGridViewImageColumn.DataPropertyName = "ImageData";
            this.imageDataDataGridViewImageColumn.HeaderText = "ImageData";
            this.imageDataDataGridViewImageColumn.MinimumWidth = 8;
            this.imageDataDataGridViewImageColumn.Name = "imageDataDataGridViewImageColumn";
            this.imageDataDataGridViewImageColumn.ReadOnly = true;
            this.imageDataDataGridViewImageColumn.Visible = false;
            this.imageDataDataGridViewImageColumn.Width = 300;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "File Name";
            this.fileNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classTableImageDataBindingSource
            // 
            this.classTableImageDataBindingSource.DataSource = typeof(proj_store_image4.model.ClassTableImageData);
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(12, 454);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(150, 32);
            this.buttonAddImage.TabIndex = 5;
            this.buttonAddImage.Text = "Add Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.Location = new System.Drawing.Point(12, 492);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(150, 32);
            this.buttonDeleteImage.TabIndex = 6;
            this.buttonDeleteImage.Text = "Delete Image";
            this.buttonDeleteImage.UseVisualStyleBackColor = true;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Location = new System.Drawing.Point(12, 530);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(150, 32);
            this.buttonViewAll.TabIndex = 7;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // formDisplayImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 570);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.buttonDeleteImage);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.dataGridViewImageList);
            this.Controls.Add(this.labelImageSize);
            this.Controls.Add(this.labelShoeName);
            this.Controls.Add(this.labelShoeId);
            this.Controls.Add(this.pictureBoxDisplayShoeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formDisplayImage";
            this.Text = "Display Image";
            this.Load += new System.EventHandler(this.formDisplayImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayShoeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImageList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTableImageDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplayShoeImage;
        private System.Windows.Forms.Label labelShoeId;
        private System.Windows.Forms.Label labelShoeName;
        private System.Windows.Forms.Label labelImageSize;
        private System.Windows.Forms.DataGridView dataGridViewImageList;
        private System.Windows.Forms.BindingSource classTableImageDataBindingSource;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
    }
}