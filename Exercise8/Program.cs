// Показать четные числа от 1 до N
Console.Write("Массив: ");
int [] array = new int [10];
Random num = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = num.Next(1, 21);
Console.Write($"{array[i]+ " "}");
}
Console.WriteLine();
Console.Write("Четные числа: ");
 for (int i = 0; i < array.Length; i++)
{
   if (array[i] % 2 == 0)
   {
   Console.Write($"{array[i]+ " "}");
   }
}

