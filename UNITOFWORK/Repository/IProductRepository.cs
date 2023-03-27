using UNITOFWORK.Models;

namespace UNITOFWORK.Repository
{
    public interface IProductRepository
    {
        List<Product> GetOrders();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
