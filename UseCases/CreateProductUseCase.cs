using RestAPI.Dtos;
using RestAPI.Entities;

namespace RestAPI.UseCases;
public interface CreateProductUseCase
{
    Task<ProductEntity> Execute(SaveProductDto dto);
}
