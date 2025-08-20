using Microsoft.AspNetCore.Mvc;
using RestAPI.Dtos;
using RestAPI.Entities;
using RestAPI.UseCases;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class CreateProductController : ControllerBase
    {
        private readonly CreateProductUseCase _createProductService;

        public CreateProductController(CreateProductUseCase createProductService)
        {
            _createProductService = createProductService;
        }

        [HttpPost]
        public async Task<ActionResult<ProductEntity>> Execute(SaveProductDto dto)
        {
            ProductEntity product = await _createProductService.Execute(dto);
            return StatusCode(201, product);
        }
    }
}