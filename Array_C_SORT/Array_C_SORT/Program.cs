// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

public class Array_C_SORT
{
    public static void Main()
    {
        int i, temp, save;
        int[] arr = new int[10];

        Console.Write(" Enter 10 array : -> ");
        for(i=0; i<10; i++)
        {
            Console.Write(" Element No " + " : "+i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < 10; i++)
        {
            Console.Write("  Adding Shoting Rows ");

            //arr[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.Write(" Print 10 Array : ");
        for(i=0; i<10; i++)
        {
            Console.Write(" 0 "+arr[i]);
        }

        Console.Write(" \n ");
     
    }
}
