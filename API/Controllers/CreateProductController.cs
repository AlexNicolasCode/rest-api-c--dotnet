using Microsoft.AspNetCore.Mvc;
using API.Dtos;
using API.Entities;
using API.UseCases;

namespace API.Controllers
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
            ProductEntity product = await _createProductService.CreateProduct(dto);
            return StatusCode(201, product);
        }
    }
}