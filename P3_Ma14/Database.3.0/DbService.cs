using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database._3._0
{
    public class DbService
    {
        static void Main(string[] args)
        {
            Model1Container context = new Model1Container();
            context.Photos.Add(new Photo() { Name = "first photo", Event = "munte", Url = "./photos", Id = 0 });
            context.Photos.Add(new Photo() { Name = "second photo", Event = "mare", Url = "./photos", Id = 1 });
            context.Photos.Add(new Photo() { Name = "third photo", Event = "botez", Url = "./photos", Id = 2 });
            context.Photos.Add(new Photo() { Name = "fourth photo", Event = "nunta", Url = "./photos", Id = 3 });
            context.Photos.Add(new Photo() { Name = "fifth photo", Event = "cununie", Url = "./photos", Id = 4 });
            context.Photos.Add(new Photo() { Name = "sixth photo", Event = "zi de nastere", Url = "./photos", Id = 5 });
            context.Photos.Add(new Photo() { Name = "seventh photo", Event = "munte", Url = "./photos", Id = 6 });
            context.Photos.Add(new Photo() { Name = "eigth photo", Event = "munte", Url = "./photos", Id = 7 });

            context.Tags.Add(new Tags() { Id = 1, Name = "first tag", PhotoId = 1 });
            context.Tags.Add(new Tags() { Id = 2, Name = "third tag", PhotoId = 1 });
            context.Tags.Add(new Tags() { Id = 3, Name = "fourth tag", PhotoId = 1 });
            context.Tags.Add(new Tags() { Id = 4, Name = "third tag", PhotoId = 2 });
            context.Tags.Add(new Tags() { Id = 5, Name = "fourth tag", PhotoId = 2 });
            context.Tags.Add(new Tags() { Id = 6, Name = "third tag", PhotoId = 3 });
            context.Tags.Add(new Tags() { Id = 7, Name = "fourth tag", PhotoId = 4 });
            context.SaveChanges();
        }

        public List<Photo> GetAll()
        {
            using (Model1Container context = new Model1Container())
            {
                var result = context.Photos.ToList();
                return result;
            }
        }

        public List<Photo> SearchByName(string name)
        {
            using (Model1Container context = new Model1Container())
            {
                var result = context.Photos.Where(x => x.Name.StartsWith(name)).ToList();
                return result;
            }
        }

        public List<Photo> SearchPhotoByTag(string tag)
        {
            using (Model1Container context = new Model1Container())
            {
                List<Photo> result = new List<Photo>();
                var tags = context.Tags.Where(x => x.Name.StartsWith(tag)).ToList();
                foreach (var tagObject in tags)
                {
                    var item = context.Photos.Where(x => x.Id ==tagObject.PhotoId).SingleOrDefault();
                    result.Add(item);
                }
                return result;
            }
        }

        public List<Tags> SearchTagByPhotoId(int id)
        {
            using(Model1Container context = new Model1Container())
            {
                var result = context.Tags.Where(x => x.PhotoId == id).ToList();
                return result;
            }
        }

    }
}
