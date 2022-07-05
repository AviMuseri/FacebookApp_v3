using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    public class UserDataAdapter : IUserDataAdapter
    {
        #region Members

        private const string k_FormatBirthday = "d";
        private User m_User;

        #endregion

        public UserDataForQuiz GetUserDataForQuiz()
        {
            CultureInfo providerForBirthDay = CultureInfo.InvariantCulture;
            DateTime userBirthDay = DateTime.ParseExact(m_User.Birthday, k_FormatBirthday, providerForBirthDay);

            return new UserDataForQuiz(
                userBirthDay.Day.ToString(),
                userBirthDay.Month.ToString(),
                userBirthDay.Year.ToString(),
                m_User.PictureNormalURL,
                m_User.Name,
                nameof(m_User.RelationshipStatus));
        }

        public void SelectedFriendChanged(object i_ListBoxFriends, EventArgs i_Friend)
        {
            m_User = (i_ListBoxFriends as ListBox).SelectedItem as User;
        }
    }
}
