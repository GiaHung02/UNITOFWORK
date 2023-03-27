using UNITOFWORK.Models;
using UNITOFWORK.Repository;

namespace UNITOFWORK.Service
{
    public class UnitOfWorkImp : IUnitOfWork
    {
        private readonly DatabaseContext context;
        public IOrderRepository Orders { get; }
        public IProductRepository Products { get; }
        public UnitOfWorkImp(DatabaseContext context, IOrderRepository Orders, IProductRepository Products) { 
            this.context = context;
            this.Orders = Orders;
            this.Products = Products;
        }  

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            context.SaveChanges();
        }
    }
}
