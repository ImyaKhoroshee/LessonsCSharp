// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Enter the three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine()); 

int ThreeDigitNum (int num)
{
    {
    return num % 100 / 10;    
    }
}

Console.WriteLine("Second digit of the pointed number: " + ThreeDigitNum (num));
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

/*
void FindThirdDigit (int number)
{
    while (number>999)
    {
       number = number/10;
    }
        if (number>99)
        {
            Console.WriteLine("Third digit is: " + number%10);
        }
        else
        {
            Console.WriteLine("Your number does not have the third digit!");
        }
}
Console.Write("Enter the integer: "); 
int number = Convert.ToInt32(Console.ReadLine());

FindThirdDigit(number);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Enter the integer: ");
int week_day = Convert.ToInt32(Console.ReadLine());

// Option 1

switch (week_day)
{
    case 1:
        {
        Console.Write("Today is Monday. Working day!");
        break;
        }
    case 2:
        {
           Console.Write("Today is Tuesday. Working day!");
           break;
        }
    case 3:
        {
           Console.Write("Today is Wednesday. Working day!");
           break;
        }
    case 4:
        {
           Console.Write("Today is Thursday. Working day!");
           break;
        }                        
    case 5:
        {
           Console.Write("Today is Friday. Working day!");
           break;
        }
    case 6:
        {
           Console.Write("Today is Saturday. :) Day off!");
           break;
        }           
    case 7:
        {
           Console.Write("Today is Sunday. :) Day off!");
           break;
        }                   
    default: 
        {
            Console.Write("Error!");
            break;
        }
}
*/

// Option 2

void WeekCheck (int number)
{
        if (number <= 5)
        {
            Console.Write("No, working day!");
        }
        else
        {
            Console.Write("Yes, day off!!! :)");
        }
}

Console.Write("Today is day off, right? Enter the integer from 1 to 7, corresponding to a week day: "); 
int number = Convert.ToInt32(Console.ReadLine());

WeekCheck (number);