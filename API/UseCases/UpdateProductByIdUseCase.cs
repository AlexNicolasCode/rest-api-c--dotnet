using API.Dtos;

namespace API.UseCases;
public interface UpdateProductByIdUseCase
{
    Task Execute(Guid id, SaveProductDto dto);
}
