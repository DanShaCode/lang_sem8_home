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
    for (int i = 0; i < fillRnd.GetLength(0); i++)
    {
        for (int j = 0; j < fillRnd.GetLength(1); j++)
        {
            fillRnd[i, j] = new Random().Next(1,10);
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

