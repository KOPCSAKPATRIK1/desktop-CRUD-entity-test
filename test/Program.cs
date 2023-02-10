using test;


const string CONNECTIONSTRING = "server=localhost;database=webshop;uid=root;password=";

Console.WriteLine("add meg a cipo nvet");
var  ujCipoNeve = Console.ReadLine();
Console.WriteLine("add meg a cipo leirasat");
var ujCipoDesc = Console.ReadLine(); 
Console.WriteLine("add meg a cipo imgurljet");
var ujCipoImg = Console.ReadLine();

var ujCipo = new CreateProduct(CONNECTIONSTRING ,ujCipoNeve, ujCipoDesc, ujCipoImg);