using System;
using System.Collections.Generic;
using System.Linq;
using Demo.DataAccess.Core;
using Demo.DataAccess.Core.Models;

namespace Demo.DataAccess.EF
{
    public class EFFeeScheduleRepository : IFeeScheduleRepository
    {
        public IEnumerable<APCFEED> FindFeesBy(string name, DateTime maximumDate)
        {
            using (var entities = new CBO_GlobalEntities())
            {
                var dateString = maximumDate.ToString("yyyyMMdd");

                var fees = 
                    from m in entities.APCFEEs
                    from d in entities.APCFEEDs
                    where
                        (m.SYSKEY == d.APCFEE) &&
                        (m.NAME == name) &&
                        (d.APC_DP == "00229") &&
                        (d.EFF_DATE.CompareTo(dateString) <= 0)
                    orderby 
                        d.APC_DP descending,
                        d.EFF_DATE descending
                    select d;

                return fees.ToList();
            }

            /*
            SELECT D.* FROM APCFEE M, APCFEED D 
            WHERE M.NAME = 'Medicare Device Table' 
            AND M.SYSKEY = D.APCFEE 
            AND D.APC_DP IN ('00229') AND D.EFF_DATE <= '20140101'
            ORDER BY D.APC_DP DESC, D.EFF_DATE DESC
            */
        }
    }
}