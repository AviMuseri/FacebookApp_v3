using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    public class UserDataForQuiz
    {
        #region Properties

        public string UserBirthDay { get; private set; }

        public string UserBirthMonth { get; private set; }

        public string UserBirthYear { get; private set; }

        public string UserUrlPhoto { get; private set; }

        public string UserFullName { get; private set; }

        public string UserRealationshipStatus { get; private set; }

        #endregion

        #region Constructor

        public UserDataForQuiz(string i_UserBirthDay, string i_UserBirthMoth, string i_UserBirthYear, string i_UserUrlPhoto, string i_UserFullName, string i_UserRealationshipStatus)
        {
            UserBirthDay = i_UserBirthDay;
            UserBirthMonth = i_UserBirthMoth;
            UserBirthYear = i_UserBirthYear;
            UserUrlPhoto = i_UserUrlPhoto;
            UserFullName = i_UserFullName;
            UserRealationshipStatus = i_UserRealationshipStatus;
        }

        #endregion
    }
}
