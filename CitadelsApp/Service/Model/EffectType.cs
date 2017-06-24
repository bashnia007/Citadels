namespace Service.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EffectType")]
    public partial class EffectType
    {
        public int Id { get; set; }

        public int Count { get; set; }
    }
}
