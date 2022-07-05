using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    internal class SubSystemAlbumPhotosFilter
    {
        #region Properties

        private IFilterAlbumCommand m_FilterAlbumCommand;
        private IAlbumPhotosFilterStrategy m_FilterAlbumByDateStrategy;
        private IAlbumPhotosFilterStrategy m_FilterAlbumByLocationStrategy;

        #endregion

        #region Constructor

        public SubSystemAlbumPhotosFilter()
        {
            m_FilterAlbumByDateStrategy = new FilterAlbumByDate();
            m_FilterAlbumByLocationStrategy = new FilterAlbumByLocation();
        }

        #endregion

        #region Methods

        public IEnumerable<Photo> FilterAlbumByLocationAndDate(string i_LocationToFilter, string i_DateToFilter, IEnumerable<Photo> i_AlbumToFilter)
        {
            return FilterAlbumByLocationOrDate(i_LocationToFilter, FilterAlbumByLocationOrDate(i_DateToFilter, i_AlbumToFilter));
        }

        public IEnumerable<Photo> FilterAlbumByLocationOrDate(string i_ParamToFilter, IEnumerable<Photo> i_AlbumToFilter)
        {
            if (m_FilterAlbumCommand is null)
            {
                m_FilterAlbumCommand = new FilterAlbumCommand(i_ParamToFilter, i_AlbumToFilter, getSpecificStrategy(i_ParamToFilter));
            }
            else
            {
                m_FilterAlbumCommand.FilterStrategy = getSpecificStrategy(i_ParamToFilter);
                m_FilterAlbumCommand.ParamToFilter = i_ParamToFilter;
                m_FilterAlbumCommand.AlbumToFilter = i_AlbumToFilter;
            }

            return m_FilterAlbumCommand.Execute();
        }

        private IAlbumPhotosFilterStrategy getSpecificStrategy(string i_ParamToFilter)
        {
            DateTime dateTimeParseResult;

            return DateTime.TryParse(i_ParamToFilter, out dateTimeParseResult) ? m_FilterAlbumByDateStrategy : m_FilterAlbumByLocationStrategy;
        }

        #endregion
    }
}
