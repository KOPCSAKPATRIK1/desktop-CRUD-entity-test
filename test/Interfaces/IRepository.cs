

using test.Models;

namespace test.Interfaces
{
    public interface IRepository
    {
        void CreateProduct(Product product);
        int UpdateProduct(Product product);
        Product[] GetProducts();

        int DeleteProduct(int? id);


    }
}
