
namespace models
{
   public class Product:IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

    public interface IProduct
    {
         int Id { get; set; }
         string Name { get; set; }
         bool IsActive { get; set; }
    }
}
