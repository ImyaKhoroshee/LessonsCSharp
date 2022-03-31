﻿// Задайте двумерный массив размером m×n, заполненный случайными целыми двузначныеми числами.

// void NewRandomArray (int m, int n)
// {
//     int [,] matrix = new int [m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix [i, j] = new Random().Next(-99, 100);
//             Console.Write($"{matrix[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// NewRandomArray (2, 6);

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по 
// формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// void NewRandomArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = i + j;
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// NewRandomArray(2, 6);

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените 
// эти элементы на их квадраты.

// void NewRandomArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix [i, j] = new Random().Next(1, 10);

//             if (i%2 == 0 && j%2 == 0)
//             {

//                 matrix [i, j] =  matrix[i, j] * matrix[i, j];
//             }
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// NewRandomArray(3, 3);


// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

void NewRandomArray(int m, int n)
{
    int sum = 0;
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            if (i == j)
            {

                sum = sum + matrix[i, j];
            }
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("The sum is: " + sum);
}

NewRandomArray(3, 3);