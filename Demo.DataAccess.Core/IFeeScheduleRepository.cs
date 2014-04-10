using System;
using System.Collections.Generic;
using Demo.DataAccess.Core.Models;

namespace Demo.DataAccess.Core
{
    public interface IFeeScheduleRepository
    {
        IEnumerable<APCFEED> FindFeesBy(string name, DateTime maximumDate);
    }
}