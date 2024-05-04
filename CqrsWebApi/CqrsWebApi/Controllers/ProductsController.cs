using CqrsMediatr.Commands.Products;
using CqrsMediatr.Models;
using CqrsMediatr.Queries.GetProducts;
using CqrsMediatr.Queries.GetProductsById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsWebApi.Controllers
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ISender _sender;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        public ProductsController(ISender sender) => _sender = sender;

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_sender.Send(new GetProductsQuery()));
        }


        [HttpGet("Id", Name = "GetProductById")]
        public IActionResult GetProductById(int Id)
        {
            return Ok(_sender.Send(new GetProductsByIdQuery(Id)));
        }

        [HttpPost()]
        public async Task<IActionResult> AddProduct(Product product )
        {
            var productToReturn = _sender.Send(new AddProductCommand(product));
            return CreatedAtRoute(nameof(GetProductById), new { id = productToReturn.Id }, productToReturn);
        }


    }
}
