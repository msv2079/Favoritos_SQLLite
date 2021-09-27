using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Favoritos.Models.Mapping;

namespace Favoritos.Models
{
    public partial class FAVORITOSContext : DbContext
    {
        static FAVORITOSContext()
        {
            Database.SetInitializer<FAVORITOSContext>(null);
        }

        public FAVORITOSContext()
            : base("Name=FAVORITOSContext")
        {
        }

        public DbSet<LINK> LINKS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LINKMap());
        }
    }
}
