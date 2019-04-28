using WebSale.Data.Infrastructure;
using WebSale.Model.Models;

namespace WebSale.Data.Reponsitories
{
    public interface IContactDetailRepository : IReponsitory<ContactDetail>
    {
    }

    public class ContactDetailRepository : ReponsitoryBase<ContactDetail>, IContactDetailRepository
    {
        public ContactDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}