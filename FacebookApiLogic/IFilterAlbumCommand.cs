using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApiLogic
{
    internal interface IFilterAlbumCommand
    {
        IEnumerable<Photo> Execute();

        string ParamToFilter { get;  set; }

        IEnumerable<Photo> AlbumToFilter { get; set; }

        IAlbumPhotosFilterStrategy FilterStrategy { get; set; }
    }
}
