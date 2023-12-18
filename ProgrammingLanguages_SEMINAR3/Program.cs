//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
/* void Main()
{

    int[] array = GenerateRandomArray(10, 1, 100);

    int count = CountElementsInRange(array, 20, 90);


    Console.WriteLine($"Количество элементов в отрезке [20, 90]: {count}");
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

int CountElementsInRange(int[] array, int lowerBound, int upperBound)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] >= lowerBound && array[i] <= upperBound)
        {
            count++;
        }
    }

    return count;
}

Main (); */

// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
/* void Main()
{

    int[] array = GenerateRandomArray(10, 1, 100);

    // Находим количество чётных чисел в массиве
    int evenCount = CountEvenNumbers(array);

    // Выводим результат
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

int CountEvenNumbers(int[] array)
{
    int evenCount = 0;

    // Используем цикл for для перебора элементов массива
    for (int i = 0; i < array.Length; i++)
    {
        // Проверяем, является ли элемент чётным
        if (array[i] % 2 == 0)
        {
            evenCount++;
        }
    }

    return evenCount;
}
Main(); */

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
/* void Main()
{

    double[] array = { 3.14, 2.71, 5.55, 1.23, 4.44, 6.66, 8.88, 9.99, 7.77, 10.1 };


    double difference = FindDifference(array);


    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
}

double FindDifference(double[] array)
{

    if (array.Length == 0)
    {
        throw new InvalidOperationException("Массив не содержит элементов.");
    }


    double maxElement = array[0];
    double minElement = array[0];


    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }

        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }


    double difference = maxElement - minElement;

    return difference;
}
Main(); */

//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
/* void Main()
{
    // Задаем натуральное число в диапазоне от 1 до 100000
    int number = 98765;

    // Создаем массив из цифр числа
    int[] digitArray = CreateDigitArray(number);

    // Выводим результат
    Console.WriteLine("Массив из цифр числа:");
    for (int i = 0; i < digitArray.Length; i++)
    {
        Console.Write($"{digitArray[i]} ");
    }
}

int[] CreateDigitArray(int number)
{
    // Подсчитываем количество цифр в числе
    int digitCount = (int)Math.Floor(Math.Log10(number) + 1);

    // Создаем массив из цифр числа
    int[] digitArray = new int[digitCount];

    // Заполняем массив цифрами числа
    for (int i = digitCount - 1; i >= 0; i--)
    {
        digitArray[i] = number % 10;
        number /= 10;
    }

    return digitArray;
}

Main(); */

// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)

















