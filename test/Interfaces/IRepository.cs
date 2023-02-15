using test.tables;

namespace test.Interfaces
{
    public interface IRepository
    {
        void CreateProduct(Product product);
        int UpdateProduct(int id, string? newName, string? newDesc, string? newImageUrl);
        Product[] GetProducts();




    }
}
