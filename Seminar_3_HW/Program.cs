// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
/*
Console.Write("Enter the five-digit number: ");
int N = Convert.ToInt32(Console.ReadLine()); 
int reverse; int result; int compare;
compare = N;
result = 0;
while (N > 0)
{
    reverse = N%10;
    result = (result*10) + reverse;
    N=N/10;
}
if (compare == result)
{
    Console.Write("Your number " + compare + " is a palindrome!");
}
else
{
    Console.Write("Your number " + compare + " is not a palindrome!");
}
*/

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double GetDistance (double x1, double y1, double z1,double x2, double y2, double z2)
{
    double xDistance = (x2 - x1); // may be x > 0 and x < 0
    double yDistance = (y2 - y1);
    double zDistance = (z2 - z1);
    return Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2) + Math.Pow(zDistance,2));
}

double xA, yA, zA, xB, yB, zB;
double distance; 

Console.Write("Input X of point A: ");
xA = Convert.ToDouble(Console.ReadLine());  
Console.Write("Input Y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input X of point B: ");
xB = Convert.ToDouble(Console.ReadLine());  
Console.Write("Input Y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Z of point B: ");
zB = Convert.ToDouble(Console.ReadLine());  
distance = GetDistance(xA, yA, zA, xB, yB, zB);
Console.Write(distance);
*/

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
Console.Write("Type an integer: ");
int N = Convert.ToInt32(Console.ReadLine());
int cube = N-(N-1);
while (cube <= N)
{
    Console.Write(cube*cube*cube + "; ");
    cube++;
}
*/

// Попытка решения задачи 19 другим способом. Работает, но ругается "желтым."

void NewArray (string PalCheck)
{
    char[] newarray = new char [PalCheck.Length]; 
    int i = 0;
    while (i < PalCheck.Length)
    {
        newarray[i] = PalCheck[i];
        i++;
    }
        if (newarray[0] == newarray [4] & newarray[1] == newarray[3])
        {
            Console.Write("Your number is a palindrome!");
        }
        else
        {
            Console.Write("Your number is not a palindrome!");
        }
}
Console.Write("Type the five-digit number: ");
string PalCheck = Console.ReadLine(); 
NewArray (PalCheck);