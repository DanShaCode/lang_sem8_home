// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18

// Наполняем матрицу случайными целыми числами от 1 до 9
void FillRnd (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}

// Печатаем матрицу
void PrintMatrix (int [,] c)
{
    Console.WriteLine();
    for (int index = 0; index < c.GetLength(0); index++)
    {
        for (int jndex = 0; jndex < c.GetLength(1); jndex++)
        {
            Console.Write($"{c[index, jndex]} ");
        }
        Console.WriteLine();
    }
}

// Перемножаем элементы матрицы
int [,] MultiMatrix (int [,] a, int [,] b)
{
    int [,] c = new int [a.GetLength(0),b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0);i++)
    {
        for (int j = 0; j < b.GetLength(1);j++)
        {
            int sum = 0;
            for (int k = 0; k < a.GetLength(0);k++)
            {
                sum += a[i,k] * b[k,j];
            }
            c[i,j] = sum;
        }
    }
    return c;
}

Console.WriteLine();
Console.WriteLine("Задайте размер матрицы А.");
Console.WriteLine();
Console.Write("Введите количеcтво строк матрицы А: ");
int userDataAr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количеcтво столбцов матрицы A: ");
int userDataAc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Задайте размер матрицы B.");
Console.WriteLine();
Console.Write("Введите количеcтво строк матрицы B: ");
int userDataBr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количеcтво столбцов матрицы B: ");
int userDataBc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (userDataAc != userDataBr) 
{
Console.WriteLine ("Ошибка ввода. Данную матрицу умножать нельзя.");
Console.WriteLine("Число столбцов в матрице A должно быть равно количеству строк в матрице В!");
}
else
{
int [,] A = new int [userDataAr, userDataAc];
FillRnd(A);
Console.WriteLine("Сгенерированная матрица A:");
PrintMatrix(A);
Console.WriteLine();

int [,] B = new int [userDataBr, userDataBc];
FillRnd(B);
Console.WriteLine("Сгенерированная матрица B:");
PrintMatrix(B);

int [,] C = MultiMatrix(A,B);
Console.WriteLine();
Console.WriteLine("Результирующая матрица С: ");
PrintMatrix(C);
}