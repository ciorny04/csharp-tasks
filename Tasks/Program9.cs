Console.Write("Podaj pierwszy numer: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj drugi numer: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj trzeci numer: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj czwarty numer: ");
int d = Convert.ToInt32(Console.ReadLine());

int average = (a + b + c + d) / 4;
Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", a, b, c, d, average);