int [,] n = {{5, 2, 1, 9}, {1, 2, 3, 4}};


for (int i = 0; i < n.GetLength(0); i++)
{
    int rowSum = 0;
    int max1 = 0;
    int max2 = 0;
    int max = 0;
    for (int j = 0; j < n.GetLength(1); j ++)
    {
        rowSum = rowSum + n[i, j];
    }
    Console.WriteLine(max1);
}






//=========================================================================

// Количество итераций = количество столбцов - 1

// Открыть цикл

// int count = 0;

// // 1. Итерация

// int sumCol = n[0, 0] + n[0, 1 + count(0)];
// int box = sumCol;
// count = count + 1;

// // 2. Итерация

// int count = 1;
// int sumCol = box + n [0, 1 + count(1)];
// int box = sumCol;
// count = count + 1;

// // 3. Итерация

// int count = 2;
// int sumCol = box + n [0, 1 + count(2)];
// int box = sumCol;
// count = count + 1;

// После цикла for

//Console.Write(sumCol);

//=========================================================================

// 00 01 = Res

// res + 02 = res

// res + 03 = sumEl

