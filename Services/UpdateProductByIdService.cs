using RestAPI.Database;
using RestAPI.Dtos;
using RestAPI.Entities;
using RestAPI.UseCases;

namespace RestAPI.Services
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
        public async Task Execute(Guid id, SaveProductDto dto)
        {
            ProductEntity product = await _loadProductByIdService.Execute(id);
            product.Name = dto.Name;
            product.Price = dto.Price;
            _db.Update(product);
            await _db.SaveChangesAsync();
        }
    }
}