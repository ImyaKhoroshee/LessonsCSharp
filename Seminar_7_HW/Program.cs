// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
// числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void TwoDimensionalDoubleRandomArray (int m, int n)
{
    double [,] matrix = new double [m, n];
    
    Console.WriteLine($"\nYour two-dimensional array with floating point values is provided below:\n");

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix [i, j] = Convert.ToDouble(new Random().Next(-99, 100) / 10.0); // случайные числа с плавающей точкой от -9.9 до 9.9 
            Console.Write($"{matrix [i, j]} ");    // вышенаписанная конструкция "съела" мой вечер :D
        }
        Console.WriteLine();
    } 
}
Console.Write("Enter the quantity of rows: "); 
int rows = Convert.ToInt32(Console.ReadLine()); // Как я поняла, это для меня больше надо
Console.Write("Enter the quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
TwoDimensionalDoubleRandomArray (rows, columns);



// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет


void FindValueByIndexInTwoDimArr(int index, int jindex) // jindex :) очень понравилось придуманное название
{
    int[,] secondmatrix = new int [3, 4];

    int elementarray = 0;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            secondmatrix[i, j] = new Random().Next(10);
            Console.Write($"{secondmatrix[i, j]} ");
            if (index == i || jindex == j)
            elementarray = secondmatrix[index, jindex];
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Number for the pointed index is {elementarray}.");
}
Console.Write("Enter the index of row: ");
int rowindex = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the index of column: ");
int columnindex = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3, 4];
if (rowindex < 3 && columnindex < 4)
FindValueByIndexInTwoDimArr(rowindex, columnindex);
else
Console.Write("There is no such index in the array!");



// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] PrintTwoDimensionalIntRandomArray (int [,] arrayTwoDimensional)
{
    for (int i = 0; i < arrayTwoDimensional.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwoDimensional.GetLength(1); j++)
        {
            arrayTwoDimensional [i, j] = new Random().Next (1, 10); // диапазон от 1 до 9
            Console.Write($"{arrayTwoDimensional[i, j]}\t");
        }
        Console.WriteLine();
    }
    return arrayTwoDimensional;
}

void ArithmeticMeanOfTwoDimensionalArrayColumns (int [,] arrayTwoDimensional)
{
    Console.WriteLine("Arithmetic mean of each columns:");

    for (int j = 0; j < arrayTwoDimensional.GetLength(1); j++)
    {
        double arithmetmean = 0;
        double columnsum = 0;
        for (int i = 0; i < arrayTwoDimensional.GetLength(0); i++)
        {
            columnsum = columnsum + arrayTwoDimensional [i, j];
            arithmetmean = Math.Round(columnsum/arrayTwoDimensional.GetLength(0), 1); 
            // метод округления числа (double, int32). Перелопатила много чего, но отбросить просто до десятых не получилось
            // параметры: AwayFromZero и ToEven - работают только для средней точки, те 5.
            // arithmetmean = columnsum/ArrayTwoDimensional.GetLength(0);
            // Еще один вариант отбрасывания чисел. F1 - означает, что отбросить все до 1 знака после запятой,
            // но тоже округляет по стандартным правилам округления в математике.
        }
        Console.Write($"{arithmetmean}\t");   
        // Console.Write($"{arithmetmean.ToString("F1")}\t"); 
    }    
}

Console.Write("Enter the quantity of rows: "); 
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter the quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] arrayTwoDim = new int [rows, columns];
PrintTwoDimensionalIntRandomArray (arrayTwoDim);
ArithmeticMeanOfTwoDimensionalArrayColumns (arrayTwoDim);