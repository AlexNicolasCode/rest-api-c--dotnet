namespace API.UseCases;
public interface DeleteProductByIdUseCase
{
    Task Execute(Guid id);
}
