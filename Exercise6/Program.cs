// Выяснить является ли число чётным
Random x = new Random();
int num = x.Next(1, 99);
Console.WriteLine($"Число: {num} ");
//int num = Convert.ToInt32(Console.ReadLine()); //new Random().Next(1, 99);
if (num % 2 == 0)
{
    Console.WriteLine($"Число четное");
}
else Console.WriteLine($"Число нечетное");
