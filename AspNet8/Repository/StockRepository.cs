using AspNet8.Data;
using AspNet8.Interfaces;
using AspNet8.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet8.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext _context;

        public StockRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<Stock>> GetAllAsync()
        {
            return _context.Stocks.ToListAsync();
        }
    }
}
