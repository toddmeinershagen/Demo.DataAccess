using System.Data.Entity.ModelConfiguration;
using Demo.DataAccess.Core.Models;

namespace Demo.DataAccess.EF.Maps
{
    public class APCFEEMap : EntityTypeConfiguration<APCFEE>
    {
        public APCFEEMap()
        {
            HasKey(t => t.SYSKEY);
        }
    }
}
