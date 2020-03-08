namespace MTO1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=MTO_Model")
        {
        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
