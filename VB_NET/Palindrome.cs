using System;

public class Palindrome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World. !   Programming!  ");
        int n,r, sum=0, temp;

        Console.Write(" Enter the number :");
        n = int.Parse(Console.ReadLine());
        temp = n;
        while (n>0)
        {
            r = n%10;
            sum = sum*10+r;
            n = n/10;
        }
        if (temp==sum)
            Console.Write(" Palindrome Number");
        else
            Console.Write(" Not Palindrome Number");
    }
    
}