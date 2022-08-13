// Написать программу вычисления значения функции y = f(a). Допустим, такой:
// у = x – 2, если x > 0,
// y = 0, если x = 0,
// y = |x|, если x < 0.
int x;
int y;
Console.Write ("Число x: ");
x = Convert.ToInt32(Console.ReadLine ());
if (x>0)
{
    y = x - 2;
    Console.WriteLine ($"Число y: {y} ");
}
else if(x == 0)
{
    y = 0;
    Console.WriteLine ($"Число y: {y} ");
}
else if (x < 0)
{
    y = (x*(-1));
    Console.WriteLine ($"Число y: {y} ");
}

