using Microsoft.EntityFrameworkCore;
using RestAPI.Database;
using RestAPI.Entities;
using RestAPI.UseCases;

namespace RestAPI.Services
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