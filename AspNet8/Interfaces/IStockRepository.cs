using AspNet8.Models;

namespace AspNet8.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
    }
}
