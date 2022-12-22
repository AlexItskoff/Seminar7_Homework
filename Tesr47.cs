/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// Задаем параметры массива: длину, высоту, максимальные и минимальные значения чисел
Console.WriteLine("Enter amount of rows in matrix");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(" Enter amount of columns in matrix");
int n = int.Parse(Console.ReadLine()!);
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

double[,] matrix = Create2DArray(m, n, min, max);    // Задействуем ниже описанную функцию

double[,] Create2DArray(int m, int n, int min, int max)  // Функция формирует и выводит на печать массив
{
    double[,] matrix = new double[m, n];
       for (int i = 0; i < matrix.GetLength(0); i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * (max - min) + min;  // таким образом в массив попадают числа в указанном диапазоне
            Console.Write(Math.Round(matrix[i,j], 2) + "   "  );    // округляем до сотых
        }
            Console.WriteLine();    // вывод на печать таблицы
    }
    return matrix;
}
 
