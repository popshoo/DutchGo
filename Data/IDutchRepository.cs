using DutchGo.Data.Entities;
using System.Collections.Generic;

namespace DutchGo.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);

        bool SaveChanges();
    }
}