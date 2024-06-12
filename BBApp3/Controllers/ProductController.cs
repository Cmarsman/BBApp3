using BBApp3.Data;
using Microsoft.AspNetCore.Mvc;

namespace BBApp3.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var products = _repository.GetAllProducts();
            return View(products);
        }
    }
}
