/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] matrix = 
{
    {1, 4, 7, 2},
    {5, 2, 2, 3},
    {2, 1, 1, 4},
    {5, 2, 6, 7},
    {1, 1, 5, 2},
    {2, 1, 1, 4}
};

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

void FindMin (int[] array)
{
    int minElem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minElem > array[i] )
        {
            minElem = array[i];
        }
    }
    
    
    for (int i = 1; i < array.Length; i++)
    {
        if (minElem == array[i] )
        {
            Console.WriteLine($"Номер строки с наименьшей суммой элементов: {i+1} строка");
        }
    }
}

int[] SummRow(int[,] matrix)
{
    int[] resultat = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int elemRow = i;
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ = summ + matrix[i, j];

        }
         resultat[i] = summ;
    }
    return resultat;
}

PrintMatrix(matrix);
Console.WriteLine("Сумма всех строк:");
PrintArray(SummRow(matrix));
Console.WriteLine("________________________");
FindMin(SummRow(matrix));
Console.WriteLine("________________________");
