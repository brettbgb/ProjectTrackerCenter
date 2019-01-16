namespace ProjectStatusCenter.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TrackerDBContext : DbContext
    {
        public TrackerDBContext()
            : base("name=TrackerDBContext2")
        {
        }

        public virtual DbSet<TBL> TBLs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
