Console.WriteLine("Напишите число для получения стоящих до него четных");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <=a) 
{
    Console.WriteLine(i);
    i = i + 2;
}