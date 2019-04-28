using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSale.Data.Infrastructure;
using WebSale.Model.Models;

namespace WebSale.Data.Reponsitories
{
        public interface IOrderDetailRepository : IReponsitory<OrderDetail>
        {

        }
        public class OrderDetailRepository : ReponsitoryBase<OrderDetail>, IOrderDetailRepository
        {
            public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
            {

            }
        }

}
