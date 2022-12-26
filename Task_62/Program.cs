/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"0{array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int[,] SpiralMatrix(int n)
{
    int[,] sqareMatrix = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
        sqareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        {
            j++;
        }
        else 
        if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        {
            i++;
        }
        else 
        if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
    return sqareMatrix;    
}

int n = GetNumber("Введите расмер квадратнотго массива -> ");

WriteArray(SpiralMatrix(n));

