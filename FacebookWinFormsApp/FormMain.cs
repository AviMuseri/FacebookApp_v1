using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        #region Members

        private const string k_LabelDefaultFormatHomeTown = "Home Town: ";
        private const string k_LabelDefaultFormatBirthDay = "Birthday: ";
        private const string k_LabelDefaultFormatEmail = "Email: ";
        private FriendQuizForm m_FriendQuizForm;
        private FormAlbum m_AlbumForm;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;

        #endregion

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void logIn()
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    "349656043722946",
                    "email",
                    "public_profile",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_friends",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_hometown");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                changeVisiblityOfUserProerties();
                fetchProfileData();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void changeVisiblityOfUserProerties()
        {
            groupBoxAlbums.Enabled = groupBoxUserFriends.Enabled = groupBoxPostStatus.Enabled
                = pictureBoxProfile.Enabled = groupBoxMyPosts.Enabled = m_LoggedInUser != null;
        }

        private void fetchProfileData()
        {
            loadLogedInUserProperties();
            initializeListBoxAlbums();
            initializeListBoxFriends();
            initializeListBoxPosts();
        }

        #region Initialize Album & Posts & Friends List Boxes

        private void initializeListBoxPosts()
        {
            if (m_LoggedInUser.Posts != null)
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    listBoxUserPosts.Items.Add(string.IsNullOrEmpty(post.Message) ? post.CreatedTime.ToString() : post.Message);
                }
            }
        }

        private void initializeListBoxFriends()
        {
            if (m_LoggedInUser.Friends != null)
            {
                listBoxUserFriends.DataSource = m_LoggedInUser.Friends;
            }
        }

        private void initializeListBoxAlbums()
        {
            if (m_LoggedInUser.Albums != null)
            {
                listBoxUserAlbums.DataSource = m_LoggedInUser.Albums.Select(album => album.Name).ToList();
            }
        }

        #endregion

        #region Post Status

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            postStatus();
        }

        private void postStatus()
        {
            const string postStatusRichTextBoxDefaultString = "What's on your mind?";

            try
            {
                if (!string.IsNullOrEmpty(richTextBoxPostStatus.Text))
                {
                    m_LoggedInUser.PostStatus(richTextBoxPostStatus.Text);
                    MessageBox.Show("Status Uploaded!");
                }
                else
                {
                    MessageBox.Show("Please enter text to post.");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong, status not uploaded.", "Upload status error");
            }

            richTextBoxPostStatus.Text = postStatusRichTextBoxDefaultString;
        }

        #endregion

        #region Load Friend & Album Properties

        private void loadLogedInUserProperties()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelLogedInUserLocale.Text = $"{k_LabelDefaultFormatHomeTown}{m_LoggedInUser.Locale}";
            labelLogedInUserEmail.Text = $"{k_LabelDefaultFormatEmail}{m_LoggedInUser.Email}";
            labelLogedInUserBirthday.Text = $"{k_LabelDefaultFormatBirthDay}{m_LoggedInUser.Birthday}";
        }

        private void loadFriendProperties()
        {
            User selectedFriend = listBoxUserFriends.SelectedItem as User;

            pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
            labelFriendLocale.Text = $"{k_LabelDefaultFormatHomeTown}{selectedFriend.Locale}";
            labelFriendEmail.Text = $"{k_LabelDefaultFormatEmail}{selectedFriend.Email}";
            labelFriendBirthDay.Text = $"{k_LabelDefaultFormatBirthDay}{selectedFriend.Birthday}";
        }

        private void loadAlbumProperties()
        {
            const string labelAlbumDefaultFormatNumberOfPhotos = "Number of photos in this album: ";
            const string labelAlbumDefaultFormatCreationDate = "Creation Date: ";

            Album selectedAlbum = m_LoggedInUser.Albums?.First
                (album => album.Name == listBoxUserAlbums.SelectedItem.ToString());

            pictureBoxAlbum.LoadAsync(selectedAlbum?.PictureAlbumURL);
            labelAlbumNumberOfPhotos.Text = $"{labelAlbumDefaultFormatNumberOfPhotos}{selectedAlbum.Photos.Count}";
            labelAlbumCreationDate.Text = $"{labelAlbumDefaultFormatCreationDate}{selectedAlbum.CreatedTime}";
        }

        #endregion

        private void listBoxUserAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAlbumProperties();
        }

        private void listBoxUserFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFriendProperties();
        }

        private void buttonShowAlbumPictures_Click(object sender, EventArgs e)
        {
            Album selectedAlbum = m_LoggedInUser.Albums.FirstOrDefault(album => album.Name == listBoxUserAlbums.SelectedItem.ToString());

            if (m_AlbumForm == null)
            {
                m_AlbumForm = new FormAlbum(selectedAlbum);
            }
            else
            {
                m_AlbumForm.AlbumPhotos = selectedAlbum;
            }

            if (selectedAlbum.Photos?.Count > 0)
            {
                Hide();
                m_AlbumForm.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("This album does not have photos in it.", "Empty album");
            }
        }

        private void buttonFriendQuiz_Click(object sender, EventArgs e)
        {
            User selectedFriend = m_LoggedInUser.Friends.FirstOrDefault(friend => friend == listBoxUserFriends.SelectedItem);

            if (m_FriendQuizForm == null)
            {
                m_FriendQuizForm = new FriendQuizForm(selectedFriend);
            }
            else
            {
                m_FriendQuizForm.Friend = selectedFriend;
            }

            Hide();
            m_FriendQuizForm.ShowDialog();
            Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoggedInUser = null;
            buttonLogin.Enabled = true;
            changeVisiblityOfUserProerties();
            buttonLogin.Text = "Login";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            logIn();
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
        }

        private void richTextBoxPostStatus_Click(object sender, EventArgs e)
        {
            richTextBoxPostStatus.Text = string.Empty;
        }
    }
}
