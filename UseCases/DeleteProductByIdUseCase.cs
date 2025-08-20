namespace RestAPI.UseCases;
public interface DeleteProductByIdUseCase
{
    Task Execute(Guid id);
}
