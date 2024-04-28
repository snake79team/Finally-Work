using System;

class Program
{
    static string[] FilterStrings(string[] arr)
    {
                int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                count++;
            }
        }

        string[] newArr = new string[count];
        count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                newArr[count] = arr[i];
                count++;
            }
        }

        return newArr;
    }
    static void Main()
    {
        Console.WriteLine("Введите строки через пробел:");
        string[] input = Console.ReadLine().Split(' ');

        string[] filteredArr = FilterStrings(input);

        Console.WriteLine(string.Join(", ", filteredArr));
    }
}