using Microsoft.EntityFrameworkCore;
using CannedFactoryDatabaseImplement.Models;

namespace CannedFactoryDatabaseImplement
{
    public class CannedFactoryDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-7MR3DNA6\SQLEXPRESS;Initial Catalog=CannedFactoryNewDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Component> Components { set; get; }

        public virtual DbSet<Canned> Canneds { set; get; }

        public virtual DbSet<CannedComponent> CannedComponents { set; get; }

        public virtual DbSet<Order> Orders { set; get; }

        public virtual DbSet<Client> Clients { set; get; }
		
		public virtual DbSet<Implementer> Implementers { get; set; }
    }
}
