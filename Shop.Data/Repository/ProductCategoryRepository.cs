using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Repository
{
    public interface IProductCategoryRepository : IRepository<ProductCategories>
    {
        
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategories>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

       
    }
}