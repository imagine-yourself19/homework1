Console.WriteLine("Введите три числа для определения максимального");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a < b && b < c) max = c;
if (a > b && b < c) max = a;
if (a < b && b > c) max = b;
Console.WriteLine($"Из трех чисел {a} {b} {c} наибольшим является {max}");