// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ange en produkt?");
string _product = Console.ReadLine();
Console.WriteLine($"Ange priset pa en {_product}");

string s = Console.ReadLine();
decimal _price = decimal.Parse( s );
Console.WriteLine($"Priset pa en {_product} ar {_price}");

Console.WriteLine($"Hur manga {_product} vill du kopa?");
s = Console.ReadLine();
int _amount = int.Parse(s);

Console.WriteLine($"Priset pa {_amount} {_product} ar {_price*_amount:C}");