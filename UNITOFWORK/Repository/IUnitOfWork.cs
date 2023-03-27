namespace UNITOFWORK.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        void SaveChange();
    }
}
