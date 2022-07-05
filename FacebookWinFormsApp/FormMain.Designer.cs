namespace BasicFacebookFeatures
{
    public partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.groupBoxUserFriends = new System.Windows.Forms.GroupBox();
            this.labelFriendBirthDay = new System.Windows.Forms.Label();
            this.labelFriendLocale = new System.Windows.Forms.Label();
            this.labelFriendEmail = new System.Windows.Forms.Label();
            this.buttonFriendQuiz = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxUserFriends = new System.Windows.Forms.ListBox();
            this.groupBoxAlbums = new System.Windows.Forms.GroupBox();
            this.labelAlbumCreationDate = new System.Windows.Forms.Label();
            this.labelAlbumNumberOfPhotos = new System.Windows.Forms.Label();
            this.buttonShowAlbumPhotos = new System.Windows.Forms.Button();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.listBoxUserAlbums = new System.Windows.Forms.ListBox();
            this.groupBoxPostStatus = new System.Windows.Forms.GroupBox();
            this.richTextBoxPostStatus = new System.Windows.Forms.RichTextBox();
            this.groupBoxMyPosts = new System.Windows.Forms.GroupBox();
            this.listBoxUserPosts = new System.Windows.Forms.ListBox();
            this.labelLogedInUserEmail = new System.Windows.Forms.Label();
            this.labelLogedInUserBirthday = new System.Windows.Forms.Label();
            this.labelLogedInUserLocale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.groupBoxUserFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.groupBoxAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            this.groupBoxPostStatus.SuspendLayout();
            this.groupBoxMyPosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(12, 41);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(179, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(552, 17);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonPostStatus.TabIndex = 53;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 70);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // groupBoxUserFriends
            // 
            this.groupBoxUserFriends.Controls.Add(this.labelFriendBirthDay);
            this.groupBoxUserFriends.Controls.Add(this.labelFriendLocale);
            this.groupBoxUserFriends.Controls.Add(this.labelFriendEmail);
            this.groupBoxUserFriends.Controls.Add(this.buttonFriendQuiz);
            this.groupBoxUserFriends.Controls.Add(this.pictureBoxFriend);
            this.groupBoxUserFriends.Controls.Add(this.listBoxUserFriends);
            this.groupBoxUserFriends.Enabled = false;
            this.groupBoxUserFriends.Location = new System.Drawing.Point(12, 295);
            this.groupBoxUserFriends.Name = "groupBoxUserFriends";
            this.groupBoxUserFriends.Size = new System.Drawing.Size(390, 274);
            this.groupBoxUserFriends.TabIndex = 56;
            this.groupBoxUserFriends.TabStop = false;
            this.groupBoxUserFriends.Text = "My Friends";
            // 
            // labelFriendBirthDay
            // 
            this.labelFriendBirthDay.AutoSize = true;
            this.labelFriendBirthDay.Location = new System.Drawing.Point(107, 205);
            this.labelFriendBirthDay.Name = "labelFriendBirthDay";
            this.labelFriendBirthDay.Size = new System.Drawing.Size(48, 13);
            this.labelFriendBirthDay.TabIndex = 63;
            this.labelFriendBirthDay.Text = "Birthday:";
            // 
            // labelFriendLocale
            // 
            this.labelFriendLocale.AutoSize = true;
            this.labelFriendLocale.Location = new System.Drawing.Point(107, 183);
            this.labelFriendLocale.Name = "labelFriendLocale";
            this.labelFriendLocale.Size = new System.Drawing.Size(45, 13);
            this.labelFriendLocale.TabIndex = 62;
            this.labelFriendLocale.Text = "Locale: ";
            // 
            // labelFriendEmail
            // 
            this.labelFriendEmail.AutoSize = true;
            this.labelFriendEmail.Location = new System.Drawing.Point(107, 161);
            this.labelFriendEmail.Name = "labelFriendEmail";
            this.labelFriendEmail.Size = new System.Drawing.Size(35, 13);
            this.labelFriendEmail.TabIndex = 61;
            this.labelFriendEmail.Text = "Email:";
            // 
            // buttonFriendQuiz
            // 
            this.buttonFriendQuiz.Location = new System.Drawing.Point(110, 236);
            this.buttonFriendQuiz.Name = "buttonFriendQuiz";
            this.buttonFriendQuiz.Size = new System.Drawing.Size(215, 23);
            this.buttonFriendQuiz.TabIndex = 60;
            this.buttonFriendQuiz.Text = "How Well Do You Know Your Friend?";
            this.buttonFriendQuiz.UseVisualStyleBackColor = true;
            this.buttonFriendQuiz.Click += new System.EventHandler(this.buttonFriendQuiz_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(0, 159);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 58;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxUserFriends
            // 
            this.listBoxUserFriends.FormattingEnabled = true;
            this.listBoxUserFriends.Location = new System.Drawing.Point(0, 19);
            this.listBoxUserFriends.Name = "listBoxUserFriends";
            this.listBoxUserFriends.Size = new System.Drawing.Size(390, 134);
            this.listBoxUserFriends.TabIndex = 0;
            this.listBoxUserFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxUserFriends_SelectedIndexChanged);
            // 
            // groupBoxAlbums
            // 
            this.groupBoxAlbums.Controls.Add(this.labelAlbumCreationDate);
            this.groupBoxAlbums.Controls.Add(this.labelAlbumNumberOfPhotos);
            this.groupBoxAlbums.Controls.Add(this.buttonShowAlbumPhotos);
            this.groupBoxAlbums.Controls.Add(this.pictureBoxAlbum);
            this.groupBoxAlbums.Controls.Add(this.listBoxUserAlbums);
            this.groupBoxAlbums.Enabled = false;
            this.groupBoxAlbums.Location = new System.Drawing.Point(440, 295);
            this.groupBoxAlbums.Name = "groupBoxAlbums";
            this.groupBoxAlbums.Size = new System.Drawing.Size(390, 274);
            this.groupBoxAlbums.TabIndex = 57;
            this.groupBoxAlbums.TabStop = false;
            this.groupBoxAlbums.Text = "My Albums";
            // 
            // labelAlbumCreationDate
            // 
            this.labelAlbumCreationDate.AutoSize = true;
            this.labelAlbumCreationDate.Location = new System.Drawing.Point(106, 183);
            this.labelAlbumCreationDate.Name = "labelAlbumCreationDate";
            this.labelAlbumCreationDate.Size = new System.Drawing.Size(75, 13);
            this.labelAlbumCreationDate.TabIndex = 62;
            this.labelAlbumCreationDate.Text = "Creation Date:";
            // 
            // labelAlbumNumberOfPhotos
            // 
            this.labelAlbumNumberOfPhotos.AutoSize = true;
            this.labelAlbumNumberOfPhotos.Location = new System.Drawing.Point(106, 161);
            this.labelAlbumNumberOfPhotos.Name = "labelAlbumNumberOfPhotos";
            this.labelAlbumNumberOfPhotos.Size = new System.Drawing.Size(106, 13);
            this.labelAlbumNumberOfPhotos.TabIndex = 61;
            this.labelAlbumNumberOfPhotos.Text = "Photos in the album: ";
            // 
            // buttonShowAlbumPhotos
            // 
            this.buttonShowAlbumPhotos.Location = new System.Drawing.Point(109, 236);
            this.buttonShowAlbumPhotos.Name = "buttonShowAlbumPhotos";
            this.buttonShowAlbumPhotos.Size = new System.Drawing.Size(130, 24);
            this.buttonShowAlbumPhotos.TabIndex = 60;
            this.buttonShowAlbumPhotos.Text = "Show Album\'s Photos";
            this.buttonShowAlbumPhotos.UseVisualStyleBackColor = true;
            this.buttonShowAlbumPhotos.Click += new System.EventHandler(this.buttonShowAlbumPictures_Click);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(0, 159);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 59;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // listBoxUserAlbums
            // 
            this.listBoxUserAlbums.FormattingEnabled = true;
            this.listBoxUserAlbums.Location = new System.Drawing.Point(0, 19);
            this.listBoxUserAlbums.Name = "listBoxUserAlbums";
            this.listBoxUserAlbums.Size = new System.Drawing.Size(390, 134);
            this.listBoxUserAlbums.TabIndex = 1;
            this.listBoxUserAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxUserAlbums_SelectedIndexChanged);
            // 
            // groupBoxPostStatus
            // 
            this.groupBoxPostStatus.Controls.Add(this.richTextBoxPostStatus);
            this.groupBoxPostStatus.Controls.Add(this.buttonPostStatus);
            this.groupBoxPostStatus.Enabled = false;
            this.groupBoxPostStatus.Location = new System.Drawing.Point(197, 12);
            this.groupBoxPostStatus.Name = "groupBoxPostStatus";
            this.groupBoxPostStatus.Size = new System.Drawing.Size(633, 109);
            this.groupBoxPostStatus.TabIndex = 58;
            this.groupBoxPostStatus.TabStop = false;
            this.groupBoxPostStatus.Text = "Post Status";
            // 
            // richTextBoxPostStatus
            // 
            this.richTextBoxPostStatus.Location = new System.Drawing.Point(0, 19);
            this.richTextBoxPostStatus.Name = "richTextBoxPostStatus";
            this.richTextBoxPostStatus.Size = new System.Drawing.Size(546, 90);
            this.richTextBoxPostStatus.TabIndex = 54;
            this.richTextBoxPostStatus.Text = "What\'s on your mind?";
            this.richTextBoxPostStatus.Click += new System.EventHandler(this.richTextBoxPostStatus_Click);
            // 
            // groupBoxMyPosts
            // 
            this.groupBoxMyPosts.Controls.Add(this.listBoxUserPosts);
            this.groupBoxMyPosts.Enabled = false;
            this.groupBoxMyPosts.Location = new System.Drawing.Point(197, 127);
            this.groupBoxMyPosts.Name = "groupBoxMyPosts";
            this.groupBoxMyPosts.Size = new System.Drawing.Size(633, 162);
            this.groupBoxMyPosts.TabIndex = 59;
            this.groupBoxMyPosts.TabStop = false;
            this.groupBoxMyPosts.Text = "My Posts";
            // 
            // listBoxUserPosts
            // 
            this.listBoxUserPosts.FormattingEnabled = true;
            this.listBoxUserPosts.Location = new System.Drawing.Point(0, 19);
            this.listBoxUserPosts.Name = "listBoxUserPosts";
            this.listBoxUserPosts.Size = new System.Drawing.Size(633, 147);
            this.listBoxUserPosts.TabIndex = 60;
            // 
            // labelLogedInUserEmail
            // 
            this.labelLogedInUserEmail.AutoSize = true;
            this.labelLogedInUserEmail.Location = new System.Drawing.Point(12, 173);
            this.labelLogedInUserEmail.Name = "labelLogedInUserEmail";
            this.labelLogedInUserEmail.Size = new System.Drawing.Size(35, 13);
            this.labelLogedInUserEmail.TabIndex = 62;
            this.labelLogedInUserEmail.Text = "Email:";
            // 
            // labelLogedInUserBirthday
            // 
            this.labelLogedInUserBirthday.AutoSize = true;
            this.labelLogedInUserBirthday.Location = new System.Drawing.Point(12, 220);
            this.labelLogedInUserBirthday.Name = "labelLogedInUserBirthday";
            this.labelLogedInUserBirthday.Size = new System.Drawing.Size(48, 13);
            this.labelLogedInUserBirthday.TabIndex = 64;
            this.labelLogedInUserBirthday.Text = "Birthday:";
            // 
            // labelLogedInUserLocale
            // 
            this.labelLogedInUserLocale.AutoSize = true;
            this.labelLogedInUserLocale.Location = new System.Drawing.Point(12, 196);
            this.labelLogedInUserLocale.Name = "labelLogedInUserLocale";
            this.labelLogedInUserLocale.Size = new System.Drawing.Size(45, 13);
            this.labelLogedInUserLocale.TabIndex = 65;
            this.labelLogedInUserLocale.Text = "Locale :";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 573);
            this.Controls.Add(this.labelLogedInUserLocale);
            this.Controls.Add(this.labelLogedInUserBirthday);
            this.Controls.Add(this.labelLogedInUserEmail);
            this.Controls.Add(this.groupBoxMyPosts);
            this.Controls.Add(this.groupBoxPostStatus);
            this.Controls.Add(this.groupBoxAlbums);
            this.Controls.Add(this.groupBoxUserFriends);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.groupBoxUserFriends.ResumeLayout(false);
            this.groupBoxUserFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.groupBoxAlbums.ResumeLayout(false);
            this.groupBoxAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            this.groupBoxPostStatus.ResumeLayout(false);
            this.groupBoxMyPosts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.GroupBox groupBoxUserFriends;
        private System.Windows.Forms.ListBox listBoxUserFriends;
        private System.Windows.Forms.GroupBox groupBoxAlbums;
        private System.Windows.Forms.ListBox listBoxUserAlbums;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.GroupBox groupBoxPostStatus;
        private System.Windows.Forms.RichTextBox richTextBoxPostStatus;
        private System.Windows.Forms.GroupBox groupBoxMyPosts;
        private System.Windows.Forms.Button buttonShowAlbumPhotos;
        private System.Windows.Forms.ListBox listBoxUserPosts;
        private System.Windows.Forms.Label labelAlbumNumberOfPhotos;
        private System.Windows.Forms.Button buttonFriendQuiz;
        private System.Windows.Forms.Label labelFriendEmail;
        private System.Windows.Forms.Label labelFriendLocale;
        private System.Windows.Forms.Label labelFriendBirthDay;
        private System.Windows.Forms.Label labelAlbumCreationDate;
        private System.Windows.Forms.Label labelLogedInUserEmail;
        private System.Windows.Forms.Label labelLogedInUserBirthday;
        private System.Windows.Forms.Label labelLogedInUserLocale;
    }
}
