// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] ArrayEntry(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void ArrayOutput(int[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

int number = Convert.ToInt32(DataEntry("Введите число элементов массива: "));
int[] myArray = new int[number];
myArray = ArrayEntry(myArray);
ArrayOutput(myArray);