namespace proj_store_image4
{
    partial class formAddImage
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
            this.labelFileId = new System.Windows.Forms.Label();
            this.labelImageFile = new System.Windows.Forms.Label();
            this.textBoxFileId = new System.Windows.Forms.TextBox();
            this.textBoxFileImage = new System.Windows.Forms.TextBox();
            this.buttonSelectImageFile = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxfileName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFileId
            // 
            this.labelFileId.AutoSize = true;
            this.labelFileId.Location = new System.Drawing.Point(12, 9);
            this.labelFileId.Name = "labelFileId";
            this.labelFileId.Size = new System.Drawing.Size(56, 20);
            this.labelFileId.TabIndex = 0;
            this.labelFileId.Text = "File Id:";
            // 
            // labelImageFile
            // 
            this.labelImageFile.AutoSize = true;
            this.labelImageFile.Location = new System.Drawing.Point(12, 71);
            this.labelImageFile.Name = "labelImageFile";
            this.labelImageFile.Size = new System.Drawing.Size(87, 20);
            this.labelImageFile.TabIndex = 1;
            this.labelImageFile.Text = "Image File:";
            // 
            // textBoxFileId
            // 
            this.textBoxFileId.Location = new System.Drawing.Point(12, 32);
            this.textBoxFileId.Name = "textBoxFileId";
            this.textBoxFileId.Size = new System.Drawing.Size(594, 26);
            this.textBoxFileId.TabIndex = 2;
            // 
            // textBoxFileImage
            // 
            this.textBoxFileImage.Location = new System.Drawing.Point(12, 94);
            this.textBoxFileImage.Name = "textBoxFileImage";
            this.textBoxFileImage.ReadOnly = true;
            this.textBoxFileImage.Size = new System.Drawing.Size(550, 26);
            this.textBoxFileImage.TabIndex = 3;
            // 
            // buttonSelectImageFile
            // 
            this.buttonSelectImageFile.Location = new System.Drawing.Point(568, 91);
            this.buttonSelectImageFile.Name = "buttonSelectImageFile";
            this.buttonSelectImageFile.Size = new System.Drawing.Size(38, 32);
            this.buttonSelectImageFile.TabIndex = 4;
            this.buttonSelectImageFile.Text = "...";
            this.buttonSelectImageFile.UseVisualStyleBackColor = true;
            this.buttonSelectImageFile.Click += new System.EventHandler(this.buttonSelectImageFile_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(12, 133);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(84, 20);
            this.labelFileName.TabIndex = 5;
            this.labelFileName.Text = "File Name:";
            // 
            // textBoxfileName
            // 
            this.textBoxfileName.Location = new System.Drawing.Point(12, 156);
            this.textBoxfileName.Name = "textBoxfileName";
            this.textBoxfileName.ReadOnly = true;
            this.textBoxfileName.Size = new System.Drawing.Size(590, 26);
            this.textBoxfileName.TabIndex = 6;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 198);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 32);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 198);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 32);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // formAddImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 246);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxfileName);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.buttonSelectImageFile);
            this.Controls.Add(this.textBoxFileImage);
            this.Controls.Add(this.textBoxFileId);
            this.Controls.Add(this.labelImageFile);
            this.Controls.Add(this.labelFileId);
            this.MaximizeBox = false;
            this.Name = "formAddImage";
            this.Text = "Add Image";
            this.Load += new System.EventHandler(this.formAddImage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileId;
        private System.Windows.Forms.Label labelImageFile;
        private System.Windows.Forms.TextBox textBoxFileId;
        private System.Windows.Forms.TextBox textBoxFileImage;
        private System.Windows.Forms.Button buttonSelectImageFile;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox textBoxfileName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
    }
}