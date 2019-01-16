namespace ProjectStatusCenter.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tracker.TBL")]
    public partial class TBL
    {
        [StringLength(255)]
        public string Application { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTime? BusinessBeginCycle { get; set; }

        [NotMapped]
        public string BusinessBeginString { get; set; }

        public DateTime? BusinessEndCycle { get; set; }

        [NotMapped]
        public string BusinessEndString { get; set; }

        public DateTime? DevBeginCycle { get; set; }

        public DateTime? DevEndCycle { get; set; }

        [StringLength(255)]
        public string BusinessContact { get; set; }

        [StringLength(255)]
        public string Developer { get; set; }

        public int ID { get; set; }
    }
}
