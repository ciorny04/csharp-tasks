Console.Write("wpisz cyfrę ");
int x = int.Parse(Console.ReadLine());
Console.Write("Druga cyfra ");
int y = int.Parse(Console.ReadLine());
Console.Write("trzecia cyfra ");
int z = int.Parse(Console.ReadLine());

Console.WriteLine("wynik = {0}", (x + y) * z);
Console.WriteLine("wynik drugi = {0}", x * y + y * z);