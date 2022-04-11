// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих.
// Принимает на вход 3 числа.
// Третье число - Общее количество элементов, которые должны быть выведены.


int Fibonacci(int n1, int n2, int N)
{
    if (N == 1) return n1;
    if (N == 2) return n2;
    else return Fibonacci(n1, n2, N - 1) + Fibonacci(n1, n2, N - 2);
}

Console.WriteLine("Введите количество чисел для проверки: ");
int size = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= size; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(0, 1, i)}");
}

// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, 
// состоящие из n букв, которые можно построить из букв этого алфавита.


void PrintWords (string alf, int lengthWord, string currentWord) 
{
    if (lengthWord == 0) Console.WriteLine (currentWord);
    else 
    {
        for (int i = 0; i < alf.Length; i++)
        {
            PrintWords (alf, lengthWord-1, currentWord+alf[i]);
        }
    }
}

PrintWords ("ABC", 3, "");

