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
<<<<<<< HEAD
        void SaveTempProduct(IProduct product);
=======
        void SaveProduct(Product product);
>>>>>>> origin/master
    }
}
