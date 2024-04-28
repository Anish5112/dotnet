
using CqrsMediatr.Models;
using CqrsMediatr.Repositories.Interface;

namespace CqrsMediatr.Repositories.ConcreteClass
{
    public class ProductRepository : IProductRepository
    {

        List<Product> _products = new List<Product>()
        {
            new Product{ Id = 1, Name = "Iphone 15", Description ="Apple Iphone 15"},
            new Product{ Id = 1, Name = "Iphone 15 Pro", Description ="Apple Iphone 15 Pro"},
            new Product{ Id = 1, Name = "Iphone 15 Pro Max", Description ="Apple Iphone 15 Pro Max"}
        };
        public ProductRepository()
        {
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            return Task.FromResult(_products.AsEnumerable());
        }

        public Task<Product?> GetProductById(int productId)
        {
            return Task.FromResult(_products.FirstOrDefault(product => product.Id == productId));
        }
    }
}

