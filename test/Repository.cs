using test.Interfaces;
using test.Models;

namespace test;

public class Repository : IRepository
{
    private readonly WebshopContext _context;

    public Repository(WebshopContext context) 
    { 
        _context = context;
    }

    public void CreateProduct(Product product)
    {
        _context.Add(product);
        _context.SaveChanges();
    }

    public Product[] GetProducts()
    {
        var productsQry = _context.Products.OrderBy(p => p.Id);

        return productsQry.ToArray();
    }

    public int UpdateProduct(Product changeProduct)
    {
        var meglevo = _context.Products.SingleOrDefault(p => p.Id == changeProduct.Id);
        if (changeProduct.Name == null) 
        {
            meglevo.Name = meglevo.Name;
        }
        else
        {
            meglevo.Name = changeProduct.Name;
        }
        if (changeProduct.Price == null)
        {
            meglevo.Price = meglevo.Price;
        }
        else
        {
            meglevo.Price = changeProduct.Price;
        }
        if (changeProduct.Desc == null)
        {
            meglevo.Desc = meglevo.Desc;
        }
        else
        {
            meglevo.Desc = changeProduct.Desc;
        }
        return _context.SaveChanges();


    }

    public void DeleteProduct()
    {
        throw new NotImplementedException();
    }
}
