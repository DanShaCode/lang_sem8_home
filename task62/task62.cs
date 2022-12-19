// Задача 62. 
// Создать массив 4 на 4 заполненый нулями.
// Этот же массив заполнить спирально числами от 1 до 16.

// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Начало программы ==============================================================================

int[,] array = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

int w = array.GetLength(0) - 1;
int h = array.GetLength(1) - 1;
int row = 0;
int col = 0;
int num = 1;

Console.WriteLine();
Console.WriteLine("Заданный пустой массив 4 * 4:");
Console.WriteLine();
PrintArr(array);
Console.WriteLine();
SnakeFill(array);
Console.WriteLine();
Console.WriteLine("Этот же массив заполненный числами по спирали: ");
Console.WriteLine();
PrintArr(array);

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SnakeFill(int[,] array)
{
    for (col = 0; col <= w; col++)
    {
        array[row, col] = num;
        num++;
    }
    for (row = 1; row <= h - 1; row++)
    {
        col = w;
        array[row, col] = num;
        num++;
    }
    for (col = w; col > 0; col--)
    {
        row = h;
        array[row, col] = num;
        num++;
    }
    for (row = h; row > 1; row--)
    {
        col = 0;
        array[row, col] = num;
        num++;
    }
    for (col = 0; col <= w - 1; col++)
    {
        array[row, col] = num;
        num++;
    }
    for (col = w - 1; col > 0; col--)
    {
        row = 2;
        array[row, col] = num;
        num++;
    }
}