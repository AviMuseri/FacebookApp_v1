using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal interface IAlbumPhotosFilter
    {
         List<string> FilterAlbumByDate(string i_DateToFilter);
         List<string> FilterAlbumByLocation(string i_LocationToFilter);
        List<string> FilterAlbumByLocationAndDate(string i_LocationToFilter, string i_DateToFilter);
    }
}
