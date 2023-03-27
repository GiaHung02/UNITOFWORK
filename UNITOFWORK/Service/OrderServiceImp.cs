using System.Security.AccessControl;
using UNITOFWORK.Models;
using UNITOFWORK.Repository;

namespace UNITOFWORK.Service
{
    public class OrderServiceImp : IOrderRepository
    {
        private readonly DatabaseContext context;
        public OrderServiceImp(DatabaseContext context)
        {
            this.context = context;
        }
        public void AddOrder(Order order)
        {
            context.Orders.Add(order);
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }

        public Order OrderGetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
