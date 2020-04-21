using Database.Model;
using System.Collections.Generic;
using System.Linq;

namespace Database
{
    public class TagsService
    {
        private readonly Database<Tags> _tagsRepo;
        public TagsService()
        {
            _tagsRepo = new Database<Tags>();
        }

        public IReadOnlyList<Tags> GetAll()
        {
            return _tagsRepo.GetAll();
        }

        public Tags GetById(int id)
        {
            return _tagsRepo.GetById(id);
        }

      
        public void Create(Tags model)
        {
            _tagsRepo.Insert(model);
        }

        public void Update(Tags model, int id)
        {
            _tagsRepo.Update(model, id);
        }

        public void Delete(int id)
        {
            _tagsRepo.Delete(id);
        }
    }
}