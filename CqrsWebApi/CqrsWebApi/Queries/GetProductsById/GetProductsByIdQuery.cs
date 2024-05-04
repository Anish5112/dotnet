using CqrsMediatr.Models;
using MediatR;

namespace CqrsMediatr.Queries.GetProductsById
{
    public record GetProductsByIdQuery(int Id) : IRequest<Product>;
}
