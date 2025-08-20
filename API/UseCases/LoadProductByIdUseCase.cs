using API.Entities;

namespace API.UseCases;
public interface LoadProductByIdUseCase
{
    Task<ProductEntity> Execute(Guid id);
}
