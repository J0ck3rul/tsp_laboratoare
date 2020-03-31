using Database;
using System;
using System.Collections.Generic;

namespace ObjectWCF
{
    public class MediaObject : InterfaceMedia
    {
        private MediaService _mediaService = new MediaService();
        public void Create(Media media)
        {
            _mediaService.Create(media);
        }

        public void Delete(int id)
        {
            _mediaService.Delete(id);
        }

        public IReadOnlyCollection<Media> GetAll()
        {
            return _mediaService.GetAll();
        }

        public Media GetById(int id)
        {
            return _mediaService.GetById(id);
        }

        public IReadOnlyCollection<Media> SearchByName(string name)
        {
            return _mediaService.SearchByName(name);
        }

        void InterfaceMedia.Update(Media media, int id)
        {
            _mediaService.Update(media, id);
        }
    }

    public class PersonsObject : InterfacePersons
    {

        private PersonsService _personsService = new PersonsService();
        public void Crete(Persons model)
        {
            _personsService.Create(model);
        }

        public void Delete(int id)
        {
            _personsService.Delete(id);
        }

        public IReadOnlyCollection<Persons> GetAll()
        {
            return _personsService.GetAll();
        }

        public Persons GetById(int id)
        {
            return _personsService.GetById(id);
        }

        public IReadOnlyCollection<Persons> GetByMediaId(int id)
        {
            return _personsService.GetByMediaId(id);
        }

        public void Update(Persons model, int id)
        {
            _personsService.Update(model, id);
        }
    }

    public class TagsObject : InterfaceTags
    {

        private TagsService _tagsService = new TagsService();
        public void Crete(Tags model)
        {
            _tagsService.Create(model);
        }

        public void Delete(int id)
        {
            _tagsService.Delete(id);
        }

        public IReadOnlyCollection<Tags> GetAll()
        {
            return _tagsService.GetAll();
        }

        public Tags GetById(int id)
        {
            return _tagsService.GetById(id);
        }

        public IReadOnlyCollection<Tags> GetByMediaId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Tags model, int id)
        {
            _tagsService.Update(model, id);
        }
    }
}
