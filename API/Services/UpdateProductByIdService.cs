using API.Database;
using API.Dtos;
using API.Entities;
using API.UseCases;

namespace API.Services
{
    public class UpdateProductbyIdService : UpdateProductByIdUseCase
    {
        private readonly AppDbContext _db;
        private readonly LoadProductByIdUseCase _loadProductByIdService;

        public UpdateProductbyIdService(AppDbContext db, LoadProductByIdUseCase loadProductByIdService)
        {
            _db = db;
            _loadProductByIdService = loadProductByIdService;
        }
        public async Task UpdateProductById(Guid id, SaveProductDto dto)
        {
            ProductEntity product = await _loadProductByIdService.LoadProductById(id);
            product.Name = dto.Name;
            product.Price = dto.Price;
            _db.Update(product);
            await _db.SaveChangesAsync();
        }
    }
}