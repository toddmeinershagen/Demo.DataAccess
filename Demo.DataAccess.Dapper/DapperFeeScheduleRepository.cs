using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using Demo.DataAccess.Core;
using Demo.DataAccess.Core.Models;

namespace Demo.DataAccess.Dapper
{
    public class DapperFeeScheduleRepository : IFeeScheduleRepository
    {
        public IEnumerable<APCFEED> FindFeesBy(string name, DateTime maximumDate)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["CBO_GlobalEntities"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var sqlBuilder = new StringBuilder();

                sqlBuilder.AppendLine("SELECT D.*");
                sqlBuilder.AppendLine("FROM APCFEE M, APCFEED D");
                sqlBuilder.AppendLine("WHERE M.NAME = @name");
                sqlBuilder.AppendLine("AND M.SYSKEY = D.APCFEE");
                sqlBuilder.AppendLine("AND D.APC_DP IN ('00229')");
                sqlBuilder.AppendLine("AND D.EFF_DATE <= @maximumDate");
                sqlBuilder.AppendLine("ORDER BY D.APC_DP DESC, D.EFF_DATE DESC");
                
                return connection.Query<APCFEED>(sqlBuilder.ToString(), new {name, maximumDate});
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
