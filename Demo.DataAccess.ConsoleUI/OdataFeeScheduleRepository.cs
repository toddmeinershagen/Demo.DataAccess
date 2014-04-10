using System;
using System.Collections.Generic;
using System.Linq;
using Demo.DataAccess.Core;
using APCFEED = Demo.DataAccess.Core.Models.APCFEED;

namespace Demo.DataAccess.ConsoleUI
{
    public class OdataFeeScheduleRepository : IFeeScheduleRepository
    {
        public IEnumerable<APCFEED> FindFeesBy(string name, DateTime maximumDate)
        {
            var uri = new Uri("http://localhost:22922/odata/");
            var container = new CBO_GlobalEntities.Container(uri);

            var dateString = maximumDate.ToString("yyyyMMdd");

            var fees =
                from m in container.APCFEEDs.Expand("APCFEEs")
                where
                    (m.APCFEEObject.NAME == name) &&
                    (m.APC_DP == "00229") &&
                    (m.EFF_DATE.CompareTo(dateString) <= 0)
                orderby
                    m.APC_DP descending,
                    m.EFF_DATE descending
                select m;

            return fees.ToList().Select(m =>
                new APCFEED
                {
                    SYSKEY = m.SYSKEY,
                    APC = m.APC,
                    APC_DP = m.APC_DP,
                    PMT_RATE = m.PMT_RATE,
                    NAT_COINS = m.NAT_COINS,
                    MIN_COINS = m.MIN_COINS,
                    PAY_OUTLR = m.PAY_OUTLR,
                    CO_PCNT = m.CO_PCNT,
                    EFF_DATE = m.EFF_DATE,
                    APCFEE = m.APCFEE,
                    MDATE = m.MDATE,
                    MTIME = m.MTIME,
                    MUSER = m.MUSER,
                    APCWEIGHT = m.APCWEIGHT,
                    IMPLANT = m.IMPLANT
                });
        }
    }
}
