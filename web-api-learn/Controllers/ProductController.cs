using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using models;
using repository;
namespace web_api_learn.Controllers
{
    [RoutePrefix("products")]
    public class ProductController : ApiController
    {
        private readonly IProductRepository _productRepository;

        //public ProductController()
        //{
        //    _productRepository = new ProductRepository();
        //}
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        /// <summary>
        /// Retrieve a item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id}")]
        [HttpGet]
        public Product GetProduct(int id)
        {
            return _productRepository.GetProduct(id);
        }
        /// <summary>
        /// Update an item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id}")]
        [HttpPut]
        public HttpResponseMessage UpdateProduct(int id)
        {
            try
            {
                _productRepository.UpdateProduct(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                //log using ELMAH
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [HttpGet]
        public IEnumerable<Product>  GetAllProducts()
        {
         return _productRepository.GetProducts();
        }
        [Route("")]
        [HttpPost]
        public HttpResponseMessage SaveProduct(Product product)
        {


            try
            {
                _productRepository.SaveProduct(product);
                return Request.CreateResponse(HttpStatusCode.Created);

            }
            catch (Exception ex)
            {
                
                //log it
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
