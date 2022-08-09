// На вход принимает два числа, и выдает какое больше а какое меньше.
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int Max = 0;
if (a>b)
{
    Max = a;
}
else 
    Max = b;
    Console.WriteLine($"Наибольшее: {Max} =)");
