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
    for (int j = 0; j < arr.GetLength(1) - 1; j++) // от 1 до 4 вправо
    {
        num++;
        int i = 0;
        arr[i,j] = num;
        int temp = num;
        for (int k = 0; k < arr.GetLength(0) - 1; k++) // от 4 до 7 вниз
        {
            temp++;
            int l = 3;
            arr[k,l] = temp;
            int temp1 = temp + 5;
            for (int x = 0; x < arr.GetLength(1); x++) // от 7 до 10 влево
            {
                temp1--;
                int y = 3;
                arr[y,x] = temp1;
                int temp2 = temp1 + 6;
                for (int a = 1; a < arr.GetLength(0) - 1; a++) // от 10 до 12 наверх
                {
                    temp2--;
                    int b = 0;
                    arr[a,b] = temp2;
                    int temp3 = temp2 + 1;
                    for (int z = 1; z < arr.GetLength(1) - 1; z++) // от 12 до 14 вправо
                    {
                        temp3 = temp3 + 1;
                        int g = 1;
                        arr[g,z] = temp3;
                        int temp4 = temp3 - 1;
                        for (int v = 1; v < arr.GetLength(0) - 1; v++) // от 14 до 15 вниз
                        {
                            temp4++;
                            int c = 2;
                            arr[v,c] = temp4;
                        }
                    }
                }
            }
        }
    }
}

Console.WriteLine();
PrintArr(snake);
Console.WriteLine();
SnakeFillArr(snake);
PrintArr(snake);