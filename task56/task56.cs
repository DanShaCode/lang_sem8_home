// Задача 56.
// Задать прямоугольный двумерный массив.
// Найти строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Начало программы =======================================================================================

Console.WriteLine();
Console.WriteLine("Создайте прямоугольный массив и найдите ");
Console.WriteLine("строку с наименьшей суммой элементов.");
Console.WriteLine();

Console.WriteLine("Задайте размер массива.");
Console.WriteLine();
Console.Write("Введите количество строк: ");
int userDataR = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int userDataC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (userDataR <= 0
  | userDataC <= 0
  | userDataC == 1
  | userDataR == 1)
{
    Console.WriteLine("Ошибка ввода. Создать прямоугольный массив с заданными параметрами не представляется возможным.");
}

else
{
    int[,] newArray = new int[userDataR, userDataC];

    FillMultiArr(newArray);
    Console.WriteLine();
    Console.WriteLine("Сгенерированный прямоугольный массив: ");
    Console.WriteLine();
    PrintMuliArr(newArray);
    ColSum(newArray);
    int[] newArr = ColSum(newArray);
    FindMinCol(newArr);
}

void FillMultiArr(int[,] fillRnd)
{
    for (int i = 0; i < fillRnd.GetLength(0); i++)
    {
        for (int j = 0; j < fillRnd.GetLength(1); j++)
        {
            fillRnd[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintMuliArr(int[,] arrPrint)
{
    for (int index = 0; index < arrPrint.GetLength(0); index++)
    {
        for (int jndex = 0; jndex < arrPrint.GetLength(1); jndex++)
        {
            Console.Write($"{arrPrint[index, jndex]} {(index, jndex)} ");
        }
        Console.WriteLine();
    }
}

int[] ColSum(int[,] arr)
{
    int[] newArray = new int[arr.GetLength(0)];
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
    return newArray;
}

void FindMinCol(int[] min)
{
    int length = min.Length;
    int i = 0;
    int minimum = min[i];
    int col = 0;
    for (i = 0; i < length - 1; i++)
    {
        if (minimum > min[i + 1])
        {
            minimum = min[i + 1];
            col = i + 1;
        }
        else
        {
            minimum = min[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"{"Минимальное значение суммы элементов"} ({minimum}) {"в строке"} {col + 1}");
}