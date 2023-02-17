using test;
using test.Interfaces;
using test.Models;

WebshopContext _context = new WebshopContext();
IRepository repository = new Repository(_context);

Console.WriteLine("Add meg a cipo nevet");
var  CipoNeve = Ellenorzes(Console.ReadLine());



Console.WriteLine("add meg a cipo leirasat");
var CipoDesc = Ellenorzes(Console.ReadLine());

int CipoAr;
do
{
    Console.WriteLine("add meg a cipo arat");
    if (int.TryParse(Console.ReadLine(), out CipoAr) && CipoAr > 0)
    {
        break;
    }
    Console.WriteLine("HIBA a szamnak es 0-nal nagyobbnak kell lennie");
}
while (true);


Console.WriteLine("add meg a cipo 1 imgurljet");
var CipoImgUrl1 = Ellenorzes(Console.ReadLine());

Console.WriteLine("add meg a cipo 2 imgurljet");
var CipoImgUrl2 = Ellenorzes(Console.ReadLine());

Console.WriteLine("add meg a cipo 3 imgurljet");
var CipoImgUrl3 = Ellenorzes(Console.ReadLine());

Console.WriteLine("add meg a cipo 4 imgurljet");
var CipoImgUrl4 = Ellenorzes(Console.ReadLine());

Product newCipo = new Product {
    Name = CipoNeve,
    Desc = CipoDesc,
    Price = CipoAr,
    ImageUrl1 = CipoImgUrl1,
    ImageUrl2 = CipoImgUrl2,
    ImageUrl3 = CipoImgUrl3,
    ImageUrl4 = CipoImgUrl4
};

repository.CreateProduct(newCipo);


foreach (var product in repository.GetProducts())
{
    Console.WriteLine($"Id: {product.Id}\nNev: {product.Name}\nLeiras: {product.Desc}\nAr: {product.Price}\n");
}





Console.WriteLine("melyik cipot szeretned valtoztatni");
int id;
do
{
    Console.WriteLine("add meg a cipo arat");
    if (int.TryParse(Console.ReadLine(), out id) && id > 0)
    {
        break;
    }
    Console.WriteLine("HIBA a szamnak es 0-nal nagyobbnak kell lennie");
}
while (true);

Console.WriteLine("add meg a cipo nevet");
var nev = Ellenorzes(Console.ReadLine());


Console.WriteLine("add meg a cipo desc");
var desc = Ellenorzes(Console.ReadLine());

int ar;
do
{
    Console.WriteLine("add meg a cipo arat");
    if (int.TryParse(Console.ReadLine(), out ar) && ar > 0)
    {
        break;
    }
    Console.WriteLine("HIBA a szamnak es 0-nal nagyobbnak kell lennie");
}
while (true);

Product changeCipo = new Product
{
    Id = id,
    Name = nev,
    Desc = desc,
    Price = ar
};

repository.UpdateProduct(changeCipo);*/

foreach (var product in repository.GetProducts())
{
    Console.WriteLine($"Id: {product.Id}\nNev: {product.Name}\nLeiras: {product.Desc}\nAr: {product.Price}\n");
}

Console.WriteLine("add meg a torlendo id-t");
var productId = int.Parse(Console.ReadLine());

repository.DeleteProduct(productId);

foreach (var product in repository.GetProducts())
{
    Console.WriteLine($"Id: {product.Id}\nNev: {product.Name}\nLeiras: {product.Desc}\nAr: {product.Price}\n");
}


string Ellenorzes(string? szoveg)
{
    while (string.IsNullOrEmpty(szoveg))
    {
        Console.WriteLine("HIBA a mezo nem lehet ures");
        szoveg = Console.ReadLine();
    }

    return szoveg;
}