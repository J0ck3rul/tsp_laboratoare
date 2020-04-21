using Database;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceMedia
    {
        [OperationContract]
        IReadOnlyCollection<Media> GetAllMedia();

        [OperationContract]
        IReadOnlyCollection<Media> SearchMediaByName(string name);

        [OperationContract]
        Media GetMediaById(int id);

        [OperationContract]
        void CreateMedia(Media media);

        [OperationContract]
        void UpdateMedia(Media media, int id);

        [OperationContract]
        void DeleteMedia(int id);
    }

    [ServiceContract]
    interface InterfacePersons
    {
        [OperationContract]
        IReadOnlyCollection<Persons> GetAllPersons();

        [OperationContract]
        Persons GetPersonsById(int id);

        [OperationContract]
        IReadOnlyCollection<Persons> GetByPersonsId(int id);

        [OperationContract]
        void CretePerson(Persons model);

        [OperationContract]
        void UpdatePerson(Persons model, int id);

        [OperationContract]
        void DeletePerson(int id);
    }

    [ServiceContract]
    interface InterfaceTags
    {
        [OperationContract]
        IReadOnlyCollection<Tags> GetAllTags();

        [OperationContract]
        Tags GetByTagId(int id);

        [OperationContract]
        IReadOnlyCollection<Tags> GetByMediaId(int id);

        [OperationContract]
        void CreateTag(Tags model);

        [OperationContract]
        void UpdateTag(Tags model, int id);

        [OperationContract]
        void DeleteTag(int id);
    }

    [ServiceContract]
    interface IMedia
    {
        [OperationContract]
        IReadOnlyCollection<Tags> GetAllTags();

        [OperationContract]
        Tags GetByTagId(int id);

        [OperationContract]
        IReadOnlyCollection<Tags> GetByMediaId(int id);

        [OperationContract]
        void CreateTag(Tags model);

        [OperationContract]
        void UpdateTag(Tags model, int id);

        [OperationContract]
        void DeleteTag(int id);


        [OperationContract]
        IReadOnlyCollection<Persons> GetAllPersons();

        [OperationContract]
        Persons GetPersonsById(int id);

        [OperationContract]
        IReadOnlyCollection<Persons> GetByPersonsId(int id);

        [OperationContract]
        void CretePerson(Persons model);

        [OperationContract]
        void UpdatePerson(Persons model, int id);

        [OperationContract]
        void DeletePerson(int id);


        [OperationContract]
        IReadOnlyCollection<Media> GetAllMedia();

        [OperationContract]
        IReadOnlyCollection<Media> SearchMediaByName(string name);

        [OperationContract]
        Media GetMediaById(int id);

        [OperationContract]
        void CreateMedia(Media media);

        [OperationContract]
        void UpdateMedia(Media media, int id);

        [OperationContract]
        void DeleteMedia(int id);
    }
}
