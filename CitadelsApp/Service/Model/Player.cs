namespace Service.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Player")]
    public partial class Player
    {
        public int Id { get; set; }

        public int WonderId { get; set; }

        public int? UserId { get; set; }

        public int GameId { get; set; }

        public virtual Game Game { get; set; }

        public virtual User User { get; set; }

        public virtual Wonder Wonder { get; set; }
    }
}
