// Task 1. Find a square of the number.

/*
Console.Write("Enter an integer: ");
int value = Convert.ToInt32(Console.ReadLine());

int square_of_the_number = value * value;

Console.Write("A square of the number equal to: ");
Console.WriteLine(square_of_the_number);
*/

// Task 2. Create a program that takes as input two numbers and 
// checks if the first number is a square of the second. 
/*
Console.Write("Entry first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Entry second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    bool v = true;
    Console.Write(v);
}
else
{
    bool v = false;
    Console.Write(v);
}
*/

// Task 3. Create a program that will output the title of weekday 
// by the defined number.
/*
Console.Write("Enter the integer from 1 to 7 ");
int week_day = Convert.ToInt32(Console.ReadLine());
if (week_day == 1)
{
    Console.Write("Monday");
}
if (week_day == 2)
{
    Console.Write("Thuesday");
}
if (week_day == 3)
{
    Console.Write("Wednesday");
}
if (week_day == 4)
{
    Console.Write("Thusday");
}
if (week_day == 5)
{
    Console.Write("Friday");
}
if (week_day == 6)
{
    Console.Write("Saturday");
}
else
{
    Console.Write("Today is Sunday. Don't forget to go to work tomorrow!");
}
*/

// SWITCH

Console.Write("Enter the integer: ");
int week_day = Convert.ToInt32(Console.ReadLine());

switch (week_day)
{
    case 1:
        {
        Console.Write("Monday");
        break;
        }
    case 2:
        {
           Console.Write("Thuesday");
           break;
        }
    case 3:
        {
           Console.Write("Wednesday");
           break;
        }
    case 4:
        {
           Console.Write("Thusday");
           break;
        }                        // и так далее
        
    default: 
        {
            Console.Write("Error!");
            break;
        }
}

// Task 4. Create a program that takes one number (N) as input and outputs 
// all intergers within range from -N to N.
/*
Console.Write("Enter an integer: ");
int N = Convert.ToInt32(Console.ReadLine());
int neg_N = N*(-1);

while (neg_N <= N)
{
    Console.WriteLine(neg_N);    // или Write(neg_N + " ") - сложение строк
    neg_N++;
}
*/

