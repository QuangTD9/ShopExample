using Shop.Data.Infrastructure;
using Shop.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Repository
{
    public interface IProductCategoryRepository : IRepository<ProductCategories>
    {
        IEnumerable<ProductCategories> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategories>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategories> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}