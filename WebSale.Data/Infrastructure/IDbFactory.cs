using System;

namespace WebSale.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        WebSaleDbContext Init();
    }
}