using System;
using System.Globalization;
using Demo.DataAccess.Core;
using Demo.DataAccess.Dapper;
using Demo.DataAccess.EF;

namespace Demo.DataAccess.ConsoleUI
{
    public class Client
    {
        public void Execute()
        {
            IFeeScheduleRepository dapperRepository = new DapperFeeScheduleRepository();
            DisplayFees(dapperRepository);
           
            IFeeScheduleRepository efRepository = new EFFeeScheduleRepository();
            DisplayFees(efRepository);

            IFeeScheduleRepository odataRepository = new OdataFeeScheduleRepository();
            DisplayFees(odataRepository);            

            Console.WriteLine("Press any key to quit.");
            Console.ReadLine();
        }

        private static void DisplayFees(IFeeScheduleRepository repository)
        {
            Console.WriteLine("OUTPUT FROM:  {0}", repository.GetType().Name);
            
            var fees = repository.FindFeesBy("Medicare Device Table", new DateTime(2014, 1, 1));
            var provider = CultureInfo.InvariantCulture;
            const string dateFormat = "yyyyMMdd";

            foreach (var fee in fees)
            {
                Console.WriteLine("{0} - {1:c}, {2:g}, {3:g}",
                    fee.SYSKEY, Convert.ToDouble(fee.PMT_RATE),
                    DateTime.ParseExact(fee.EFF_DATE, dateFormat, provider).ToShortDateString(),
                    DateTime.ParseExact(fee.MDATE, dateFormat, provider).ToShortDateString());
            }

            Console.WriteLine();
        }
    }
}