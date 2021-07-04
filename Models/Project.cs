namespace Graduation_project3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Project : DbContext
    {
        public Project()
            : base("name=Project")
        {
        }

        public virtual DbSet<Supply> Supplies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
