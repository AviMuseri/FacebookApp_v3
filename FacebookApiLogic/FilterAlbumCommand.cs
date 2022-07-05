using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    internal class FilterAlbumCommand : IFilterAlbumCommand
    {
        #region Properties

        public string ParamToFilter { get; set; }

        public IEnumerable<Photo> AlbumToFilter { get; set; }

        public IAlbumPhotosFilterStrategy FilterStrategy { get; set; }

        #endregion

        #region Constructor

        public FilterAlbumCommand(string i_ParamToFilter, IEnumerable<Photo> i_AlbumToFilter, IAlbumPhotosFilterStrategy i_FilterStrategy)
        {
            ParamToFilter = i_ParamToFilter;
            AlbumToFilter = i_AlbumToFilter;
            FilterStrategy = i_FilterStrategy;
        }

        #endregion

        public IEnumerable<Photo> Execute()
        {
            return FilterStrategy.AlbumFilter(ParamToFilter, AlbumToFilter);
        }
    }
}
