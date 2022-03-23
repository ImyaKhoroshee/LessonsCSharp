// Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
// Вывести на экран первые два максимальных и первые два минимальных числа 
// из ряда введенных чисел. А теперь самое интересное: создавать массивы в 
// процессе решения запрещено

int number;
int min2 = int.MaxValue;
int min1 = int.MaxValue;
int max1 = 0;
int max2 = 0;
int count = 0;
do
{
    Console.Write("Type an integer: ");
    number = Convert.ToInt32(Console.ReadLine());
    
    if (number!= 0) 
    {
        count++;
        if (max2!=max1 && number>max2 && number<max1) 
            max2 = number;
        if (number > max1) 
        {
            max2 = max1;
            max1 = number;
        }
        
        if (min2!=min1 && number<min2 && number>min1) 
            min2 = number;
        if (number<min1) 
        {
            min2 = min1;
            min1 = number;       
        }
    }
}
while (number!=0);
if (count<=2)
{
    Console.WriteLine("Min1: {1} Max1: {2}", min1, max1);
}
else
{
    Console.WriteLine("Min1: " + min1 + " Min2: " + min2 + " Max1: " + max1 + " Max2: " + max2);
}