using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    internal interface IAlbumPhotosFilterStrategy
    {
        IEnumerable<Photo> AlbumFilter(string i_ParamToFilter, IEnumerable<Photo> i_AlbumToFilter);
    }
}
