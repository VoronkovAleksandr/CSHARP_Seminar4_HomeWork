// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int number, int exp)
{
    int result = 1;
    for (int i = 0; i < exp; i++)
    {
        result = result * number;
    }
    return result;
}

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int numberA = int.Parse(DataEntry("Введите число А: "));
int numberB = int.Parse(DataEntry("Введите число B: "));

int exp = Exponentiation(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} равно {exp}");
