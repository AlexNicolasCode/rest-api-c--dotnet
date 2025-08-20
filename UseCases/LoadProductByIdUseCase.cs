using RestAPI.Entities;

namespace RestAPI.UseCases;
public interface LoadProductByIdUseCase
{
    Task<ProductEntity> Execute(Guid id);
}
