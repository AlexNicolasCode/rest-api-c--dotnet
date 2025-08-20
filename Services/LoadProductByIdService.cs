using RestAPI.Database;
using RestAPI.Entities;
using RestAPI.UseCases;

namespace RestAPI.Services
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