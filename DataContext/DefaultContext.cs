using DataModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataContext
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() : base("DesafioDigixDB") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Familia> Familia { get; set; }
        public DbSet<Renda> Renda { get; set; }
    }
}