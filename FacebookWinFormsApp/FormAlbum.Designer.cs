namespace BasicFacebookFeatures
{
    public partial class FormAlbum
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
            this.buttonFilter = new System.Windows.Forms.Button();
            this.checkBoxLocationFilter = new System.Windows.Forms.CheckBox();
            this.checkBoxDateFilter = new System.Windows.Forms.CheckBox();
            this.listBoxLocationFilter = new System.Windows.Forms.ListBox();
            this.listBoxDateFilter = new System.Windows.Forms.ListBox();
            this.groupBoxAlbumPhotos = new System.Windows.Forms.GroupBox();
            this.listBoxAlbumPhotos = new System.Windows.Forms.ListBox();
            this.pictureBoxPhotoFromAlbum = new System.Windows.Forms.PictureBox();
            this.groupBoxAlbumPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoFromAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFilter
            // 
            this.buttonFilter.Enabled = false;
            this.buttonFilter.Location = new System.Drawing.Point(210, 14);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 20);
            this.buttonFilter.TabIndex = 0;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // checkBoxLocationFilter
            // 
            this.checkBoxLocationFilter.AutoSize = true;
            this.checkBoxLocationFilter.Location = new System.Drawing.Point(6, 14);
            this.checkBoxLocationFilter.Name = "checkBoxLocationFilter";
            this.checkBoxLocationFilter.Size = new System.Drawing.Size(73, 17);
            this.checkBoxLocationFilter.TabIndex = 7;
            this.checkBoxLocationFilter.Text = "Location: ";
            this.checkBoxLocationFilter.UseVisualStyleBackColor = true;
            this.checkBoxLocationFilter.CheckedChanged += new System.EventHandler(this.checkBoxLocationFilter_CheckedChanged);
            // 
            // checkBoxDateFilter
            // 
            this.checkBoxDateFilter.AutoSize = true;
            this.checkBoxDateFilter.Location = new System.Drawing.Point(6, 68);
            this.checkBoxDateFilter.Name = "checkBoxDateFilter";
            this.checkBoxDateFilter.Size = new System.Drawing.Size(52, 17);
            this.checkBoxDateFilter.TabIndex = 8;
            this.checkBoxDateFilter.Text = "Date:";
            this.checkBoxDateFilter.UseVisualStyleBackColor = true;
            this.checkBoxDateFilter.CheckedChanged += new System.EventHandler(this.checkBoxDateFilter_CheckedChanged);
            // 
            // listBoxLocationFilter
            // 
            this.listBoxLocationFilter.Enabled = false;
            this.listBoxLocationFilter.FormattingEnabled = true;
            this.listBoxLocationFilter.Location = new System.Drawing.Point(75, 14);
            this.listBoxLocationFilter.Name = "listBoxLocationFilter";
            this.listBoxLocationFilter.Size = new System.Drawing.Size(119, 43);
            this.listBoxLocationFilter.TabIndex = 9;
            // 
            // listBoxDateFilter
            // 
            this.listBoxDateFilter.Enabled = false;
            this.listBoxDateFilter.FormattingEnabled = true;
            this.listBoxDateFilter.Location = new System.Drawing.Point(75, 68);
            this.listBoxDateFilter.Name = "listBoxDateFilter";
            this.listBoxDateFilter.Size = new System.Drawing.Size(119, 43);
            this.listBoxDateFilter.TabIndex = 10;
            // 
            // groupBoxAlbumPhotos
            // 
            this.groupBoxAlbumPhotos.Controls.Add(this.listBoxAlbumPhotos);
            this.groupBoxAlbumPhotos.Location = new System.Drawing.Point(6, 140);
            this.groupBoxAlbumPhotos.Name = "groupBoxAlbumPhotos";
            this.groupBoxAlbumPhotos.Size = new System.Drawing.Size(417, 251);
            this.groupBoxAlbumPhotos.TabIndex = 11;
            this.groupBoxAlbumPhotos.TabStop = false;
            this.groupBoxAlbumPhotos.Text = "Album Photos";
            // 
            // listBoxAlbumPhotos
            // 
            this.listBoxAlbumPhotos.FormattingEnabled = true;
            this.listBoxAlbumPhotos.Location = new System.Drawing.Point(3, 16);
            this.listBoxAlbumPhotos.Name = "listBoxAlbumPhotos";
            this.listBoxAlbumPhotos.Size = new System.Drawing.Size(414, 238);
            this.listBoxAlbumPhotos.TabIndex = 0;
            this.listBoxAlbumPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbumPhotos_SelectedIndexChanged);
            // 
            // pictureBoxPhotoFromAlbum
            // 
            this.pictureBoxPhotoFromAlbum.Location = new System.Drawing.Point(323, 14);
            this.pictureBoxPhotoFromAlbum.Name = "pictureBoxPhotoFromAlbum";
            this.pictureBoxPhotoFromAlbum.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxPhotoFromAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhotoFromAlbum.TabIndex = 1;
            this.pictureBoxPhotoFromAlbum.TabStop = false;
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 399);
            this.Controls.Add(this.pictureBoxPhotoFromAlbum);
            this.Controls.Add(this.groupBoxAlbumPhotos);
            this.Controls.Add(this.listBoxDateFilter);
            this.Controls.Add(this.listBoxLocationFilter);
            this.Controls.Add(this.checkBoxDateFilter);
            this.Controls.Add(this.checkBoxLocationFilter);
            this.Controls.Add(this.buttonFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAlbum";
            this.Text = "FormAlbum";
            this.groupBoxAlbumPhotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoFromAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.CheckBox checkBoxLocationFilter;
        private System.Windows.Forms.CheckBox checkBoxDateFilter;
        private System.Windows.Forms.ListBox listBoxLocationFilter;
        private System.Windows.Forms.ListBox listBoxDateFilter;
        private System.Windows.Forms.GroupBox groupBoxAlbumPhotos;
        private System.Windows.Forms.ListBox listBoxAlbumPhotos;
        private System.Windows.Forms.PictureBox pictureBoxPhotoFromAlbum;
    }
}