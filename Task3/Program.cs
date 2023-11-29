// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

Random rand = new Random();
int length = 10;
int[] array = new int[length];
int A = array[0];
int B = array[9];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);
    Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.WriteLine("обратный порядок массива:");

// Я пыталась:(

void PrintReverse (int number)
{
    if (number == array[0]) return;
    PrintReverse (array[array.Length - 1]);
    Console.Write(number + " ");
}

PrintReverse(B);

/*Array.Reverse(array);
Console.WriteLine(String.Join(',', array));*/








