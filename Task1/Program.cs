// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.WriteLine("введите начальное число");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите конечное число");
int maximum = Convert.ToInt32(Console.ReadLine());

void PrintNumbers (int number)
{
    if (number < minimum) return;
    PrintNumbers (number-1);
    Console.Write(number + " ");
}

PrintNumbers(maximum);