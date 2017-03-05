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
           return new Product() {Id = 1, IsActive = true, Name = "Purse"};
       }

       public IEnumerable<Product> GetProducts()
       {
           return new List<Product>()
           {
               new Product() {Id = 1, IsActive = true, Name = "Purse"},
               new Product() {Id = 2, IsActive = true, Name = "Torch"},
               new Product() {Id = 3, IsActive = true, Name = "Fork"},
               new Product() {Id = 4, IsActive = true, Name = "Battery"},
               new Product() {Id = 5, IsActive = true, Name = "Lens"},
               new Product() {Id = 6, IsActive = true, Name = "Phone"}
           };
       }

        public void SaveTempProduct(IProduct product)
        {
            var serializer =  new NewtonsoftSerializer();
            var cacheClient = new StackExchangeRedisCacheClient(serializer);
            var productList = new List<IProduct>();
            productList.Add(product);
            cacheClient.Add("abc", product);  
                   

        }
    }
}
