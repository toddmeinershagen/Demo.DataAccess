using System.Data.Entity.ModelConfiguration;
using Demo.DataAccess.Core.Models;

namespace Demo.DataAccess.EF.Maps
{
    public class APCFEEDMap : EntityTypeConfiguration<APCFEED>
    {
        public APCFEEDMap()
        {
            HasKey(t => t.SYSKEY);
            HasRequired(t => t.APCFEEObject)
                .WithMany().HasForeignKey(x => x.APCFEE);
        }
    }
}
