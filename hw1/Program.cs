/*
Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A в 
натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumberA()
{
    int result = 0;
    Console.WriteLine("Введите число A:");
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

int GetNumberB()
{
    int result = 0;
    Console.WriteLine("Введите число B:");
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
double GetA = GetNumberA();
double GetB = GetNumberB();
double GetStep = Math.Pow(GetA, GetB);

Console.WriteLine($"{GetA}^{GetB}={GetStep}");

