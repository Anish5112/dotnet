using CqrsMediatr.Models;

namespace CqrsMediatr.Repositories.Interface
{
	public interface IProductRepository
	{
		Task<IEnumerable<Product>> GetProducts();
		Task<Product?> GetProductById(int productId);

    }

}

