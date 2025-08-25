using API.Entities;

namespace API.UseCases;
public interface LoadProductsUseCase
{
    Task<List<ProductEntity>> LoadProducts();
}
