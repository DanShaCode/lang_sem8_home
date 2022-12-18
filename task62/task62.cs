int[,] snake = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

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
        arr[i,j] = num;
        int temp = num;
        for (int k = 0; k < arr.GetLength(0) - 1; k++)
        {
            temp++;
            int l = 3;
            arr[k,l] = temp;
            int temp1 = temp + 5;
            for (int x = 0; x < arr.GetLength(1); x++)
            {
                temp1--;
                int y = 3;
                arr[y,x] = temp1;
            }
        }
    }
}

Console.WriteLine();
PrintArr(snake);
Console.WriteLine();
SnakeFillArr(snake);
PrintArr(snake);