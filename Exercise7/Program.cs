// Показать числа от -N до N

Console.Write($"Массив: ");
int [] array = new int [15];
Random num = new Random();
for (int i = 0; i < array.Length; i++ )
{
    array[i] = num.Next(-10, 10);
Console.Write($"{array[i]+ " "}");   // создание и заполнения массива
}
int temp;
for (int i = 0; i < array.Length -1; i++)
{
   for (int j = i + 1; j < array.Length; j++)
     {
         if (array[i] > array[j])
         {
           temp = array[i];
           array[i] = array[j];
           array[j] = temp;
         }
     }
}
Console.WriteLine();
 Console.Write($"от -N до N: ");
 for (int i = 0; i < array.Length; i++)
 {
 Console.Write($"{array[i]}" + " ");
 }
 
