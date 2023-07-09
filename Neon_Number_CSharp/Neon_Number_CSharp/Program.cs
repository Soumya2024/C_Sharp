// See https://aka.ms/new-console-template for more information
//Console.WriteLine("  !!     C #      !!");

using System;

public class Neon_Number_CSharp
{
    public static void Main()
    {
        int n, sum = 0, rem, store;

        Console.WriteLine(" C Sharp Neon Number ");

        Console.Write(" Enter a number :-");
        n = int.Parse(Console.ReadLine());

        store = n * n;

        while(store>0)
        {
            rem = store % 10;
            sum = sum + rem;
            store = store / 10;
        }

        Console.WriteLine(" Sum is " + sum);

        if (sum == store)
            Console.Write(" Neon Number ");
        else
            Console.Write(" Not Neon Number ");
    }
}