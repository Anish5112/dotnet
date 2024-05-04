using CqrsMediatr.Models;
using MediatR;

namespace CqrsMediatr.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {

    }
}
