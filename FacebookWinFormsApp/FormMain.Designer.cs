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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label localeLabel;
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.groupBoxUserFriends = new System.Windows.Forms.GroupBox();
            this.labelFriendBirthDay = new System.Windows.Forms.Label();
            this.labelFriendLocale = new System.Windows.Forms.Label();
            this.labelFriendEmail = new System.Windows.Forms.Label();
            this.buttonFriendQuiz = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxUserFriends = new System.Windows.Forms.ListBox();
            this.groupBoxAlbums = new System.Windows.Forms.GroupBox();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.buttonShowAlbumPhotos = new System.Windows.Forms.Button();
            this.listBoxUserAlbums = new System.Windows.Forms.ListBox();
            this.groupBoxPostStatus = new System.Windows.Forms.GroupBox();
            this.richTextBoxPostStatus = new System.Windows.Forms.RichTextBox();
            this.groupBoxMyPosts = new System.Windows.Forms.GroupBox();
            this.listBoxUserPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.localeLabel1 = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            this.groupBoxUserFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.groupBoxAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.groupBoxPostStatus.SuspendLayout();
            this.groupBoxMyPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(118, 161);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(38, 13);
            countLabel.TabIndex = 66;
            countLabel.Text = "Count:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(118, 184);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel.TabIndex = 68;
            createdTimeLabel.Text = "Created Time:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(8, 131);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 0;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(8, 154);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Location = new System.Drawing.Point(8, 177);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(42, 13);
            localeLabel.TabIndex = 6;
            localeLabel.Text = "Locale:";
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
            this.groupBoxUserFriends.Size = new System.Drawing.Size(390, 292);
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
            this.groupBoxAlbums.Controls.Add(countLabel);
            this.groupBoxAlbums.Controls.Add(this.countLabel1);
            this.groupBoxAlbums.Controls.Add(createdTimeLabel);
            this.groupBoxAlbums.Controls.Add(this.createdTimeLabel1);
            this.groupBoxAlbums.Controls.Add(this.imageAlbumPictureBox);
            this.groupBoxAlbums.Controls.Add(this.buttonFetchAlbums);
            this.groupBoxAlbums.Controls.Add(this.buttonShowAlbumPhotos);
            this.groupBoxAlbums.Controls.Add(this.listBoxUserAlbums);
            this.groupBoxAlbums.Enabled = false;
            this.groupBoxAlbums.Location = new System.Drawing.Point(440, 295);
            this.groupBoxAlbums.Name = "groupBoxAlbums";
            this.groupBoxAlbums.Size = new System.Drawing.Size(410, 303);
            this.groupBoxAlbums.TabIndex = 57;
            this.groupBoxAlbums.TabStop = false;
            this.groupBoxAlbums.Text = "My Albums";
            // 
            // countLabel1
            // 
            this.countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Count", true));
            this.countLabel1.Location = new System.Drawing.Point(197, 161);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(100, 23);
            this.countLabel1.TabIndex = 67;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(197, 184);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 69;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(0, 159);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(100, 100);
            this.imageAlbumPictureBox.TabIndex = 71;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Location = new System.Drawing.Point(245, 237);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(130, 23);
            this.buttonFetchAlbums.TabIndex = 66;
            this.buttonFetchAlbums.Text = "Fetch Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // buttonShowAlbumPhotos
            // 
            this.buttonShowAlbumPhotos.Enabled = false;
            this.buttonShowAlbumPhotos.Location = new System.Drawing.Point(109, 236);
            this.buttonShowAlbumPhotos.Name = "buttonShowAlbumPhotos";
            this.buttonShowAlbumPhotos.Size = new System.Drawing.Size(130, 24);
            this.buttonShowAlbumPhotos.TabIndex = 60;
            this.buttonShowAlbumPhotos.Text = "Show Album\'s Photos";
            this.buttonShowAlbumPhotos.UseVisualStyleBackColor = true;
            this.buttonShowAlbumPhotos.Click += new System.EventHandler(this.buttonShowAlbumPictures_Click);
            // 
            // listBoxUserAlbums
            // 
            this.listBoxUserAlbums.DataSource = this.albumBindingSource;
            this.listBoxUserAlbums.DisplayMember = "Name";
            this.listBoxUserAlbums.FormattingEnabled = true;
            this.listBoxUserAlbums.Location = new System.Drawing.Point(0, 19);
            this.listBoxUserAlbums.Name = "listBoxUserAlbums";
            this.listBoxUserAlbums.Size = new System.Drawing.Size(390, 134);
            this.listBoxUserAlbums.TabIndex = 1;
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
            this.listBoxUserPosts.DataSource = this.postBindingSource;
            this.listBoxUserPosts.DisplayMember = "Description";
            this.listBoxUserPosts.FormattingEnabled = true;
            this.listBoxUserPosts.Location = new System.Drawing.Point(0, 19);
            this.listBoxUserPosts.Name = "listBoxUserPosts";
            this.listBoxUserPosts.Size = new System.Drawing.Size(633, 147);
            this.listBoxUserPosts.TabIndex = 60;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(birthdayLabel);
            this.groupBox1.Controls.Add(this.birthdayLabel1);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailLabel1);
            this.groupBox1.Controls.Add(this.imageNormalPictureBox);
            this.groupBox1.Controls.Add(localeLabel);
            this.groupBox1.Controls.Add(this.localeLabel1);
            this.groupBox1.Location = new System.Drawing.Point(2, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 222);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(89, 131);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(89, 154);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(100, 23);
            this.emailLabel1.TabIndex = 3;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(10, 19);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 100);
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // localeLabel1
            // 
            this.localeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true));
            this.localeLabel1.Location = new System.Drawing.Point(89, 177);
            this.localeLabel1.Name = "localeLabel1";
            this.localeLabel1.Size = new System.Drawing.Size(100, 23);
            this.localeLabel1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxMyPosts);
            this.Controls.Add(this.groupBoxPostStatus);
            this.Controls.Add(this.groupBoxAlbums);
            this.Controls.Add(this.groupBoxUserFriends);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.groupBoxUserFriends.ResumeLayout(false);
            this.groupBoxUserFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.groupBoxAlbums.ResumeLayout(false);
            this.groupBoxAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.groupBoxPostStatus.ResumeLayout(false);
            this.groupBoxMyPosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.GroupBox groupBoxUserFriends;
        private System.Windows.Forms.ListBox listBoxUserFriends;
        private System.Windows.Forms.GroupBox groupBoxAlbums;
        private System.Windows.Forms.ListBox listBoxUserAlbums;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.GroupBox groupBoxPostStatus;
        private System.Windows.Forms.RichTextBox richTextBoxPostStatus;
        private System.Windows.Forms.GroupBox groupBoxMyPosts;
        private System.Windows.Forms.Button buttonShowAlbumPhotos;
        private System.Windows.Forms.ListBox listBoxUserPosts;
        private System.Windows.Forms.Button buttonFriendQuiz;
        private System.Windows.Forms.Label labelFriendEmail;
        private System.Windows.Forms.Label labelFriendLocale;
        private System.Windows.Forms.Label labelFriendBirthDay;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label localeLabel1;
    }
}
