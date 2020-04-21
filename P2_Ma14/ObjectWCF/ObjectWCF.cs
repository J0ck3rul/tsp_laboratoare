using Database;
using Database.API;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF
{
    public class MyMedia : IMedia
    {
        private PersonsService _personsService = new PersonsService();
        private MediaService _mediaService = new MediaService();
        private TagsService _tagsService = new TagsService();
        public void CreateMedia(Media media)
        {
            _mediaService.Create(media);
        }

        public void DeleteMedia(int id)
        {
            _mediaService.Delete(id);
        }

        public IReadOnlyCollection<Media> GetAllMedia()
        {
            return _mediaService.GetAll();
        }

        public Media GetMediaById(int id)
        {
            return _mediaService.GetById(id);
        }

        public IReadOnlyCollection<Media> SearchMediaByName(string name)
        {
            return _mediaService.SearchByName(name);
        }

        void IMedia.UpdateMedia(Media media, int id)
        {
            _mediaService.Update(media, id);
        }

                public void CreateTag(Tags model)
        {
            _tagsService.Create(model);
        }

        public void DeleteTag(int id)
        {
            _tagsService.Delete(id);
        }

        public IReadOnlyCollection<Tags> GetAllTags()
        {
            return _tagsService.GetAll();
        }

        public Tags GetByTagId(int id)
        {
            return _tagsService.GetById(id);
        }

        public IReadOnlyCollection<Tags> GetByMediaId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTag(Tags model, int id)
        {
            _tagsService.Update(model, id);
        }

        public void CretePerson(Persons model)
        {
            _personsService.Create(model);
        }

        public void DeletePerson(int id)
        {
            _personsService.Delete(id);
        }

        public IReadOnlyCollection<Persons> GetAllPersons()
        {
            return _personsService.GetAll();
        }

        public Persons GetPersonsById(int id)
        {
            return _personsService.GetById(id);
        }

        public IReadOnlyCollection<Persons> GetByPersonsId(int id)
        {
            return _personsService.GetByMediaId(id);
        }

        public void UpdatePerson(Persons model, int id)
        {
            _personsService.Update(model, id);
        }

  
    }
}
