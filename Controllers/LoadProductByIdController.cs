using Microsoft.AspNetCore.Mvc;
using RestAPI.Entities;
using RestAPI.UseCases;

namespace RestAPI.Controllers
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