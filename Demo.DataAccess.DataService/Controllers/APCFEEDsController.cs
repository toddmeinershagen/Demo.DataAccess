using System.Linq;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using Demo.DataAccess.Core.Models;
using Demo.DataAccess.EF;

namespace Demo.DataAccess.DataService.Controllers
{
    public class APCFEEDsController : EntitySetController<APCFEED, string>
    {
        private readonly CBO_GlobalEntities _entities;

        public APCFEEDsController()
        {
            this._entities = new CBO_GlobalEntities();
        }

        [Queryable(AllowedQueryOptions = AllowedQueryOptions.Expand | AllowedQueryOptions.Filter | AllowedQueryOptions.OrderBy | AllowedQueryOptions.Top)]
        public override IQueryable<APCFEED> Get()
        {
            return _entities.APCFEEDs.AsQueryable();
        }
    }
}