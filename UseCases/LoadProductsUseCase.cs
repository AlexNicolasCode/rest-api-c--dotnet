using RestAPI.Entities;

namespace RestAPI.UseCases;
public interface LoadProductsUseCase
{
    Task<List<ProductEntity>> Execute();
}
