using RestAPI.Dtos;

namespace RestAPI.UseCases;
public interface UpdateProductByIdUseCase
{
    Task Execute(Guid id, SaveProductDto dto);
}
