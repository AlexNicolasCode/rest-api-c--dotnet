namespace API.UseCases;
public interface DeleteProductByIdUseCase
{
    Task DeleteProductById(Guid id);
}
