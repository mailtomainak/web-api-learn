using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;

namespace repository
{
   public class ProductRepository:IProductRepository
    {
       public Product GetProduct(int Id)
       {
           return new Product() {Id = 1, IsActive = true, Name = "Purse"};
       }

       public IEnumerable<Product> GetProducts()
       {
           return new List<Product>()
           {
               new Product() {Id = 1, IsActive = true, Name = "Purse"},
               new Product() {Id = 2, IsActive = true, Name = "Torch"}
           };
       }
    }
}
