// Task 1

/*Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("MaxNumber: ");
    Console.WriteLine(a);
    Console.Write("MinNumber: ");
    Console.WriteLine(b);
}
else
{
    Console.Write("MaxNumber: ");
    Console.WriteLine(b);
    Console.Write("MinNumber: ");
    Console.WriteLine(a);
}
*/
// Task 2
/*
Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int MaximumNumber;
if (a > b)
{
    MaximumNumber = a;
}
else
{
    MaximumNumber = b;
    }
if (MaximumNumber > c)
{
    MaximumNumber = MaximumNumber;
    Console.Write("MaxNumber is: ");
    Console.Write(MaximumNumber);
}
else
{
    MaximumNumber = c;
    Console.Write("MaxNumber is: ");
    Console.Write(c);
    }
*/

// Task 3

/*
Console.Write("Enter the integer: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
{
    Console.Write("Your number is even!");
}
else 
{
    Console.Write("Your number is odd!");
}
*/

// Task 4

Console.Write("Enter the natural number: ");
int N = Convert.ToInt32(Console.ReadLine());
int Start = N-(N-1);

while (Start <= N)
{
        if (Start % 2 == 0)
    Console.WriteLine(Start);
    Start++;
}