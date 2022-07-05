using System.Windows.Forms;
using System.Collections.Generic;
using System;
using FacebookWrapper.ObjectModel;
using FacebookApiLogic;

namespace BasicFacebookFeatures
{
    public partial class FriendQuizForm : Form
    {
        #region Members
        
        private readonly FriendQuizFacade r_FriendQuizFacade;

        #endregion

        #region Constructor

        public FriendQuizForm(UserDataForQuiz i_UserDataForQuiz, int i_NumberOfAnswersPerQuestion)
        {
            r_FriendQuizFacade = FriendQuizFacade.GetFriendQuizFacade(i_NumberOfAnswersPerQuestion, i_UserDataForQuiz);
            InitializeComponent();
            intializeFormQuizFriendProperties();
            setControlsForNextQuestion();
        }

        #endregion

        #region Methods

        private void intializeFormQuizFriendProperties()
        {
            const string labelDefaultFormatFriend = "How well do you know";

            pictureBoxFriend.LoadAsync(r_FriendQuizFacade.GetFriendPhotoURL());
            labelTitleQuiz.Text = $"{labelDefaultFormatFriend}{Environment.NewLine}{r_FriendQuizFacade.GetFriendFullName()}?";
        }

        private void setControlsForNextQuestion()
        {
            List<string> questionAnswers;
            bool isQuizEnd;

            labelQuestion.Text = r_FriendQuizFacade.RandomNextQuizQuestion(out questionAnswers, out isQuizEnd);

            if (!isQuizEnd)
            {
                buttonAnswer1.Text = $"{questionAnswers[0]}";
                buttonAnswer2.Text = $"{questionAnswers[1]}";
                buttonAnswer3.Text = $"{questionAnswers[2]}";
                buttonAnswer4.Text = $"{questionAnswers[3]}";
            }
            else
            {
                buttonAnswer1.Enabled = buttonAnswer2.Enabled = buttonAnswer3.Enabled = buttonAnswer4.Enabled = false;
            }
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            int buttonIndex = 1;

            buttonAnswerClick(buttonIndex);
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            int buttonIndex = 2;

            buttonAnswerClick(buttonIndex);
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            int buttonIndex = 3;

            buttonAnswerClick(buttonIndex);
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            int buttonIndex = 4;

            buttonAnswerClick(buttonIndex);
        }

        private void buttonAnswerClick(int buttonIndex)
        {
            r_FriendQuizFacade.CheckQuestion(buttonIndex);
            setControlsForNextQuestion();
        }

        #endregion
    }
}
