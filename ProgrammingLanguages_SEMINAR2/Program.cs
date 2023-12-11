//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

/* Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 ==0 && num %23 ==0)
{
    Console.WriteLine("Число Кратно и 7 и 23");
}
else 
{
    Console.WriteLine("Число не подходит");
}

 */

// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)


//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

/* Console.WriteLine("Введите число для координаты Х");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для координаты Y");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Это 1-ая четверть координатной плоскости");

}

else if (X < 0 && Y < 0)
{
    Console.WriteLine("Это 3-я четверть координатной плоскости");
}

else if (X < 0 && Y > 0)
{
    Console.WriteLine("Это 2-ая четверть координатной плоскости");
}

else if (X > 0 && Y < 0)
{
    Console.WriteLine("Это 4-ая четверть координатной плоскости");
}
else
{
    Console.WriteLine("Ни одно из чисел не должно быть равно 0");
} */

// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)


//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

/* Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
// создаем метод нахождения большей цифры в числе уменьшение порядка числа на 10
int FindMaxDigit(int num)
{
    int MaxDigit = 0;
    while (num > 0)
    {
        int digit = num % 10;
        MaxDigit = Math.Max(MaxDigit, digit);
        num /= 10;
    }

    return MaxDigit;

}
if (num > 9 && num < 100)
{
    int MaxDigit = FindMaxDigit(num);
    Console.WriteLine($"Большая цифра из числа `{num}` это цифра `{MaxDigit}`");
}

else
{
    Console.WriteLine(" Это число не из отрезка [10,99] ");
} */

// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)



//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

/* Console.WriteLine("Введите натурально число N ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    string numString = num.ToString();

    for (int i = 0; i < numString.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"{numString[i]}");
        }
        else
        {
            Console.Write($", {numString[i]}");
        }
    }

    Console.WriteLine();
}
else
{
    Console.WriteLine("Число не является натуральным. Пожалуйста, введите натуральное число.");
} */

// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)