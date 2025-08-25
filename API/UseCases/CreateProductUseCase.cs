using API.Dtos;
using API.Entities;

namespace API.UseCases;
public interface CreateProductUseCase
{
    Task<ProductEntity> CreateProduct(SaveProductDto dto);
}
