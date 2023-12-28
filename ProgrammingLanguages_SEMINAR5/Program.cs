//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
/* void Main()
{
int[,] array = new int[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = new Random().Next(1, 10);
    Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}

    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца: ");
    int col = Convert.ToInt32(Console.ReadLine());


    int result = FindElement(array, row, col);


    if (result != -1)
    {
        Console.WriteLine($"Элемент в позиции ({row}, {col}) равен {result}");
    }
    else
    {
        Console.WriteLine($"Элемент в позиции ({row}, {col}) не найден");
    }
}


int FindElement(int[,] array, int row, int col)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);


    if (row >= 0 && row < numRows && col >= 0 && col < numCols)
    {
        return array[row, col];
    }

    // Возвращаем -1, если позиция не найдена
    return -1;
}

Main(); 
*/


//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
/* 
void Main()
{
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    SwapRows(array, 0, array.GetLength(0) - 1);
    Console.WriteLine("\nМассив после замены:");
    PrintArray(array);
}

void PrintArray(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);
    for (int row = 0; row < numRows; row++)
    {
        for (int col = 0; col < numCols; col++)
        {
            Console.Write(array[row, col] + " ");
        }
        Console.WriteLine();
    }
}

void SwapRows(int[,] array, int row1, int row2)
{
    int numCols = array.GetLength(1);
    for (int col = 0; col < numCols; col++)
    {
        int temp = array[row1, col];
        array[row1, col] = array[row2, col];
        array[row2, col] = temp;
    }
}

Main(); 
*/


//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Main()
{
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    int minSumRow = FindRowWithMinSum(array);

    Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRow + 1}");
}

void PrintArray(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    for (int row = 0; row < numRows; row++)
    {
        for (int col = 0; col < numCols; col++)
        {
            Console.Write(array[row, col] + " ");
        }
        Console.WriteLine();
    }
}

int FindRowWithMinSum(int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    int minSumRow = 0;
    int minSum = int.MaxValue;

    for (int row = 0; row < numRows; row++)
    {
        int currentSum = 0;

        for (int col = 0; col < numCols; col++)
        {
            currentSum += array[row, col];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRow = row;
        }
    }

    return minSumRow;
}
Main();
