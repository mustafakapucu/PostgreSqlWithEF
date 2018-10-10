using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlWithEF
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("Default") { }

        public DbSet<Car> Cars { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Car", "public");
            base.OnModelCreating(modelBuilder);
        }

    }
}
