using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;

namespace lab6
{
    [DataContract(IsReference = true)]
    public partial class Comment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public virtual Post Post { get; set; }
    }
}
