using Database.Model;
using System.Collections.Generic;
using System.Linq;

namespace Database
{
    public class PersonsService
    {
        private readonly Database<Persons> _personsRepo;
        public PersonsService()
        {
            _personsRepo = new Database<Persons>();
        }

        public IReadOnlyList<Persons> GetAll()
        {
            return _personsRepo.GetAll();
        }

        public Persons GetById(int id)
        {
            return _personsRepo.GetById(id);
        }

        public IReadOnlyList<Persons> GetByMediaId(int id)
        {
            return GetAll().Where(x => x.MediaId == id).ToList();
        }
        public void Create(Persons model)
        {
            _personsRepo.Insert(model);
        }

        public void Update(Persons model, int id)
        {
            _personsRepo.Update(model, id);
        }

        public void Delete(int id)
        {
            _personsRepo.Delete(id);
        }
    }
}