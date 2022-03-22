// Задача 1: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int PowerOfNumbers (int firstnumber, int secondnumber)  // Создаю метод для возведения в натуралью (т.е. secondnumber>=1) степень. Метод принимает 2 числа (аргумента) и возвращает результат вычислений
{
    if (secondnumber == 1) // a^n = a
    return firstnumber; // Возвращаю первый аргумент. Если действие в теле одно, то можно не брать в фигурные скобки
    
    int result = firstnumber; // Создаю переменную, куда буду писать результат вычислений.
    for (int i = 2; i<=secondnumber; i++) // Создаю цикс, присваиваю 2 индексу (0 по условию не м.б., для 1 - см. выше)
    {
        result = result*firstnumber; // произвожу вычисление
    }
    return result; // вывожу результат
}

Console.Write("Type the first number: "); // Запрашиваю с консоли первое число
int a = Convert.ToInt32(Console.ReadLine());  // Считываю, присваиваю

Console.Write("Type the second number (>0): "); // Запрашиваю с консоли второе число, делаю акцент на число 
int b = Convert.ToInt32(Console.ReadLine()); // Считываю, присваиваю

if (b<1) // Делаю проверку, вдруг пользователь плохо читает :)
Console.Write("Second number must be > 0"); // сообщаю пользователю "ай яй яй"

else
Console.Write("Power of numbers " + a + " and " + b + ": "+ PowerOfNumbers(a,b)); // вывожу результат, вызывая метод (функцию)


// Для себя
// int x = 5;
// int stepen = 4;
// Console.WriteLine("5^4 = " + Math.Pow(x, stepen));

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int TheSum (int number) // Создаю функцию (метод) для сложения чисел во входящем числе
{
    int result = 0;
    while (number>0) // Цикл для счета цифр в числе
    {
        int digit = number%10; // вычленяю цифру и записываю на переменную
        result = result + digit; // складываю числа
        number = number/10; // отсекаю лишнее число
    }
    return result;      // возвращаю результат
}

Console.Write("Type an integer: "); 
int usernumber = Convert.ToInt32(Console.ReadLine()); 

if (usernumber<10) // Делаю проверку количества цифр в числе пользователя
Console.Write("There is only 1 digit in your number");

else
Console.Write("The sum of the entered number: " + TheSum(usernumber));


// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Fillarray(int [] digits)   // Метод принимает, но не возвращает
{
    int length = digits.Length;     // Присваиваю переменной length длину массива, т.е. 8
    for (int i = 0; i < length; i++) // Создаю цикл для того, чтобы пользователь последовательно вводил свои цисла в массив
    {
        Console.Write("Type an element for index " + i + ": "); // Прошу пользователя вводить цисла
        digits[i] = Convert.ToInt32(Console.ReadLine());    // Присваиваю число для каждого индекса
    }
    
    Console.Write("Array output: "); // Вывожу на экран текст. Или тут (т.е. то, что ниже) можно было внести в отдельную функцию
    
    for (int i = 0; i < length; i++)
    {
        Console.Write("  " + digits[i]);    // вывожу созданный массив. 
    }
}

int [] userarray = new int [8]; // создаем новый массив на 8 элементов
Fillarray(userarray); // вызываем метод