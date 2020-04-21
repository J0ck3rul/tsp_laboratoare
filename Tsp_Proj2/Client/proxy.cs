﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tags", Namespace="http://schemas.datacontract.org/2004/07/Database", IsReference=true)]
    public class Tags : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persons", Namespace="http://schemas.datacontract.org/2004/07/Database", IsReference=true)]
    public class Persons : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private System.Nullable<int> MediaIdField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MediaId
        {
            get
            {
                return this.MediaIdField;
            }
            set
            {
                this.MediaIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Media", Namespace="http://schemas.datacontract.org/2004/07/Database", IsReference=true)]
    public class Media : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DateField;
        
        private string DescriptionField;
        
        private string EventField;
        
        private int IdField;
        
        private string LocationField;
        
        private string NameField;
        
        private string PathField;
        
        private string TypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IMedia")]
public interface IMedia
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetAllTags", ReplyAction="http://tempuri.org/IMedia/GetAllTagsResponse")]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Tags))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Persons))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Media))]
    object GetAllTags();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetAllTags", ReplyAction="http://tempuri.org/IMedia/GetAllTagsResponse")]
    System.Threading.Tasks.Task<object> GetAllTagsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetByTagId", ReplyAction="http://tempuri.org/IMedia/GetByTagIdResponse")]
    Database.Tags GetByTagId(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetByTagId", ReplyAction="http://tempuri.org/IMedia/GetByTagIdResponse")]
    System.Threading.Tasks.Task<Database.Tags> GetByTagIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetByMediaId", ReplyAction="http://tempuri.org/IMedia/GetByMediaIdResponse")]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Tags))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Persons))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Media))]
    object GetByMediaId(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetByMediaId", ReplyAction="http://tempuri.org/IMedia/GetByMediaIdResponse")]
    System.Threading.Tasks.Task<object> GetByMediaIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/CreateTag", ReplyAction="http://tempuri.org/IMedia/CreateTagResponse")]
    void CreateTag(Database.Tags model);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/CreateTag", ReplyAction="http://tempuri.org/IMedia/CreateTagResponse")]
    System.Threading.Tasks.Task CreateTagAsync(Database.Tags model);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/UpdateTag", ReplyAction="http://tempuri.org/IMedia/UpdateTagResponse")]
    void UpdateTag(Database.Tags model, int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/UpdateTag", ReplyAction="http://tempuri.org/IMedia/UpdateTagResponse")]
    System.Threading.Tasks.Task UpdateTagAsync(Database.Tags model, int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/DeleteTag", ReplyAction="http://tempuri.org/IMedia/DeleteTagResponse")]
    void DeleteTag(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/DeleteTag", ReplyAction="http://tempuri.org/IMedia/DeleteTagResponse")]
    System.Threading.Tasks.Task DeleteTagAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetAllPersons", ReplyAction="http://tempuri.org/IMedia/GetAllPersonsResponse")]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Tags))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Persons))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Media))]
    object GetAllPersons();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetAllPersons", ReplyAction="http://tempuri.org/IMedia/GetAllPersonsResponse")]
    System.Threading.Tasks.Task<object> GetAllPersonsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetPersonsById", ReplyAction="http://tempuri.org/IMedia/GetPersonsByIdResponse")]
    Database.Persons GetPersonsById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetPersonsById", ReplyAction="http://tempuri.org/IMedia/GetPersonsByIdResponse")]
    System.Threading.Tasks.Task<Database.Persons> GetPersonsByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetByPersonsId", ReplyAction="http://tempuri.org/IMedia/GetByPersonsIdResponse")]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Tags))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Persons))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Media))]
    object GetByPersonsId(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetByPersonsId", ReplyAction="http://tempuri.org/IMedia/GetByPersonsIdResponse")]
    System.Threading.Tasks.Task<object> GetByPersonsIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/CretePerson", ReplyAction="http://tempuri.org/IMedia/CretePersonResponse")]
    void CretePerson(Database.Persons model);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/CretePerson", ReplyAction="http://tempuri.org/IMedia/CretePersonResponse")]
    System.Threading.Tasks.Task CretePersonAsync(Database.Persons model);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/UpdatePerson", ReplyAction="http://tempuri.org/IMedia/UpdatePersonResponse")]
    void UpdatePerson(Database.Persons model, int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/UpdatePerson", ReplyAction="http://tempuri.org/IMedia/UpdatePersonResponse")]
    System.Threading.Tasks.Task UpdatePersonAsync(Database.Persons model, int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/DeletePerson", ReplyAction="http://tempuri.org/IMedia/DeletePersonResponse")]
    void DeletePerson(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/DeletePerson", ReplyAction="http://tempuri.org/IMedia/DeletePersonResponse")]
    System.Threading.Tasks.Task DeletePersonAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetAllMedia", ReplyAction="http://tempuri.org/IMedia/GetAllMediaResponse")]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Tags))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Persons))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Media))]
    object GetAllMedia();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetAllMedia", ReplyAction="http://tempuri.org/IMedia/GetAllMediaResponse")]
    System.Threading.Tasks.Task<object> GetAllMediaAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/SearchMediaByName", ReplyAction="http://tempuri.org/IMedia/SearchMediaByNameResponse")]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Tags))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Persons))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Database.Media))]
    object SearchMediaByName(string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/SearchMediaByName", ReplyAction="http://tempuri.org/IMedia/SearchMediaByNameResponse")]
    System.Threading.Tasks.Task<object> SearchMediaByNameAsync(string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetMediaById", ReplyAction="http://tempuri.org/IMedia/GetMediaByIdResponse")]
    Database.Media GetMediaById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/GetMediaById", ReplyAction="http://tempuri.org/IMedia/GetMediaByIdResponse")]
    System.Threading.Tasks.Task<Database.Media> GetMediaByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/CreateMedia", ReplyAction="http://tempuri.org/IMedia/CreateMediaResponse")]
    void CreateMedia(Database.Media media);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/CreateMedia", ReplyAction="http://tempuri.org/IMedia/CreateMediaResponse")]
    System.Threading.Tasks.Task CreateMediaAsync(Database.Media media);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/UpdateMedia", ReplyAction="http://tempuri.org/IMedia/UpdateMediaResponse")]
    void UpdateMedia(Database.Media media, int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/UpdateMedia", ReplyAction="http://tempuri.org/IMedia/UpdateMediaResponse")]
    System.Threading.Tasks.Task UpdateMediaAsync(Database.Media media, int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/DeleteMedia", ReplyAction="http://tempuri.org/IMedia/DeleteMediaResponse")]
    void DeleteMedia(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMedia/DeleteMedia", ReplyAction="http://tempuri.org/IMedia/DeleteMediaResponse")]
    System.Threading.Tasks.Task DeleteMediaAsync(int id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IMediaChannel : IMedia, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class MediaClient : System.ServiceModel.ClientBase<IMedia>, IMedia
{
    
    public MediaClient()
    {
    }
    
    public MediaClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public MediaClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MediaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public MediaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public object GetAllTags()
    {
        return base.Channel.GetAllTags();
    }
    
    public System.Threading.Tasks.Task<object> GetAllTagsAsync()
    {
        return base.Channel.GetAllTagsAsync();
    }
    
    public Database.Tags GetByTagId(int id)
    {
        return base.Channel.GetByTagId(id);
    }
    
    public System.Threading.Tasks.Task<Database.Tags> GetByTagIdAsync(int id)
    {
        return base.Channel.GetByTagIdAsync(id);
    }
    
    public object GetByMediaId(int id)
    {
        return base.Channel.GetByMediaId(id);
    }
    
    public System.Threading.Tasks.Task<object> GetByMediaIdAsync(int id)
    {
        return base.Channel.GetByMediaIdAsync(id);
    }
    
    public void CreateTag(Database.Tags model)
    {
        base.Channel.CreateTag(model);
    }
    
    public System.Threading.Tasks.Task CreateTagAsync(Database.Tags model)
    {
        return base.Channel.CreateTagAsync(model);
    }
    
    public void UpdateTag(Database.Tags model, int id)
    {
        base.Channel.UpdateTag(model, id);
    }
    
    public System.Threading.Tasks.Task UpdateTagAsync(Database.Tags model, int id)
    {
        return base.Channel.UpdateTagAsync(model, id);
    }
    
    public void DeleteTag(int id)
    {
        base.Channel.DeleteTag(id);
    }
    
    public System.Threading.Tasks.Task DeleteTagAsync(int id)
    {
        return base.Channel.DeleteTagAsync(id);
    }
    
    public object GetAllPersons()
    {
        return base.Channel.GetAllPersons();
    }
    
    public System.Threading.Tasks.Task<object> GetAllPersonsAsync()
    {
        return base.Channel.GetAllPersonsAsync();
    }
    
    public Database.Persons GetPersonsById(int id)
    {
        return base.Channel.GetPersonsById(id);
    }
    
    public System.Threading.Tasks.Task<Database.Persons> GetPersonsByIdAsync(int id)
    {
        return base.Channel.GetPersonsByIdAsync(id);
    }
    
    public object GetByPersonsId(int id)
    {
        return base.Channel.GetByPersonsId(id);
    }
    
    public System.Threading.Tasks.Task<object> GetByPersonsIdAsync(int id)
    {
        return base.Channel.GetByPersonsIdAsync(id);
    }
    
    public void CretePerson(Database.Persons model)
    {
        base.Channel.CretePerson(model);
    }
    
    public System.Threading.Tasks.Task CretePersonAsync(Database.Persons model)
    {
        return base.Channel.CretePersonAsync(model);
    }
    
    public void UpdatePerson(Database.Persons model, int id)
    {
        base.Channel.UpdatePerson(model, id);
    }
    
    public System.Threading.Tasks.Task UpdatePersonAsync(Database.Persons model, int id)
    {
        return base.Channel.UpdatePersonAsync(model, id);
    }
    
    public void DeletePerson(int id)
    {
        base.Channel.DeletePerson(id);
    }
    
    public System.Threading.Tasks.Task DeletePersonAsync(int id)
    {
        return base.Channel.DeletePersonAsync(id);
    }
    
    public object GetAllMedia()
    {
        return base.Channel.GetAllMedia();
    }
    
    public System.Threading.Tasks.Task<object> GetAllMediaAsync()
    {
        return base.Channel.GetAllMediaAsync();
    }
    
    public object SearchMediaByName(string name)
    {
        return base.Channel.SearchMediaByName(name);
    }
    
    public System.Threading.Tasks.Task<object> SearchMediaByNameAsync(string name)
    {
        return base.Channel.SearchMediaByNameAsync(name);
    }
    
    public Database.Media GetMediaById(int id)
    {
        return base.Channel.GetMediaById(id);
    }
    
    public System.Threading.Tasks.Task<Database.Media> GetMediaByIdAsync(int id)
    {
        return base.Channel.GetMediaByIdAsync(id);
    }
    
    public void CreateMedia(Database.Media media)
    {
        base.Channel.CreateMedia(media);
    }
    
    public System.Threading.Tasks.Task CreateMediaAsync(Database.Media media)
    {
        return base.Channel.CreateMediaAsync(media);
    }
    
    public void UpdateMedia(Database.Media media, int id)
    {
        base.Channel.UpdateMedia(media, id);
    }
    
    public System.Threading.Tasks.Task UpdateMediaAsync(Database.Media media, int id)
    {
        return base.Channel.UpdateMediaAsync(media, id);
    }
    
    public void DeleteMedia(int id)
    {
        base.Channel.DeleteMedia(id);
    }
    
    public System.Threading.Tasks.Task DeleteMediaAsync(int id)
    {
        return base.Channel.DeleteMediaAsync(id);
    }
}
