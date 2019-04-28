using WebSale.Data.Infrastructure;
using WebSale.Model.Models;

namespace WebSale.Data.Reponsitories
{
    public interface IErrorRepository : IReponsitory<Error>
    {
    }

    public class ErrorRepository : ReponsitoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}