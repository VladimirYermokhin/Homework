//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
/* 
char[,] Privet = new char[3, 3];
char FillChar = 'A';
for (int i = 0; i < Privet.GetLength(0); i++)
{
    for (int j = 0; j < Privet.GetLength(1); j++)
    {
        Privet[i, j] = FillChar;
        Console.Write(FillChar);
        FillChar++;
    }
    Console.WriteLine();
}
string ConvertCharArrayToString(char[,] Privet)
{
    string result = "";
    for (int i = 0; i < Privet.GetLength(0); i++)
    {
        for (int j = 0; j < Privet.GetLength(1); j++)
        {
            result += Privet[i, j];
        }
    }
    return result;
}
string resultString = ConvertCharArrayToString(Privet);
Console.WriteLine("\nРезультат в виде строки: " + resultString);
 */

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)
/* 
void Main()
{
    string inputString = "HelloGeekBrains";
    string resultString = UpperToLower(inputString);
    Console.WriteLine("Исходная строка: " + inputString);
    Console.WriteLine("Результат: " + resultString);
}

string UpperToLower(string input)
{
    return input.ToLower();
}

Main(); 
*/

//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Чтобы раскоментировать многострочный комментарий нужно выделить все строки включая строки с  /* */ и нажать сочетания клавиш Alt+ Shift + A(Английская)

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");

void Main()
{
    Console.WriteLine("Введите строку для проверки на палиндром:");
    string inputString = Console.ReadLine();

    if (IsPalindrome(inputString))
    {
        Console.WriteLine("Введенная строка является палиндромом.");
    }
    else
    {
        Console.WriteLine("Введенная строка не является палиндромом.");
    }
}

bool IsPalindrome(string str)
{
    // Приводим строку к нижнему регистру для учета регистра символов
    str = str.ToLower();

    int left = 0;
    int right = str.Length - 1;

    // Проверяем, является ли строка палиндромом
    while (left < right)
    {
        if (str[left] != str[right])
        {
            return false;
        }
        left++;
        right--;
    }

    return true;
}

Main();

