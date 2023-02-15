using test;
using test.Interfaces;
using test.Mock;
using test.tables;


WebshopContext _context = new WebshopContext();
IRepository repository = new Repository(_context);

Console.WriteLine("add meg a cipo nvet");
var  ujCipoNeve = Console.ReadLine();

Console.WriteLine("add meg a cipo leirasat");
var ujCipoDesc = Console.ReadLine(); 

Console.WriteLine("add meg a cipo imgurljet");
var ujCipoImg = Console.ReadLine();

Console.WriteLine("add meg a cipo arat");
var ujCipoAr = Console.ReadLine();

//Product newCipo = ;

//repository.CreateProduct(newCipo);

//var dp = new DisplayProduct(new MockRepository());

Console.WriteLine("melyik cipot szeretned valtoztatni");
var id = int.Parse(Console.ReadLine());

Console.WriteLine("add meg a cipo nevet");
var nevet = Console.ReadLine();

Console.WriteLine("add meg a cipo desc");
var desc = Console.ReadLine();

Console.WriteLine("add meg a cipo img");
var imgUrl = Console.ReadLine();

repository.UpdateProduct(id, nevet, desc, imgUrl);
