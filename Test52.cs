/*Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int[,] matrix = Create2DArray(m, n, min, max);  // исполняемые процедуры и функция
Print2DArray(matrix);
AvgInColumns(matrix);

int[,] Create2DArray(int m, int n, int min, int max)    //Генерируем массив
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
 
void Print2DArray(int[,] matrix)            // Выводим массив на печать
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

void AvgInColumns( int[,] arr)     //Считаем среднее арифметическое по столбцам
{
    for ( int j = 0;  j < n; j++)
           {
            double sum = 0;                         //сумма в столбце 
            double avg = 0;                         //  среднее арифметическое в столбце  может быть дробным
                for ( int i = 0; i < m; i++)
                {
                    sum = sum + arr[i,j];
                    avg = sum/m;
                }
                Console.WriteLine("Average in {0} column: {1}", j, Math.Round(avg, 2));
                }

}


 




