using System.Windows.Forms;
using System.Linq;
using System.Data;
using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormAlbum : Form
    {
        #region Members

        private readonly AlbumPhotosFilter r_albumPhotosFilter;
        private Album m_AlbumOfPhotos;

        #endregion

        #region Constructor

        public FormAlbum(Album i_AlbumOfPhotos)
        {
            m_AlbumOfPhotos = i_AlbumOfPhotos;
            r_albumPhotosFilter = new AlbumPhotosFilter(m_AlbumOfPhotos.Photos);
            InitializeComponent();
            initiailizeListBoxes(   );
        }

        #endregion

        #region Properties

        public Album AlbumPhotos
        {
            set
            {
                m_AlbumOfPhotos = value;
            }
        }

        #endregion

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filterPhotos();
        }

        private void filterPhotos()
        {
            string selectedPhotoDateFilter = Convert.ToDateTime(listBoxDateFilter.SelectedItem).Date.ToString();
            string selectedLocationFilter = listBoxLocationFilter.SelectedItem.ToString();

            if (checkBoxDateFilter.Checked && checkBoxLocationFilter.Checked)
            {
                listBoxAlbumPhotos.DataSource = r_albumPhotosFilter.FilterAlbumByLocationAndDate(selectedLocationFilter, selectedPhotoDateFilter);
            }
            else if (checkBoxDateFilter.Checked)
            {
                listBoxAlbumPhotos.DataSource = r_albumPhotosFilter.FilterAlbumByDate(selectedPhotoDateFilter);
            }
            else if (checkBoxLocationFilter.Checked)
            {
                listBoxAlbumPhotos.DataSource = r_albumPhotosFilter.FilterAlbumByLocation(selectedLocationFilter);
            }
        }

        #region Initialize Album Photos & Date Filter & Location Filter ListBoxes

        private void initiailizeListBoxes()
        {
            listBoxDateFilter.DataSource = m_AlbumOfPhotos.Photos.Select(photo => photo.CreatedTime?.Date).Distinct().ToList();
            listBoxLocationFilter.DataSource = m_AlbumOfPhotos.Photos.Select(photo => photo.Place?.Location?.City).Distinct().ToList().Where(location => !string.IsNullOrEmpty(location)).ToList();
            initializeAlbumPhotosListBox();
        }

        private void initializeAlbumPhotosListBox()
        {
            foreach (Photo photo in m_AlbumOfPhotos.Photos)
            {
                listBoxAlbumPhotos.Items.Add(string.IsNullOrEmpty(photo.Name) ? photo.CreatedTime.ToString() : photo.Name);
            }
        }

        #endregion

        private void checkBoxDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            listBoxDateFilter.Enabled = checkBoxDateFilter.Checked;
            checkEnableForFilterButton();
        }

        private void checkEnableForFilterButton()
        {
            buttonFilter.Enabled = checkBoxDateFilter.Checked || checkBoxLocationFilter.Checked;
        }

        private void checkBoxLocationFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxLocationFilter.Items.Count > 0)
            {
                listBoxLocationFilter.Enabled = checkBoxLocationFilter.Checked;
                checkEnableForFilterButton();
            }
            else
            {
                MessageBox.Show("Location is undefined in this album.", "Location Filter");
                checkBoxLocationFilter.Checked = false;
            }
        }

        private void listBoxAlbumPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPhotoFromAlbum.LoadAsync
                (m_AlbumOfPhotos.Photos.First(photo => photo.Name == listBoxAlbumPhotos.SelectedItem.ToString()
                || photo.CreatedTime.ToString() == listBoxAlbumPhotos.SelectedItem.ToString()).PictureNormalURL);
        }
    }
}
