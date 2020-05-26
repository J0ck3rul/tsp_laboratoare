using Database._3._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    public class Media : IMedia
    {
        DbService service = new DbService();
        public List<Photo> GetPhotos()
        {
            return service.GetAll();
        }

        public List<Photo> SearchPhotoByName(string name)
        {
            return service.SearchByName(name);
        }

        public List<Photo> SearchPhotoByTag(string tag)
        {
            return service.SearchPhotoByTag(tag);
        }

        public List<Tags> SearchTagByPhotoId(int id)
        {
            return service.SearchTagByPhotoId(id);
        }
    }
}
