using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    public interface IUserDataAdapter
    {
        UserDataForQuiz GetUserDataForQuiz();

        void SelectedFriendChanged(object i_ListBoxFriends, EventArgs i_Friend);
    }
}
