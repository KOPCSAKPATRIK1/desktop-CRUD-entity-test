using test.Interfaces;
using test.tables;

namespace test;

public class Repository : IRepository
{
    private readonly WebshopContext _context;
    private tables.WebshopContext context;

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
        throw new NotImplementedException();
    }

    public int UpdateProduct(int id, string? newName, string? newDesc, string? newImageUrl)
    {
        var meglevo = _context.Products.SingleOrDefault(p => p.Id == id);
        if (meglevo == null)
        {
            return 0;
        }
        if (newName == null)
        {
            meglevo.Name = meglevo.Name;
        }
        else
        {
            meglevo.Name = newName;
        }
        if (newDesc == null)
        {
            meglevo.Desc = meglevo.Desc;
        }
        else
        {
            meglevo.Desc = newDesc;
        }
        if (newImageUrl == null)
        {
            meglevo.ImageUrl = meglevo.ImageUrl;
        }
        else
        {
            meglevo.ImageUrl = newImageUrl;
        }
        meglevo.Desc = newDesc;
        meglevo.ImageUrl = newImageUrl;
        return _context.SaveChanges();


    }

    Product[] IRepository.GetProducts()
    {
        throw new NotImplementedException();
    }
}
