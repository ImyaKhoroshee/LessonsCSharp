// Задача 1. Сделать вывод треугольника Паскаля в виде равнобедренного треугольника.

double Factorial (int n)
{
    double x = 1; 
    
    for (int i = 1; i <= n; i++)
    x = x * i;
    
    return x;
}

void BeautifulPascalTriangle ()
{
    Console.Write("Type the amount of rows to input the Pascal's Triangle: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int j;
    for (int i = 0; i < number; i++)
    {
        for (j = 0; j <= (number - i); j++) // отступы слева, чем ниже строка, тем меньше отсутп
        Console.Write(" "); 
        
        for (j = 0; j <= i; j++)
        {
            Console.Write(" "); // расстрояние между элементами треугольника
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j))); //вызываем функцию по вычислению элементов
        }
        Console.WriteLine();
        Console.WriteLine(); // две пустые строчки после каждой строки
    }
    Console.WriteLine();
}

BeautifulPascalTriangle();
