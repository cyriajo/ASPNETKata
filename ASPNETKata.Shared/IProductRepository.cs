using System.Collections.Generic;
using InversionofControl.Shared;

namespace ASPNETKata.Shared
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void DeleteProduct(int productId);
        void UpdateProduct(Product prod);
        void InsertProduct(Product prod);
    }
}