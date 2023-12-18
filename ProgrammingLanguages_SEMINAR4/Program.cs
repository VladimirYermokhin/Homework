//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)

/* void Main()
{
    while (true)
    {
        Console.Write("Введите целое число или 'q' для выхода: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "q")
        {
            Console.WriteLine("Программа завершена.");
            break;
        }

        if (int.TryParse(input, out int number))
        {
            int digitSum = CalculateDigitSum(number);

            if (digitSum % 2 == 0)
            {
                Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                break;
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {number} нечётная.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
        }
    }
}

int CalculateDigitSum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Main(); */

//Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)

/* void Main()
{

    int arraySize = 10;


    int[] array = GenerateRandomArray(arraySize, 100, 999);

    Console.WriteLine("Массив случайных трехзначных чисел:");
    PrintArray(array);


    int evenCount = CountEvenNumbers(array);


    Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
}

int[] GenerateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CountEvenNumbers(int[] array)
{
    int evenCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCount++;
        }
    }

    return evenCount;
}
Main(); 
*/

//Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)

void Main()
{

    int arraySize = 5;


    int[] array = { 1, 2, 3, 4, 5 };


    Console.WriteLine("Исходный массив:");
    PrintArray(array);


    ReverseArray(array);


    Console.WriteLine("Перевернутый массив:");
    PrintArray(array);
}

static void ReverseArray(int[] array)
{
    int left = 0;
    int right = array.Length - 1;


    while (left < right)
    {

        int temp = array[left];
        array[left] = array[right];
        array[right] = temp;


        left++;
        right--;
    }
}

static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Main();

