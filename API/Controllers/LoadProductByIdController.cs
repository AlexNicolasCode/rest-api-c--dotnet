using Microsoft.AspNetCore.Mvc;
using API.Entities;
using API.UseCases;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class LoadProductByIdController : ControllerBase
    {
        private readonly LoadProductByIdUseCase _loadProductByIdService;

        public LoadProductByIdController(LoadProductByIdUseCase loadProductByIdService)
        {
            _loadProductByIdService = loadProductByIdService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductEntity>> Execute(Guid id)
        {
            ProductEntity product = await _loadProductByIdService.Execute(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
    }
}