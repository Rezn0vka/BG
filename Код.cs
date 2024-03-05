using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine().Split();

        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Результирующий массив:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterArray(string[] input)
    {
        int count = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}
