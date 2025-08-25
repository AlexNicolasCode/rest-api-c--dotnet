using Microsoft.AspNetCore.Mvc;
using API.Entities;
using API.UseCases;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class LoadProductsController : ControllerBase
    {
        private readonly LoadProductsUseCase _loadProductsService;

        public LoadProductsController(LoadProductsUseCase loadProductsService)
        {
            _loadProductsService = loadProductsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductEntity>>> Execute()
        {
            return await _loadProductsService.LoadProducts();
        }
    }
}