using WebSale.Data.Infrastructure;
using WebSale.Model.Models;

namespace WebSale.Data.Reponsitories
{
    public interface IFooterRepository : IReponsitory<Footer>
    {
    }

    public class FooterRepository : ReponsitoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}