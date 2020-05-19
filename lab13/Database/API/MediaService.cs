using Database.Model;
using System.Collections.Generic;
using System.Linq;

namespace Database.API
{
    public class MediaService
    {
        private readonly Database<Media> _mediaRepo;
        public MediaService()
        {
            _mediaRepo = new Database<Media>();
        }

        public IReadOnlyList<Media> GetAll()
        {
            return _mediaRepo.GetAll();
        }

        public Media GetById(int id)
        {
            return _mediaRepo.GetById(id);
        }

        public IReadOnlyList<Media> SearchByName(string name)
        {
            return _mediaRepo.GetAll().Where(x => x.Name.Contains(name)).ToList();
        }

        public void Create(Media media)
        {
            _mediaRepo.Insert(media);
        }

        public void Update(Media media, int id)
        {
            _mediaRepo.Update(media, id);
        }

        public void Delete(int id)
        {
            _mediaRepo.Delete(id);
        }
    }
}
