using System.Linq;
using System.Web.Http.OData;
using Demo.DataAccess.Core.Models;
using Demo.DataAccess.EF;

namespace Demo.DataAccess.DataService.Controllers
{
    public class APCFEEsController : EntitySetController<APCFEE, string>
    {
        private readonly CBO_GlobalEntities _entities;

        public APCFEEsController()
        {
            _entities = new CBO_GlobalEntities();
        }

        public override IQueryable<APCFEE> Get()
        {
            return _entities.APCFEEs.AsQueryable();
        }
    }
}