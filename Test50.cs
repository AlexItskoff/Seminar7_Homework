/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1
7 -> такого числа в массиве нет
*/

// Задаем параметры массива: длину, высоту, максимальные и минимальные значения чисел
Console.WriteLine("Enter amount of rows in matrix");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter amount of columns in matrix");
int n = int.Parse(Console.ReadLine()!);

//Напоминаем, что количество рядов и колонок - числа положительные
if (m<=0 || n<=0)
{
    Console.WriteLine(" Both numbers should be positive!");
    return;
}

// Вводим минимальные и максимальные значения в массиве
Console.WriteLine("Enter minimum limit of matrix ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter maximum limit of matrix");
int max = int.Parse(Console.ReadLine()!);

// объясняем пользователю ошибку, которая возникнет, если он перепутает максимум и минимум
if (min>=max)
{
   Console.WriteLine(" Minimum should be less than maximum! Enter numbers correctly!"); 
   return;
}

// Вводим значения индексов для последующей проверки
Console.WriteLine("Enter index i (rows) for test ");
int iTest = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter index j (columns) for test");
int jTest = int.Parse(Console.ReadLine()!);

int[,] matrix = Create2DArray(m, n, min, max);  // Создаем массив

Print2DArray(matrix);                           // Выводим массив на печать
TestMassive(iTest,jTest);                       // Проверяем индексы согласно задаче

int[,] Create2DArray(int m, int n, int min, int max)  // Функция создания массива
{
    int[,] matrix = new int[m, n];
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
 
void Print2DArray(int[,] matrix)             // Процедура печати массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();

    }  
}

void TestMassive(int a, int b)    // Процедура проверки индексов согласно задаче
{
    if (a > m-1 || b > n-1)   // индексы в массиве начинаются с нуля!
    {
        Console.WriteLine();                            // Пропускаем строку в печатной форме
        Console.WriteLine("NO. Number does not exist there");
        return;
    }
    else
    {
        Console.WriteLine();                             // Пропускаем строку в печатной форме
        Console.WriteLine("Our number is" + "  " + matrix[a,b]);
    }
      
}
