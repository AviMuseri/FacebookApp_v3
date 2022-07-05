using System.Linq;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    public class AlbumPhotosFilterFacade 
    {
        #region Members

        #region Sub Sysyems

        private readonly SubSystemAlbumPhotosFilter r_SubSystemAlbumPhotosFilter;

        #endregion

        #endregion

        #region Constructor

        public AlbumPhotosFilterFacade()
        {
           r_SubSystemAlbumPhotosFilter = new SubSystemAlbumPhotosFilter();
        }

        #endregion

        public IEnumerable<Photo> FilterAlbumByDate(string i_DateToFilter, FacebookObjectCollection<Photo> i_AlbumToFilter)
        {
            return r_SubSystemAlbumPhotosFilter.FilterAlbumByLocationOrDate(i_DateToFilter, i_AlbumToFilter);
        }

        public IEnumerable<Photo> FilterAlbumByLocation(string i_LocationToFilter, FacebookObjectCollection<Photo> i_AlbumToFilter)
        {
            return r_SubSystemAlbumPhotosFilter.FilterAlbumByLocationOrDate(i_LocationToFilter, i_AlbumToFilter);
        }

        public IEnumerable<Photo> FilterAlbumByLocationAndDate(string i_LocationToFilter, string i_DateToFilter, FacebookObjectCollection<Photo> i_AlbumToFilter)
        {
            return r_SubSystemAlbumPhotosFilter.FilterAlbumByLocationAndDate(i_LocationToFilter, i_DateToFilter, i_AlbumToFilter);
        }
    }
}
