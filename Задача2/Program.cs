Console.WriteLine("Введите два числа для определения максимального");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
Console.WriteLine($"Из чисел {numberA} и {numberB} число {max} является наибольшим");
