using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models;
namespace repository
{
    public interface IProductRepository
    {
        Product GetProduct(int Id);
        IEnumerable<Product> GetProducts();
        void SaveProduct(Product product);
    }
}
