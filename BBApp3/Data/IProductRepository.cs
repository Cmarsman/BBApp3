using BBApp3.Models;

namespace BBApp3.Data
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
