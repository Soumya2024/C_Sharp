// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using System;

public class binary_Sort
{
    public static void Main()
    {
        int[] arr = new int[5];
        int temp, save, i, j, store;

        Console.Write(" Enter the number : ");
        store = int.Parse(Console.ReadLine());

        for(i=0; i<=store; i++)
        {
            for(j=i+1; j<=store; j++)
            {
                if(i>j)
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
                Console.Write(" \n ");
            }
        }
        Console.WriteLine(" This Upper code has indicated to Bubble Sort ");

    }
}