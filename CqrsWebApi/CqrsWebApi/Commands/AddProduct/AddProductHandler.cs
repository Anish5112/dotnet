using CqrsMediatr.Models;
using CqrsMediatr.Repositories.Interface;
using MediatR;

namespace CqrsMediatr.Commands.Products
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public AddProductHandler(IProductRepository productRepository) => _productRepository = productRepository;

        public Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            return _productRepository.AddProduct(request.Product);
        }
    }
}
