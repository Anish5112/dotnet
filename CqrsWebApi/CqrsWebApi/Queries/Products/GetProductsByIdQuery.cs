using CqrsMediatr.Models;
using MediatR;

namespace CqrsMediatr.Queries.Products
{
    public record GetProductsByIdQuery(int Id) : IRequest<Product>;
}
