namespace Service.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stage")]
    public partial class Stage
    {
        public int Id { get; set; }

        public int WonderId { get; set; }

        public virtual Wonder Wonder { get; set; }
    }
}
