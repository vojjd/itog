using System;

class Program
{
    static void Main(string[] args)
    {
        string[] originalArray = { "Hello", "2", "world", ":-)" };
        string[] newArray = FilterStrings(originalArray);
        PrintArray(newArray);
    }

    static string[] FilterStrings(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                filteredArray[index] = array[i];
                index++;
            }
        }

        return filteredArray;
    }

    static void PrintArray(string[] array)
    {
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
    }
}