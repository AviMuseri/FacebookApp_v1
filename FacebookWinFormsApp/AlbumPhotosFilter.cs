using System.Linq;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumPhotosFilter : IAlbumPhotosFilter
    {
        #region Members

        private readonly FacebookObjectCollection<Photo> r_AlbumPhotos;

        #endregion

        #region Constructor

        public AlbumPhotosFilter(FacebookObjectCollection<Photo> i_AlbumPhotos)
        {
            r_AlbumPhotos = i_AlbumPhotos;
        }

        #endregion

        public List<string> FilterAlbumByDate(string i_DateToFilter)
        {
            return r_AlbumPhotos.Where(photo => photo.CreatedTime?.Date.ToString() == i_DateToFilter).ToList().Select(photo => string.IsNullOrEmpty(photo.Name) ? photo.CreatedTime.ToString() : photo.Name).ToList();
        }

        public List<string> FilterAlbumByLocation(string i_LocationToFilter)
        {
            return r_AlbumPhotos.Where(photo => photo.Place?.Location?.City.ToString() == i_LocationToFilter).ToList()
                   .Select(photo => string.IsNullOrEmpty(photo.Name) ? photo.CreatedTime.ToString() : photo.Name).ToList();
        }

        public List<string> FilterAlbumByLocationAndDate(string i_LocationToFilter, string i_DateToFilter)
        {
            return r_AlbumPhotos.Where(photo => photo.CreatedTime?.Date.ToString() == i_DateToFilter
                     && photo.Place?.Location?.City.ToString() == i_LocationToFilter).ToList()
                     .Select(photo => string.IsNullOrEmpty(photo.Name) ? photo.CreatedTime.ToString() : photo.Name).ToList();
        }
    }
}
