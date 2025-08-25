using Microsoft.AspNetCore.Mvc;
using API.Entities;
using API.UseCases;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class DeleteProductByIdController : ControllerBase
    {
        private readonly LoadProductByIdUseCase _loadProductByIdService;
        private readonly DeleteProductByIdUseCase _deleteProductByIdService;

        public DeleteProductByIdController(LoadProductByIdUseCase loadProductByIdService, DeleteProductByIdUseCase deleteProductByIdService)
        {
            _loadProductByIdService = loadProductByIdService;
            _deleteProductByIdService = deleteProductByIdService;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Execute(Guid id)
        {
            ProductEntity product = await _loadProductByIdService.LoadProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            await _deleteProductByIdService.DeleteProductById(id);
            return NoContent();
        }
    }
}