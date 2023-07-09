// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
public class Palindrome_NUmber_CPP
{
    public static void Main(string[] args)
    {
        Console.WriteLine("!!!! PALINDROME NUMBER !!!! ");

        int n, sum = 0, temp, save;

        Console.Write(" Enter the number :-");
        n = int.Parse(Console.ReadLine());

        save = n;

        while (n > 0)
        {
            temp = n % 10;
            sum = sum * 10 + temp;
            n = n / 10;
        }

        Console.Write(" Sum is :"+sum);

        if (sum == save)
            Console.Write(" \n Palindrome Number ");
        else
            Console.Write(" \n No Palindrome Number ");
    }
}

//using System;
//public class PalindromeExample
//{
//    public static void Main(string[] args)
//    {
//        int n, r, sum = 0, temp;
//        Console.Write("Enter the Number: ");
//        n = int.Parse(Console.ReadLine());
//        temp = n;
//        while (n > 0)
//        {
//            r = n % 10;
//            sum = (sum * 10) + r;
//            n = n / 10;
//        }
//        if (temp == sum)
//            Console.Write("Number is Palindrome.");
//        else
//            Console.Write("Number is not Palindrome");
//    }
//}