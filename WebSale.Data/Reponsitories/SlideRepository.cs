using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSale.Data.Infrastructure;
using WebSale.Model.Models;

namespace WebSale.Data.Reponsitories
{
    public interface ISlideRepository : IReponsitory<Slide>
    {
    }

    public class SlideRepository : ReponsitoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
