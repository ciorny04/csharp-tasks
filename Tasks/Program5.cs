int a = 5, b = 6, temp;
Console.WriteLine("przed zamianą: a = {0}, b = {1}", a, b);
temp = a;
a = b;
b = temp;
Console.WriteLine("po zamianie: a = {0}, b = {1}", a, b);