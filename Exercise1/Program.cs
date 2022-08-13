// По двум заданным числам проверять является ли первое квадратом второго
// 1)Задать 2 числа
// 2)Проверить является ли квадратом


int a = new Random().Next(1, 99);
int b = new Random().Next(1, 99);
int qub = b*b;
Console.WriteLine ($"Первое число {a}");
Console.WriteLine ($"Второе число {b}");
if (a == qub)
{
   Console.WriteLine($"{a} является квадратом {b}: {qub}");
}
else 
{
    Console.WriteLine($"{a} не является квадратом {b}");
}
