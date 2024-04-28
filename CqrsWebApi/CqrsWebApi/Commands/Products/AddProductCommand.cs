using CqrsMediatr.Models;
using MediatR;

namespace CqrsMediatr.Commands.Products
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
