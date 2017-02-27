using System.Collections.Generic;
using System.Web.Http;
using models;
using repository;
namespace web_api_learn.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductRepository _productRepository;

       // public ProductController()
        //{
            //_productRepository = new ProductRepository();
        //}
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [Route("products/{id}")]
        [HttpGet]
        public Product GetProduct(int id)
        {
            return _productRepository.GetProduct(id);
        }
        [Route("products")]
        [HttpGet]
        public IEnumerable<Product>  GetAllProducts()
        {
         
         return _productRepository.GetProducts();

            
        }
    }
}
