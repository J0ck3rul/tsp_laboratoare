﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Photo", Namespace="http://schemas.datacontract.org/2004/07/Database._3._0", IsReference=true)]
    public partial class Photo : object
    {
        
        private string EventField;
        
        private int IdField;
        
        private string NameField;
        
        private string UrlField;
        
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
        public string Url
        {
            get
            {
                return this.UrlField;
            }
            set
            {
                this.UrlField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tags", Namespace="http://schemas.datacontract.org/2004/07/Database._3._0", IsReference=true)]
    public partial class Tags : object
    {
        
        private int IdField;
        
        private string NameField;
        
        private int PhotoIdField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhotoId
        {
            get
            {
                return this.PhotoIdField;
            }
            set
            {
                this.PhotoIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMedia")]
    public interface IMedia
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhoto/GetPhotos", ReplyAction="http://tempuri.org/IPhoto/GetPhotosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.Photo>> GetPhotosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhoto/SearchPhotoByName", ReplyAction="http://tempuri.org/IPhoto/SearchPhotoByNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.Photo>> SearchPhotoByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPhoto/SearchPhotoByTag", ReplyAction="http://tempuri.org/IPhoto/SearchPhotoByTagResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.Photo>> SearchPhotoByTagAsync(string tag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITags/SearchTagByPhotoId", ReplyAction="http://tempuri.org/ITags/SearchTagByPhotoIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.Tags>> SearchTagByPhotoIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMediaChannel : ServiceReference1.IMedia, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MediaClient : System.ServiceModel.ClientBase<ServiceReference1.IMedia>, ServiceReference1.IMedia
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MediaClient() : 
                base(MediaClient.GetDefaultBinding(), MediaClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMedia.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MediaClient(EndpointConfiguration endpointConfiguration) : 
                base(MediaClient.GetBindingForEndpoint(endpointConfiguration), MediaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MediaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MediaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MediaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MediaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MediaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.Photo>> GetPhotosAsync()
        {
            return base.Channel.GetPhotosAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.Photo>> SearchPhotoByNameAsync(string name)
        {
            return base.Channel.SearchPhotoByNameAsync(name);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.Photo>> SearchPhotoByTagAsync(string tag)
        {
            return base.Channel.SearchPhotoByTagAsync(tag);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReference1.Tags>> SearchTagByPhotoIdAsync(int id)
        {
            return base.Channel.SearchTagByPhotoIdAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMedia))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMedia))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MediaClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMedia);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MediaClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMedia);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMedia,
        }
    }
}
