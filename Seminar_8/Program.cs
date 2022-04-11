// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.

int[,] Array(int row, int column)
{
    int[,] matrix = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix;
}
void PrintArray(int[,] matrixprint)
{
    for (int i = 0; i < matrixprint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixprint.GetLength(1); j++)
        {
            Console.Write($"{matrixprint[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeFirstLastRows(int[,] otherarray)
{
        int k;
        for (int j = 0; j < otherarray.GetLength(0); j++)
        {
            k = otherarray[0, j];
            otherarray[0, j] = otherarray[otherarray.GetLength(0) - 1, j];
            otherarray[otherarray.GetLength(0) - 1, j] = k;
        }
        Array(otherarray.GetLength(0), otherarray.GetLength(1));
    }
}

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
    
ChangeFirstLastRows(Array(x, y));
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void ChangeRowsToColumns ()
{
    int x = Convert.ToInt32(Console.ReadLine());
    // int y = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[x, x];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            matrix[i,j] = new Random().Next(1,10);
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int [,] changedmatrix = new int [x,x];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            changedmatrix[i,j] = matrix [j,i];
            Console.Write($"{changedmatrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
ChangeRowsToColumns ();


// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых 
// расположен наименьший элемент.

void DeleteRowAndColumn ()
{
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    
    int[,] matrix = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            int min = matrix[i,j];
            matrix[i,j] = new Random().Next(1,10);
            Console.Write($"{matrix[i,j]} ");
            if (matrix[i,j]<min)
            min = matrix[i,j];
        }
        Console.WriteLine();
    }
    Console.WriteLine(min);
    Console.WriteLine();
    int [,] changedmatrix = new int [x,y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            changedmatrix[i,j] = matrix[i,j];
            if (i==0) changedmatrix[0,j] = matrix[x-1,j];
            if (i==x-1) changedmatrix[x-1,j] = matrix[0,j];
            Console.Write($"{changedmatrix[i,j]} ");
        }
        Console.WriteLine();
    }
}


