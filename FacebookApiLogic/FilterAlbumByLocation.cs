using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    internal class FilterAlbumByLocation : IAlbumPhotosFilterStrategy
    {
        public IEnumerable<Photo> AlbumFilter(string i_LocationToFilter, IEnumerable<Photo> i_AlbumToFilter)
        {
            return i_AlbumToFilter.Where(photo => photo.Place?.Location?.City.ToString() == i_LocationToFilter);
        }
    }
}
