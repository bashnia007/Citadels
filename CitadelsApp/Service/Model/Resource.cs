using System.Runtime.Serialization;

namespace Service.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [DataContract]
    [Table("Resource")]
    public partial class Resource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resource()
        {
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Name { get; set; }
        
    }
}
