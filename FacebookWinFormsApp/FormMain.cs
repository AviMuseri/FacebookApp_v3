using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookApiLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        #region Members

        private const string k_LabelDefaultFormatHomeTown = "Home Town: ";
        private const string k_LabelDefaultFormatBirthDay = "Birthday: ";
        private const string k_LabelDefaultFormatEmail = "Email: ";
        private const int k_NumberOfAnswersPerQuestion = 4;
        private FriendQuizForm m_FriendQuizForm;
        private FormAlbum m_AlbumForm;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private IUserDataAdapter m_UserDataAdapter;

        #endregion

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_UserDataAdapter = new UserDataAdapter();
            listBoxUserFriends.SelectedIndexChanged += new EventHandler(m_UserDataAdapter.SelectedFriendChanged);
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
                 = groupBoxMyPosts.Enabled = m_LoggedInUser != null;
        }

        private void fetchProfileData()
        {
            new Thread(initializeListBoxFriends).Start();
            new Thread(initializeListBoxPosts).Start();
        }

        #region Initialize Posts & Friends List Boxes

        private void initializeListBoxPosts()
        {
            listBoxUserPosts.Invoke(new Action(() => postBindingSource.DataSource = m_LoggedInUser.Posts));
        }

        private void initializeListBoxFriends()
        {
            if (m_LoggedInUser.Friends != null)
            {
                listBoxUserFriends.Invoke(new Action(() => listBoxUserFriends.DataSource = m_LoggedInUser.Friends));
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

        #region Load Friend Properties

        private void loadFriendProperties()
        {
            User selectedFriend = listBoxUserFriends.SelectedItem as User;

            pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
            labelFriendLocale.Text = $"{k_LabelDefaultFormatHomeTown}{selectedFriend.Locale}";
            labelFriendEmail.Text = $"{k_LabelDefaultFormatEmail}{selectedFriend.Email}";
            labelFriendBirthDay.Text = $"{k_LabelDefaultFormatBirthDay}{selectedFriend.Birthday}";
        }

        #endregion

        private void listBoxUserFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFriendProperties();
        }

        private void buttonShowAlbumPictures_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Photo> selectedAlbum = (listBoxUserAlbums.SelectedItem as Album).Photos;

            if (m_AlbumForm == null)
            {
                m_AlbumForm = new FormAlbum(selectedAlbum);
            }
            else
            {
                m_AlbumForm.AlbumPhotos = selectedAlbum;
            }

            if (selectedAlbum?.Count > 0)
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
            m_FriendQuizForm = new FriendQuizForm(m_UserDataAdapter.GetUserDataForQuiz(), k_NumberOfAnswersPerQuestion);

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
            userBindingSource.DataSource = m_LoggedInUser;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
        }

        private void richTextBoxPostStatus_Click(object sender, EventArgs e)
        {
            richTextBoxPostStatus.Text = string.Empty;
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            albumBindingSource.DataSource = m_LoggedInUser.Albums;
            buttonShowAlbumPhotos.Enabled = true;
        }
    }
}
