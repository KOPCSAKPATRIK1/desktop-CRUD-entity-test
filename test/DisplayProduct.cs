
using test.Interfaces;

namespace test;

public class DisplayProduct
{
    private IRepository _repository;

    public DisplayProduct(IRepository repo)
    {

// to repository
//        var productQry = productContext.Product
//            .OrderBy(p => p.Name); //.Select(p => $"{p.Id}; {p.Name}; {p.Desc}; {p.ProductImage}\n");

        _repository = repo;
    }

    public void DoDisplay()
    {
        var products = _repository.GetProducts();

        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id}; {p.Name}; {p.Desc}; {p.ImageUrl}\n");
        }



    }

}
