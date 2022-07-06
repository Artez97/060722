/*
 Напишите программу, которая задаёт массив 
 из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

/*void PrintArrayForEach(int[] array)
{
    foreach (int item in array)
    {
        //int item = array[i], в цикле по i 

        Console.Write($"{item} ");
    }
}*/
/*//Метод вывода рандомного массива из 8 элементов
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


var array = new int[8];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 10);
}

Console.WriteLine("Рандомный массив из 8 элементов: ");
PrintArray(array);
Console.WriteLine();


/*Console.WriteLine("Вывод через цикл foreach: ");
PrintArrayForEach(array);*/

//Console.WriteLine($"{array[2]}");

//Console.WriteLine(iarray);

//Метод вывода рандомного массива из N элементов
int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите кол-во элементов массива:");
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }

    return result;
}

void PrArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int N = GetNumber();
var array = new int[N];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 10);
}

Console.WriteLine($"Рандомный массив из {N} элементов: ");
PrArray(array);
Console.WriteLine();
