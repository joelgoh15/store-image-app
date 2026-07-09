namespace proj_store_image4
{
    partial class FormViewAllImage
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
            this.dataGridViewAllImage = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classTableImageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTableImageDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllImage
            // 
            this.dataGridViewAllImage.AutoGenerateColumns = false;
            this.dataGridViewAllImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageDataDataGridViewImageColumn,
            this.fileNameDataGridViewTextBoxColumn});
            this.dataGridViewAllImage.DataSource = this.classTableImageDataBindingSource;
            this.dataGridViewAllImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAllImage.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAllImage.Name = "dataGridViewAllImage";
            this.dataGridViewAllImage.RowHeadersWidth = 62;
            this.dataGridViewAllImage.RowTemplate.Height = 321;
            this.dataGridViewAllImage.Size = new System.Drawing.Size(1018, 534);
            this.dataGridViewAllImage.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(931, 540);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 32);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // imageDataDataGridViewImageColumn
            // 
            this.imageDataDataGridViewImageColumn.DataPropertyName = "ImageData";
            this.imageDataDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataDataGridViewImageColumn.MinimumWidth = 8;
            this.imageDataDataGridViewImageColumn.Name = "imageDataDataGridViewImageColumn";
            this.imageDataDataGridViewImageColumn.ReadOnly = true;
            this.imageDataDataGridViewImageColumn.Width = 242;
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
            // FormViewAllImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 584);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewAllImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormViewAllImage";
            this.Text = "View All Image";
            this.Load += new System.EventHandler(this.FormViewAllImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classTableImageDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllImage;
        private System.Windows.Forms.BindingSource classTableImageDataBindingSource;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
    }
}