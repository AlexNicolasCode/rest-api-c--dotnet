using Microsoft.AspNetCore.Mvc;
using API.Dtos;
using API.Entities;
using API.UseCases;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class UpdateProductByIdController : ControllerBase
    {
        private readonly LoadProductByIdUseCase _loadProductByIdService;
        private readonly UpdateProductByIdUseCase _updateProductByIdService;

        public UpdateProductByIdController(LoadProductByIdUseCase loadProductByIdService, UpdateProductByIdUseCase updateProductByIdService)
        {
            _loadProductByIdService = loadProductByIdService;
            _updateProductByIdService = updateProductByIdService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Execute(Guid id, SaveProductDto dto)
        {
            ProductEntity product = await _loadProductByIdService.LoadProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            await _updateProductByIdService.UpdateProductById(id, dto);
            return NoContent();
        }
    }
}