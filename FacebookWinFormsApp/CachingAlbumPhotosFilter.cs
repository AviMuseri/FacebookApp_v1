using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures 
{
    internal class CachingAlbumPhotosFilter : IAlbumPhotosFilter
    {
        private readonly FacebookObjectCollection<Photo> r_AlbumPhotosFilter;

        private DateTime m_LastTimeUpdateAlbumPhotosCaching;
        public List<string> FilterAlbumByDate(string i_DateToFilter)
        {
            return r_AlbumPhotosFilter.Where(photo => photo.CreatedTime?.Date.ToString() == i_DateToFilter).ToList().Select(photo => string.IsNullOrEmpty(photo.Name) ? photo.CreatedTime.ToString() : photo.Name).ToList();
        }

        public List<string> FilterAlbumByLocation(string i_LocationToFilter)
        {
            return r_AlbumPhotosFilter.Where(photo => photo.Place?.Location?.City.ToString() == i_LocationToFilter).ToList()
                   .Select(photo => string.IsNullOrEmpty(photo.Name) ? photo.CreatedTime.ToString() : photo.Name).ToList();
        }

        public List<string> FilterAlbumByLocationAndDate(string i_LocationToFilter, string i_DateToFilter)
        {
            return r_AlbumPhotosFilter.Where(photo => photo.CreatedTime?.Date.ToString() == i_DateToFilter
                     && photo.Place?.Location?.City.ToString() == i_LocationToFilter).ToList()
                     .Select(photo => string.IsNullOrEmpty(photo.Name) ? photo.CreatedTime.ToString() : photo.Name).ToList();
        }
    }
}
