// Задача 54.
// Задайте двумерный массив. 
// Упорядочить по убыванию элементы каждой строки массива

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Начало программы ===============================================================================

Console.WriteLine();
Console.WriteLine("В данной программе вы можете создать массив и отсортировать");
Console.WriteLine("элементы массива по убыванию для каждой из строк.");
Console.WriteLine();

Console.WriteLine("Задайте размер массива.");
Console.WriteLine();
Console.Write("Введите количество строк: ");
int userDataR = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int userDataC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (userDataR <= 0
  | userDataC <= 0)
{
    Console.WriteLine("Ошибка ввода. Создать массив с заданными параметрами не представляется возможным.");
}
else
{
    int[,] newArray = new int[userDataR, userDataC];

    FillArr(newArray);
    Console.WriteLine("Сгенерированный массив: ");
    Console.WriteLine();
    PrintArr(newArray);

    Console.WriteLine();
    SortArray(newArray);
    Console.WriteLine("Отсортированный массив: ");
    Console.WriteLine();
    PrintArr(newArray);
}

void FillArr(int[,] fillRnd)
{
    for (int i = 0; i < fillRnd.GetLength(0); i++)
    {
        for (int j = 0; j < fillRnd.GetLength(1); j++)
        {
            fillRnd[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArr(int[,] arrPrint)
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

void SortArray(int[,] rowSorting)
{
    int box = 0;
    for (int ind = 0; ind < rowSorting.GetLength(0); ind++)
    {
        for (int jnd = 0; jnd < rowSorting.GetLength(1); jnd++)
        {
            for (int x = 0; x < rowSorting.GetLength(1) - 1; x++)
            {
                if (rowSorting[ind, x] < rowSorting[ind, x + 1])
                {
                    box = rowSorting[ind, x];
                    rowSorting[ind, x] = rowSorting[ind, x + 1];
                    rowSorting[ind, x + 1] = box;
                }
            }
        }
    }
}