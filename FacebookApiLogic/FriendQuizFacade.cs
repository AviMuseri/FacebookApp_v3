using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    public class FriendQuizFacade
    {
        #region Members

        private static readonly object sr_FriendQuizFacadeLock = new object();
        private static SubSysyemFriendQuiz m_SubSystemFriendQuiz;
        private static FriendQuizFacade s_FriendQuizFacadeInstance;

        #endregion

        #region Constructor

        private FriendQuizFacade(int i_NumberOfAnswersPerQuestion, UserDataForQuiz i_UserDataForQuiz)
        {
            m_SubSystemFriendQuiz = new SubSysyemFriendQuiz(i_UserDataForQuiz, i_NumberOfAnswersPerQuestion);
        }

        #endregion

        #region Methods

        public static FriendQuizFacade GetFriendQuizFacade(int i_NumberOfAnswersPerQuestion, UserDataForQuiz i_UserDataForQuiz)
        {
            lock(sr_FriendQuizFacadeLock)
            {
                if(s_FriendQuizFacadeInstance == null)
                {
                    s_FriendQuizFacadeInstance = new FriendQuizFacade(i_NumberOfAnswersPerQuestion, i_UserDataForQuiz);
                }
                else
                {
                    m_SubSystemFriendQuiz = new SubSysyemFriendQuiz(i_UserDataForQuiz, i_NumberOfAnswersPerQuestion);
                }
            }

            return s_FriendQuizFacadeInstance;
        }

        public string GetFriendFullName()
        {
            return m_SubSystemFriendQuiz.FriendName;
        }

        public string GetFriendPhotoURL()
        {
            return m_SubSystemFriendQuiz.FriendPhotoURL;
        }

        public string RandomNextQuizQuestion(out List<string> o_AnswersForQuestion, out bool io_IsTheQuizEnds)
        {
            return m_SubSystemFriendQuiz.RandomNextQuizQuestion(out o_AnswersForQuestion, out io_IsTheQuizEnds);
        }

        public void CheckQuestion(int i_AnswerIndex)
        {
            m_SubSystemFriendQuiz.CheckQuestion(i_AnswerIndex);
        }

        public void StartNewQuiz(UserDataForQuiz i_FriendDataForQuiz, int i_NumberOfAnswersPerQuestion)
        {
            m_SubSystemFriendQuiz = new SubSysyemFriendQuiz(i_FriendDataForQuiz, i_NumberOfAnswersPerQuestion);
        }

        #endregion
    }
}
