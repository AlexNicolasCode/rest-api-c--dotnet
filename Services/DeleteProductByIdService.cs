using RestAPI.Database;
using RestAPI.Entities;
using RestAPI.UseCases;

namespace RestAPI.Services
{
    public class DeleteProductByIdService : DeleteProductByIdUseCase
    {
        private readonly AppDbContext _db;

        public DeleteProductByIdService(AppDbContext db)
        {
            _db = db;
        }

        public async Task Execute(Guid id)
        {
            ProductEntity? product = await _db.Products.FindAsync(id);
            if (product == null)
            {
                return;
            }
            product.DeletedAt = DateTime.UtcNow;
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
        }
    }
}