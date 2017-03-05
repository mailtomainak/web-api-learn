using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;
using StackExchange.Redis;
using StackExchange.Redis.Extensions.Core;
//using StackExchange.Redis.Extensions.Protobuf;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using StackExchange.Redis.Extensions.Newtonsoft;

namespace repository
{
   public class ProductRepository:IProductRepository
    {
        //ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("pub-redis-13084.ap-northeast-1-2.1.ec2.garantiadata.com:13084,password=641bf61d5585,abortConnect=false");
        List<Product>  prodList = new List<Product>();

       public Product GetProduct(int Id)
       {
           return new Product() {Id = 1, isActive = true, name = "Purse"};
       }

       public IEnumerable<Product> GetProducts()
       {
           return new List<Product>()
           {
               new Product() {Id = 1, isActive = true, name = "Purse"},
               new Product() {Id = 2, isActive = true, name = "Torch"},
               new Product() {Id = 3, isActive = true, name = "Fork"},
               new Product() {Id = 4, isActive = true, name = "Battery"},
               new Product() {Id = 5, isActive = true, name = "Lens"},
               new Product() {Id = 6, isActive = true, name = "Phone"}
           };
       }


        public void SaveTempProduct(Product product)
        {
            var serializer =  new NewtonsoftSerializer();
            var cacheClient = new StackExchangeRedisCacheClient(serializer);
            var productList = new List<Product>();
            productList.Add(product);
            cacheClient.Add("abc", product);  
                   

        }

       public void SaveProduct(Product product)
       {

       }

        public void UpdateProduct(int Id)
        {
           //call EF to update product
        }
    }
}
