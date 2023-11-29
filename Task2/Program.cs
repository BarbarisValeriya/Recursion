// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


Console.WriteLine("введите неотрицательное число n");
uint n = Convert.ToUInt32(Console.ReadLine());
if (n > 3) n = 3;

Console.WriteLine("введите неотрицательное число m");
uint m = Convert.ToUInt32(Console.ReadLine());
if (m > 5) m = 5;

static uint Akkerman(uint n, uint m)
{
    if (n == 0) return m + 1;
    if ((n != 0) && (m == 0)) return Akkerman(n-1, 1);
    else return Akkerman(n-1, Akkerman(n, m - 1));
}

Console.Write(Akkerman (n, m));


