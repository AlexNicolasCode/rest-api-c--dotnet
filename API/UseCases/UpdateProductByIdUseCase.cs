using API.Dtos;

namespace API.UseCases;
public interface UpdateProductByIdUseCase
{
    Task UpdateProductById(Guid id, SaveProductDto dto);
}
