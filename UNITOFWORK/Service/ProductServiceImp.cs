using UNITOFWORK.Models;
using UNITOFWORK.Repository;

namespace UNITOFWORK.Service
{
    public class ProductServiceImp : IProductRepository
    {
        private readonly DatabaseContext context;
        public ProductServiceImp(DatabaseContext context)
        {
            this.context = context;
        }
        public void AddProduct(Product product)
        {
            context.Products.Add(product);
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
