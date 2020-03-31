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
        IReadOnlyCollection<Media> GetAll();

        [OperationContract]
        IReadOnlyCollection<Media> SearchByName(string name);

        [OperationContract]
        Media GetById(int id);

        [OperationContract]
        void Create(Media media);

        [OperationContract]
        void Update(Media media, int id);

        [OperationContract]
        void Delete(int id);
    }

    [ServiceContract]
    interface InterfacePersons
    {
        [OperationContract]
        IReadOnlyCollection<Persons> GetAll();

        [OperationContract]
        Persons GetById(int id);

        [OperationContract]
        IReadOnlyCollection<Persons> GetByMediaId(int id);

        [OperationContract]
        void Crete(Persons model);

        [OperationContract]
        void Update(Persons model, int id);

        [OperationContract]
        void Delete(int id);
    }

    [ServiceContract]
    interface InterfaceTags
    {
        [OperationContract]
        IReadOnlyCollection<Tags> GetAll();

        [OperationContract]
        Tags GetById(int id);

        [OperationContract]
        IReadOnlyCollection<Tags> GetByMediaId(int id);

        [OperationContract]
        void Crete(Tags model);

        [OperationContract]
        void Update(Tags model, int id);

        [OperationContract]
        void Delete(int id);
    }
}
