using System;
using System.Collections.Generic;

namespace BestBuyCRUD
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
