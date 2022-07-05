using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    internal class FilterAlbumByDate : IAlbumPhotosFilterStrategy
    {
        public IEnumerable<Photo> AlbumFilter(string i_DateToFilter, IEnumerable<Photo> i_AlbumToFilter)
        {
            return i_AlbumToFilter.Where(photo => photo.CreatedTime?.Date.ToString() == i_DateToFilter);
        }
    }
}
