using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSale.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private WebSaleDbContext dbContext;
        public WebSaleDbContext Init()
        {
            return dbContext ?? (dbContext = new WebSaleDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
