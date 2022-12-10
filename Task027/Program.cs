// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int SumOfDigital(int number)
{
    int res = 0;
    while (number > 0)
    {
        res = res + number % 10;
        number /= 10;
    }
    return res;
}

int number = Convert.ToInt32(DataEntry("Введите число: "));
int sum = SumOfDigital(number);
Console.WriteLine($"Сумма цифр введенного числа равна {sum}");
