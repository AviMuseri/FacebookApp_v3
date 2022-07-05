using System.Windows.Forms;
using System.Linq;
using System.Data;
using System;
using FacebookWrapper.ObjectModel;
using FacebookApiLogic;

namespace BasicFacebookFeatures
{
    public partial class FormAlbum : Form
    {
        #region Members

        private readonly AlbumPhotosFilterFacade r_albumPhotosFilter; 
        private FacebookObjectCollection<Photo> m_AlbumOfPhotos;

        #endregion

        #region Constructor

        public FormAlbum(FacebookObjectCollection<Photo> i_AlbumOfPhotos)
        {
            m_AlbumOfPhotos = i_AlbumOfPhotos;
            r_albumPhotosFilter = new AlbumPhotosFilterFacade();
            InitializeComponent();
            initiailizeListBoxes();
        }

        #endregion

        #region Properties

        public FacebookObjectCollection<Photo> AlbumPhotos
        {
            set
            {
                m_AlbumOfPhotos = value;
                listBoxAlbumPhotos.DataSource = value;
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
                listBoxAlbumPhotos.DataSource = r_albumPhotosFilter.FilterAlbumByLocationAndDate(selectedLocationFilter, selectedPhotoDateFilter, m_AlbumOfPhotos).ToList();
            }
            else if (checkBoxDateFilter.Checked)
            {
                listBoxAlbumPhotos.DataSource = r_albumPhotosFilter.FilterAlbumByDate(selectedPhotoDateFilter, m_AlbumOfPhotos).ToList();
            }
            else if (checkBoxLocationFilter.Checked)
            {
                listBoxAlbumPhotos.DataSource = r_albumPhotosFilter.FilterAlbumByLocation(selectedLocationFilter, m_AlbumOfPhotos).ToList();
            }
        }

        #region Initialize Album Photos & Date Filter & Location Filter ListBoxes

        private void initiailizeListBoxes()
        {
            listBoxDateFilter.DataSource = m_AlbumOfPhotos.Select(photo => photo.CreatedTime?.Date).Distinct().ToList();
            listBoxLocationFilter.DataSource = m_AlbumOfPhotos.Select(photo => photo.Place?.Location?.City).Distinct().Where(location => !string.IsNullOrEmpty(location)).ToList();
            listBoxAlbumPhotos.DataSource = m_AlbumOfPhotos;
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
            Photo selectedPhoto = listBoxAlbumPhotos.SelectedItem as Photo;
            pictureBoxPhotoFromAlbum.LoadAsync
                (m_AlbumOfPhotos.First(photo => photo.Name == selectedPhoto.Name
                || photo.CreatedTime == selectedPhoto.CreatedTime).PictureNormalURL);
        }
    }
}
