// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine();
Console.WriteLine("Данная программа формирует трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine();
Console.WriteLine("Задайте параметры трехмерного массива.");
Console.WriteLine();

Console.Write("Задайте длину оси Х: ");
int userDataX = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте длину оси Y: ");
int userDataY = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте длину оси Z: ");
int userDataZ = Convert.ToInt32(Console.ReadLine());

int checkArray = userDataX*userDataY*userDataZ;
Console.WriteLine();

if(checkArray > 80
 |checkArray == 0
 | userDataX == 0
 | userDataY == 0
 | userDataZ == 0
 | userDataX < 0
 | userDataY < 0
 | userDataZ < 0)
{
    Console.WriteLine("Ошибка. По заданным параметрам массив создать нельзя.");
} 
else
{
int [,,] array3D = new int [userDataX, userDataY,userDataZ];
Console.WriteLine();
FillArr(array3D);

void FillArr (int [,,] arr)
{
    Console.WriteLine("Сформированный трехмерный массив: ");
    Console.WriteLine();
    int num = 10;
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[x,y,z] = num;
                Console.Write($"{arr[x,y,z]}{(x,y,z)} ");
                num++;
            } 
            Console.WriteLine();
        }
    }
}
}

