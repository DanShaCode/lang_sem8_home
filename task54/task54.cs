// Задача 54.

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

void SortArray (int [,] rowSorting)
{
    int box = 0;
    for (int ind = 0; ind < rowSorting.GetLength(0); ind++) // Щелкаем строки
    {
        for (int jnd = 0; jnd < rowSorting.GetLength(1); jnd++) // Щелкаем столбцы
        {
            for (int x = 0; x < rowSorting.GetLength(1) - 1; x++) // Сортируем массив
            {
                if (rowSorting[ind, x] < rowSorting[ind, x + 1]) // Условие сортировки
                {
                    box = rowSorting[ind, x];
                    rowSorting[ind, x] = rowSorting[ind, x + 1];
                    rowSorting[ind, x + 1] = box;
                }
            }
        }
    }     
}

Console.WriteLine();
Console.WriteLine("Данная программа создает случайный массив"); 
Console.WriteLine("и сортирует элементы массива в каждой строчке по убыванию.");
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
Console.WriteLine("Сгенерированный массив: ");
Console.WriteLine();
PrintArr(newArray);
Console.WriteLine();
SortArray(newArray);
Console.WriteLine("Отсортированный массив: ");
Console.WriteLine();
PrintArr(newArray);