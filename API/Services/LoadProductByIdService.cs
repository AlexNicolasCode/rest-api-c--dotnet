using API.Database;
using API.Entities;
using API.UseCases;

namespace API.Services
{
    public class LoadProductbyIdService : LoadProductByIdUseCase
    {
        private readonly AppDbContext _db;

        public LoadProductbyIdService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<ProductEntity> Execute(Guid id)
        {
            return await _db.Products.FindAsync(id);
        }
    }
}