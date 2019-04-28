using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSale.Data.Infrastructure;
using WebSale.Model.Models;

namespace WebSale.Data.Reponsitories
{
    public interface IPostTagRepository : IReponsitory<PostTag>
    {

    }
    public class PostTagRepository : ReponsitoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
