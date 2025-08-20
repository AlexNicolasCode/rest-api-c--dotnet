using Microsoft.EntityFrameworkCore;
using API.Database;
using API.Entities;
using API.UseCases;

namespace API.Services
{
    public class LoadProductsService : LoadProductsUseCase
    {
        private readonly AppDbContext _db;

        public LoadProductsService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<ProductEntity>> Execute()
        {
            return await _db.Products.ToListAsync();
        }
    }
}