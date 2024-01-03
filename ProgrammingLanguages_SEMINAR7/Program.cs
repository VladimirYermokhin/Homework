//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)


/* 
void Main()
{
    Console.Write("Введите M: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    PrintNumbersInRange(m, n);
}

void PrintNumbersInRange(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        PrintNumbersInRange(m + 1, n);
    }
}

Main(); 
*/


//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
/* 
void Main()
{
    Console.Write("Введите значение m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите значение n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int result = AckermannFunction(m, n);

    Console.WriteLine($"Значение функции Аккермана для m={m} и n={n}: {result}");
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }

    return 0; // Для всех остальных случаев
}

Main();
 */


//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
void Main()
{
    int length = 10;
    int[] array = GenerateRandomArray(length);

    Console.WriteLine("Исходный массив:");
    PrintArray(array, length - 1);

    Console.WriteLine("\nМассив в обратном порядке:");
    PrintArrayReverse(array, length - 1);
}

int[] GenerateRandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 100); // Задайте диапазон чисел по вашему выбору
    }

    return array;
}

static void PrintArray(int[] arr, int index)
{
    for (int i = 0; i <= index; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

static void PrintArrayReverse(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write(arr[index] + " ");
        PrintArrayReverse(arr, index - 1);
    }
}



Main();