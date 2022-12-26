/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int GetNumber(string messege)
{
    int resultat;
    while (true)
    {
        Console.Write(messege);
        if (int.TryParse(Console.ReadLine(), out resultat) && resultat > 0)
        {
            break;
        }
        else Console.WriteLine("Ввели не число");
    }
    return resultat;
}

Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = GetNumber("Введите X: ");
int y = GetNumber("Введите Y: ");
int z = GetNumber("Введите Z: ");

void InitMatrix3D(int x, int y, int z)
{
    int[,,] matrix3D = new int[x, y, z];
    Random rnd = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix3D[i,j,k] = rnd.Next(10,100);
                Console.Write($"{matrix3D[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }

}

InitMatrix3D(x, y, z);