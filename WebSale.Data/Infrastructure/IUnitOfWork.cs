namespace WebSale.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}