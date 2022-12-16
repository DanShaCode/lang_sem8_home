// Задаем новый двумерный массив
int [,] multiArr = {{1,2,5},{1,9,3},{3,56,8}};

// Считаем сумму строк в двумерном массиве и отдаем значение суммы как элемент нового массива
int [] ColSum (int [,] arr) 
{
    int [] newArray = new int [arr.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        newArray[i] = sum;
        sum = 0;
    }
    // Возвращаем созданный массив
    return newArray; 
}

// Печатаем новый одномерный массив
void PrintArr (int [] print) 
{
    int length = print.Length;
    int i = 0;
    for (i = 0; i < length; i++)
    {
        Console.Write($"{print[i]} ");
    }
}

// Вычисляем минимальную сумму строк в массиве т выдаем строку в консоль
void FindMinCol (int [] min)
{
    int length = min.Length;
    int i = 0;
    int minimum = min[0];
    for (i = 0; i < length; i++)
    {
        if (min[i] < i) minimum = min[i];
    } 
    Console.WriteLine(minimum);
}

int [] newArr = ColSum(multiArr);

PrintArr(newArr);
Console.WriteLine();
FindMinCol(newArr);