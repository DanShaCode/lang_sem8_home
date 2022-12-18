// Задача 62. 
// Создать массив 4 на 4 заполненый нулями.
// Этот же массив заполнить спирально числами от 1 до 16.

// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Начало программы ==============================================================================

int[,] snake = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

Console.WriteLine();
Console.WriteLine("Заданный пустой массив 4 * 4:");
Console.WriteLine();
PrintArr(snake);
Console.WriteLine();
SnakeFillArr(snake);
Console.WriteLine();
Console.WriteLine("Этот же массив заполненный числами по спирали: ");
Console.WriteLine();
PrintArr(snake);

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

void SnakeFillArr(int[,] arr)
{
    int num = 0;
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        num++;
        int i = 0;
        arr[i, j] = num;
        int temp = num;
        for (int k = 0; k < arr.GetLength(0) - 1; k++)
        {
            temp++;
            int l = 3;
            arr[k, l] = temp;
            int temp1 = temp + 5;
            for (int x = 0; x < arr.GetLength(1); x++)
            {
                temp1--;
                int y = 3;
                arr[y, x] = temp1;
                int temp2 = temp1 + 6;
                for (int a = 1; a < arr.GetLength(0) - 1; a++)
                {
                    temp2--;
                    int b = 0;
                    arr[a, b] = temp2;
                    int temp3 = temp2 + 1;
                    for (int z = 1; z < arr.GetLength(1) - 1; z++)
                    {
                        temp3 = temp3 + 1;
                        int g = 1;
                        arr[g, z] = temp3;
                        int temp4 = temp3 - 1;
                        for (int v = 1; v < arr.GetLength(0) - 1; v++)
                        {
                            temp4++;
                            int c = 2;
                            arr[v, c] = temp4;
                            int temp5 = temp4;
                            for (int q = 1; q < arr.GetLength(1) - 2; q++)
                            {
                                int s = 2;
                                arr[s, q] = temp5 + 1;
                            }
                        }
                    }
                }
            }
        }
    }
}