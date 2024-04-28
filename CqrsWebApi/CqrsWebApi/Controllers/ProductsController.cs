using CqrsMediatr.Queries.Products;
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


        [HttpGet("Id")]
        public IActionResult GetProductById(int Id)
        {
            return Ok(_sender.Send(new GetProductsByIdQuery(Id)));
        }


    }
}
