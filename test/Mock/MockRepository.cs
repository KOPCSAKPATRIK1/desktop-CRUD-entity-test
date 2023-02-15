using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Interfaces;
using test.tables;

namespace test.Mock
{
    internal class MockRepository : IRepository
    {
        public void CreateProduct(Product product)
        {
            
        }

        public Product[] GetProducts()
        {
            return Array.Empty<Product>();
        }

        public int UpdateProduct(int id, string? newName, string? newDesc, string? newImageUrl)
        {
            return 1;
        }
    }
}
