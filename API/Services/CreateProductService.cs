using API.Database;
using API.Dtos;
using API.Entities;
using API.UseCases;

namespace API.Services
{
    public class CreateProductService : CreateProductUseCase
    {
        private readonly AppDbContext _db;
        private readonly LoadProductByIdUseCase _loadProductByIdService;

        public CreateProductService(AppDbContext db, LoadProductByIdUseCase loadProductByIdService)
        {
            _db = db;
            _loadProductByIdService = loadProductByIdService;
        }

        public async Task<ProductEntity> Execute(SaveProductDto dto)
        {
            Guid id = Guid.NewGuid();
            ProductEntity product = new ProductEntity
            {
                Id = id,
                Name = dto.Name,
                Price = dto.Price,
            };
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return await _loadProductByIdService.Execute(id);
        }
    }
}