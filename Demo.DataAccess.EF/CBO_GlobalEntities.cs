using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Demo.DataAccess.Core.Models;
using Demo.DataAccess.EF.Maps;

namespace Demo.DataAccess.EF
{
    public class CBO_GlobalEntities : DbContext
    {
        static CBO_GlobalEntities()
        {
            Database.SetInitializer<CBO_GlobalEntities>(null);
        }

        public CBO_GlobalEntities()
            : base("name=CBO_GlobalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new APCFEEMap());
            modelBuilder.Configurations.Add(new APCFEEDMap());
        }
    
        public DbSet<APCFEE> APCFEEs { get; set; }
        public DbSet<APCFEED> APCFEEDs { get; set; }
    }
}
