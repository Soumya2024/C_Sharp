// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

public class Certicate_CSharp
{
    public static void Main()
    {
        int n, sum = 0, temp, save;

        Console.Write(" Enter the number : ");
        n = int.Parse(Console.ReadLine());

        if (n <= 99)
            Console.Write(" Excellent ");
        else if (n > 80 && n <= 95)
            Console.Write(" Very Good ");
        else if (n > 70 && n <= 80)
            Console.Write(" Good ");
        else if (n > 60 && n <= 70)
            Console.Write(" Bad ");
        else
            Console.Write(" Fail ");

    }
}