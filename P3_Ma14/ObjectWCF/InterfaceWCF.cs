using Database._3._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
  
    [ServiceContract]
    public interface IPhoto
    {
        [OperationContract]
        List<Photo> GetPhotos();

        [OperationContract]
        List<Photo> SearchPhotoByName(string name);

        [OperationContract]
        List<Photo> SearchPhotoByTag(string tag);
    }

    [ServiceContract]
    public interface ITags
    {
        [OperationContract]
        List<Tags> SearchTagByPhotoId(int id);
    }

    [ServiceContract]
    public interface IMedia: IPhoto, ITags
    {

    }
}
