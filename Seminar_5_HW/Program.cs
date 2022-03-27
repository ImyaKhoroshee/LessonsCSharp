// Задача 1: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void NewArrayFilling (int [] somearray)  // функция для поиска количества четных чисел в массиве
{
    for (int i = 0; i < somearray.Length; i++) // цикл для заполнения массива случайными числами
    {
        somearray[i] = new Random().Next(100, 1000); // 1000 не учитывается
    }
    
    Console.Write("Array output: "); // для красоты :)

    for (int i = 0; i < somearray.Length; i++)
    {
        Console.Write("  " + somearray[i]);    // вывожу заполненный массив. 
    }
}
  
void EvenNumQuantity (int [] createdarray)
{
    int count = 0;  // переменная для сложения чисел
    for (int j = 0; j < createdarray.Length; j++)
    {
        if (createdarray[j]%2 == 0) // проверка на четность
        count = count + 1;   
    } 
    Console.WriteLine(); // Один из вариантов переноса на следующую строку
    Console.WriteLine("The quantity of even numbers: " + count);  // Конкатенация
} 
    
Console.Write("Type the array size: ");  // Прошу ввести длину массива у пользователя
int length = Convert.ToInt32(Console.ReadLine());
int [] userarray = new int [length]; // создаю новый массив с размером, который введет пользователь
NewArrayFilling (userarray); // вызываю метод заполенения массива
EvenNumQuantity (userarray); // вызываю метод сложения четных чисел

// PS: Хотела использовать метод Parse в 33 строке, но консоль ругалась. Переделала в Convert. Ниже ругательство :)
// int length = int.Parse(Console.ReadLine()); // Mетод преобразования переменной типа строка в целое число.
// C:\Users\Павел\Desktop\SeminarC#\Seminar_5_HW\Program.cs(38,24): warning CS8604: Возможно, аргумент-ссылка, 
// допускающий значение NULL, для параметра "s" в "int int.Parse(string s)". [C:\Users\Павел\Desktop\SeminarC#\Seminar_5_HW\Seminar_5_HW.csproj]

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void SumOfElmtWithOddInd (int [] find)
{
    for (int i = 0; i < find.Length; i++)
    find [i] = new Random().Next(1,101);
    
    Console.Write("Array:");

    for (int i = 0; i < find.Length; i++)
    Console.Write("  " + find[i]);    // вывожу созданный массив. 
    
    int count = 0;
    for (int i = 1; i < find.Length; i+=2) // начинаю отсчет с 1 (1ый нечетный), далее делаем шаг +2, чтобы сразу попасть на 2ой нечетный
    count = count + find[i]; // считаю сумму нечетных элементов

    Console.Write($" \nThe sum of elements with odd indices: {count}"); // Интерполяция. Управляющий символ в своей красе :)
}
int [] myarray = new int [10]; // сразу задаю длину массива
SumOfElmtWithOddInd (myarray); // вызываю метод


// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void MaxAndMinDif (double [] array)
{
    double max = array[0]; // переменные для макс и мин чисел
    double min = array[0];
    double result = 0;  // переменная для нахождения разницы
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
        
        if (array[i] < min)
        min = array[i];
    }
    result = result + (max-min);

    Console.Write($"Maximum number: {max}\nMinimum number: {min}");
    Console.Write("\nThe difference between maximum and minimum numbers is " + result);
}
double [] newarray = new double [6] {3.5, 2.8, 3, 4.5, 25.2, 8}; // тут я совсем обленилась и сразу задала размерность и элементы. Ха-ха
MaxAndMinDif (newarray);                                         // Но, на самом деле, это лишь отработка еще одного варианта заполнения массива
