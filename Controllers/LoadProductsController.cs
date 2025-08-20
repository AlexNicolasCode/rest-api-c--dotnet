using Microsoft.AspNetCore.Mvc;
using RestAPI.Entities;
using RestAPI.UseCases;

namespace RestAPI.Controllers
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
            return await _loadProductsService.Execute();
        }
    }
}