// Task 1
// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
/*
int number = new Random().Next(10,99);

int FindMaxNum (int num)
{
    int n1 = num % 10;
    int n2 = num / 10;  // - num известно только внутри метода
    if (n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    } 
}
Console.WriteLine("Current number is " + number + ". Max digit is: " + FindMaxNum(number)); 
*/
/*
// Task 2
// Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа.

int number = new Random().Next(100,999);  

int Num(int num) 
{
    int n1 = num % 10;     
    int n2 = num / 100;      
    {
        return n2*10+n1*1; 
    }       
}
Console.WriteLine("Current number is: " + number + ". New number is: " + Num(number));
*/

// Task 3
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно 
// числу первому, то программа выводит остаток от деление.

void Check (int num1, int num2)
{
    if (num1 % num2 == 0)
    {
       Console.WriteLine("The second number is a multiple of the first number!"); 
    }
    else
    {
        Console.WriteLine("The remainder of the division: " + (num1/num2));
    }
}

Console.Write("Enter the first integer: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter the second integer: "); 
int num2 = Convert.ToInt32(Console.ReadLine());

Check (num1, num2);

// Task 4
// Напишите программу, которая принимает на вход число, а также принимает еще 2 числа и 
// проверяет, кратно ли оно одновременно этим двум числам.

/*
Console.Write("Enter an integer to check multiplicity: "); // кратности
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите первое целое число, на которое проверяем: "); 
int num2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе целое число, на которое проверяем: "); 
int num3 = Convert.ToInt32(Console.ReadLine());       

if(num1 % num2 == 0 && num1 % num3 == 0)     
    {         
    Console.Write("Да, кратно");     
    }     
    else      
    {         
        Console.WriteLine("Нет, не кратно");     
    } 
*/

// или с void
/*
void Proverka (int num1, int num2, int num3)
{
    if (num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine("Число " + num1 + " является кратным числам " + num2 + " и " + num3);
    }
    else
    {
        Console.WriteLine("Число " + num1 + " не является кратным числам " + num2 + " и " + num3);
    }
}
Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Enter the second number: ");
int check1 = Convert.ToInt32(Console.ReadLine());     
Console.WriteLine("Enter the third number: ");
int check2 = Convert.ToInt32(Console.ReadLine()); 

Proverka (number1, check1, check2);
*/