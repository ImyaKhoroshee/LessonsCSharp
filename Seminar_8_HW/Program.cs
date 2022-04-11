// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
/*
int [,] ArrayFillAndPrint(int m, int n)
{
    int [,] array = new int [m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] ArraySortDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
           }
        }
    }
    Console.WriteLine();
    return array;
}

void PrintSortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = ArrayFillAndPrint(3, 4);
ArraySortDescending(matrix);
PrintSortedArray (matrix);


// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int [] ElementsSum (int [,] array)
{
    int [] temparray = new int [array.GetLength(0)];
    
    Console.Write("Sums for rows: ");
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumcount = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumcount = sumcount + array[i, j]; 
        }
        temparray[i] = sumcount;
        Console.Write($"{sumcount} ");
    }
    return temparray;
}

int DetermineARowWithMinElement (int [] arr)
{
    int minnumber = int.MaxValue; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (minnumber > arr[i])
        minnumber = arr[i];
    }
    Console.Write($"\nMinimum sum of row: {minnumber}");
    return minnumber;
}

void FindIndexOfElement (int [] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        Console.Write($"\nIndex of row with minimum sum is: {i}");
    }
}

int[,] matrix = ArrayFillAndPrint(6, 4);
FindIndexOfElement(ElementsSum(matrix), DetermineARowWithMinElement(ElementsSum (matrix)));
*/
// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Программу на создание массива в отдельном нет ли существующих элементов
// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)

bool CheckUnique (int a, int i, int j, int k, int [,,] array)
{
    int index = 0;
    for (int ia = 0; ia < array.GetLength(0); ia++) 
    {
        for (int ja = 0; ja < array.GetLength(1); ja++) 
        {
            for (int ka = 0; ka < array.GetLength(2); ka++)
            {
                if (a == array[ia, ja, ka])
                return false;
                if (index == (ia+1)*(ja+1)*(ka+1))
                index++;
            }
        }
    }
    return true;
}

int [,,] CreatePrintThreeDimensionRandomArray (int depthheightwidth)
{
    int [,,] threeDimArray = new int [depthheightwidth, depthheightwidth, depthheightwidth];
    
    for (int i = 0; i < depthheightwidth; i++) 
    {
        for (int j = 0; j < depthheightwidth; j++) 
        {
            for (int k = 0; k < depthheightwidth; k++)
            {
                int a = new Random().Next(10, 100);
                while (!CheckUnique (a, i, j, k, threeDimArray))
                { 
                    a = new Random().Next(10, 100);
                }
               threeDimArray [i, j, k] = a;
            }
        }
    }
    return threeDimArray;
}

int [,,] PrintThreeDimRandArr (int [,,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ")\t"); // пририсовываем индексы после вывода элемента
            }
            Console.WriteLine();
        }
    }
    return arr;
}

int a = 2;
PrintThreeDimRandArr(CreatePrintThreeDimensionRandomArray(a));

// Задача 4: Заполните спирально массив 4 на 4.

// На выходе получается вот такой массив:


// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
/*
int [,] SpiralArray (int a, int b) 
{
    int numbersforarray = 1; // отсчет от 1-цы
 
    int[,] arrayonspiral = new int[a, b];
 
        for (int i = 0; i < a; i++) //Заполняем по периметру строки слева направо.
        {
            arrayonspiral[0, i] = numbersforarray;
            numbersforarray++;
        }
        for (int j = 1; j < b; j++) //Заполняем по периметру столбца сверху вниз.
        {
            arrayonspiral[j, a - 1] = numbersforarray;
            numbersforarray++;
        }
        for (int j = b - 2; j >= 0; j--) //Заполняем по периметру строки справа налево.
        {
            arrayonspiral[a - 1, j] = numbersforarray;
            numbersforarray++;
        }
        for (int i = a - 2; i > 0; i--) 
        {
            arrayonspiral[i, 0] = numbersforarray; //Заполняем по периметру столбца снизу вверх.
            numbersforarray++;
        }
 
        int index = 1;  // Переменные для обращения к нужному индексу 
        int jindex = 1;
 
        while (numbersforarray < a * b) // 
        {
            while (arrayonspiral[index, jindex + 1] == 0) // При инициализации все было заполнено нулями
            {                                               // соответственно, если ноль, то продолжаю присваивать числа
                arrayonspiral[index, jindex] = numbersforarray; // шагаю слева направо
                numbersforarray++;
                jindex++;
            }
 
            while (arrayonspiral[index + 1, jindex] == 0) // шагаю сверху вниз
            {
                arrayonspiral[index, jindex] = numbersforarray;
                numbersforarray++;
                index++;
            }
 
            while (arrayonspiral[index, jindex - 1] == 0) // шагаю справа налево
            {
                arrayonspiral[index, jindex] = numbersforarray;
                numbersforarray++;
                jindex--;
            }
 
            while (arrayonspiral[index - 1, jindex] == 0) // шагаю снизу вверх
            {
                arrayonspiral[index, jindex] = numbersforarray;
                numbersforarray++;
                index--;
            }
        }
 
        for (int i = 0; i < a; i++) 
        {
            for (int j = 0; j < b; j++) 
            {
                if (arrayonspiral[i, j] == 0) 
                {
                    arrayonspiral[i, j] = numbersforarray; // присваиваем последнему незаполненному индексу число
                }
            }
        }
    return arrayonspiral;
}
void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            if (array[i, j] < 10) 
            {
                Console.Write(array[i, j] + "  "); // Для красоты :)
            } 
            else 
            {
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
Console.Write("Type the row size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Type the column size of array: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
PrintArray(SpiralArray(a, b));
else
Console.Write("It is not possible to create such array!");
*/