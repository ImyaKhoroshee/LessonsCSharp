// Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления 
// нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, 
// которые занимают числа из массива info. Напишите программу, которая составит массив 
// десятичных представлений чисел массива data с учётом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); 
// второе число занимает 3 бита (111 -> 7); 
// третье число занимает 3 бита (000 -> 0; 
// четвёртое число занимает 1 бит (1 -> 1)

// Пример:

// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 1
int [] FillandFrintInfoArray (int lenghtforinfo)
{
    int [] usersinfo = new int [lenghtforinfo];
    
    for (int i = 0; i < lenghtforinfo; i++)
    {
        Console.Write("Enter the number for index " + i + " to info array: ");
        usersinfo[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Array info = { ");
    
    for (int j = 0; j < lenghtforinfo; j++)
    {
        Console.Write($"{usersinfo[j]} ");
    }
    Console.WriteLine("}");
    Console.WriteLine();
    
    return usersinfo;
}

int [] FillandFrintDataArray (int lenghtfordata)
{
    int [] usersdata = new int [lenghtfordata];
    
    for (int i = 0; i < lenghtfordata; i++)
    {
        Console.Write("Enter the number for index " + i + " to data array: ");
        usersdata[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Array data = { ");
    
    for (int j = 0; j < lenghtfordata; j++)
    {
        Console.Write($"{usersdata[j]} ");
    }
    Console.WriteLine("}");
    Console.WriteLine();
    
    return usersdata;
}


void BinaryToDecimal (int [] info, int [] data)
{
    int offset = 0;
    for (int i = 0; i < info.Length; i++)
    {
        string binaryString = "";
        for (int j = 0; j < info[i]; j++)
        {
            if (j + offset < data.Length)
            binaryString += data[j + offset].ToString();
            else
            Console.WriteLine("Error: out of range array Data(" + data.Length.ToString() + " / " + (j + offset + 1).ToString() + "). ");
            return;
        }
    }
        try
        {
            int val = Convert.ToInt32(binaryString, 2);
            offset += info[i];
            Console.WriteLine("Value: {0}, binary: {1}", val, binaryString);
        }                
        catch (Exception e)
        {
            Console.WriteLine("Error: Converting bin to int. " + e.Message);
            return;
        }
    }              
}

Console.Write("Enter the size for info array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the the size for data array: ");
int secondlength = Convert.ToInt32(Console.ReadLine());

BinaryToDecimal(FillandFrintInfoArray(length), FillandFrintDataArray(secondlength));
