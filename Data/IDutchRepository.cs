using DutchGo.Data.Entities;
using System.Collections.Generic;

namespace DutchGo.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);

        IEnumerable<Order> GetAllOrders(bool includeItems);
        Order GetOrdersById(int id);

        bool SaveAll();
        void AddEntity(object model);
    }
}