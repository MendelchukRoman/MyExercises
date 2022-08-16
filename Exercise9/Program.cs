// Показать последнюю цифру трёхзначного числa


static void last ()
{
Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int num = text[text.Length - 1] - '0';
Console.WriteLine("Последняя цифра:{0,3}", num);
}

last();





