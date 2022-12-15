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

int SumLineElements(int[,] sumArr, int i) 
{
  int sumLine = sumArr[i,0]; 
  for (int j = 1; j < sumArr.GetLength(1); j++)
  {
    sumLine += sumArr[i,j];
  }
  return sumLine;
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

int minSumLine = 0;
int sumLine = SumLineElements(newArray, 0);
for (int i = 1; i < newArray.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(newArray, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");