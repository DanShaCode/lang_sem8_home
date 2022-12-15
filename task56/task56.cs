// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArr (int [,] fillRnd)
{
    for (int ind = 0; ind < fillRnd.GetLength(0); ind++)
    {
        for (int jnd = 0; jnd < fillRnd.GetLength(1); jnd++)
        {
            fillRnd[ind, jnd] = new Random().Next(1,10);
        }
    }
}

void PrintArr (int [,] arrPrint)
{
    for (int index = 0; index < arrPrint.GetLength(0); index++)
    {
        for (int jndex = 0; jndex < arrPrint.GetLength(1); jndex++)
        {
            Console.Write($"{arrPrint[index, jndex]} ");
        }
        Console.WriteLine();
    }
}

void SumElRow (int [] num)
{
    int box = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            for (int z = 0; z <= num.GetLength(1) - 1; z++)
            {
                 
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Задайте размер массива.");
Console.WriteLine();
Console.Write("Введите кодличество строк: ");
int userDataR = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int userDataC = Convert.ToInt32(Console.ReadLine());

int [,] newArray = new int [userDataR,userDataC];

FillArr(newArray);
Console.WriteLine();
Console.WriteLine("Сгенерированный прямоугольный массив: ");
Console.WriteLine();
PrintArr(newArray);
Console.WriteLine();
Console.WriteLine("Сумма элементов в каждой строке: ");
Console.WriteLine();
