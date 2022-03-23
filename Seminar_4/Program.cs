// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел 
// от 1 до А.

int SumNumber (int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.Write("Type an integer: ");
int usernumber = Convert.ToInt32(Console.ReadLine()); 
Console.Write("The sum of digits for the entered number: " + SumNumber (usernumber));


// Напишите программу, которая принимает на вход число и выдаёт количество цифр 
// в числе.

int QuantityOfDigits (int number)
{
    int digquantity = 1;
    while (Math.Abs(number/10)>1)   // Функция Math.abs() возвращает абсолютное значение числа. 
    {                               // То есть он возвращает x , если x положителен или равен нулю, и отрицает x , если x отрицателен.
        number = number/10; 
        digquantity++;
    }
    return digquantity;                            
}

Console.Write("Type an integer: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"The quantity of digits: {QuantityOfDigits(num)}"); // Интерполяция строк

// Напишите программу, которая принимает на вход число N и выдаёт произведение 
// чисел от 1 до N.


int Factorial (int N) // создаем метод для вычисления произведения. Метод принимает и возвращает
{
    int result = 1;
    for (int i = 1; i <= N; i++) // Начинаем с 1цы согласно условию
    result = result * i;
    return result; // возвращаем значение
}
Console.Write("Type an integer: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1) // делаем проверку, чтобы число было подходящее.
Console.Write("Your number must be > or = 1!");
else
Console.Write($"The product of numbers from 1 to {num} is {Factorial (num)}"); // Интерполяция строк. Вызываем метод


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке.

void FillArray (int [] random) // метод для заполнения массива. Тут случайными числами, но можно и иначе присвоить
{
    int length = random.Length; // создаем переменную для хранения количества элементов
    
    for (int index = 0; index < length; index++) // индекс 0, тк индексы в массиве идут с нуля
    random [index] = new Random().Next(0, 2); // присваиваем элементам массива поочереди 
}                                              // случайные числа от 0 до 1 (верхняя граница (те 2) не учитывается)

void OutputArray (int [] outputrandom)
{
    int count = outputrandom.Length; // создаем переменную для хранения количества элементов
    int index = 0;
    
    Console.Write("Output of array: ");
    
    while (index < count)
    {
        Console.Write(outputrandom[index] ); // выводим на экран, что получилось
        index++;
    }
}

int[] EightElementsArray = new int[8]; // создаем массив на 8 элементов

FillArray (EightElementsArray); // вызываем метод. 
OutputArray (EightElementsArray); //Такие скобки [] тут не пишем!!!
