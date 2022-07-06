// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число N: ");
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

int numberN = (GetNumber());

int SumNumber(int numberN)
{

    int count = Convert.ToString(numberN).Length;
    int Next = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        Next = numberN - numberN % 10;
        result = result + (numberN - Next);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);