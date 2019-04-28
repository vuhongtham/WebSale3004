using WebSale.Data.Infrastructure;
using WebSale.Model.Models;

namespace WebSale.Data.Reponsitories
{
    public interface IApplicationUserGroupRepository : IReponsitory<ApplicationUserGroup>
    {
    }

    public class ApplicationUserGroupRepository : ReponsitoryBase<ApplicationUserGroup>, IApplicationUserGroupRepository
    {
        public ApplicationUserGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}