using System;
namespace Armstrong_NUMBER
{
	public class Palindrome_number
	{
		public Palindrome_number()
		{
			Console.WriteLine(" Palindrome Number");
			int n, sum = 0, temp, store, i;

			Console.WriteLine(" Enter a Number :");
			n = int.Parse(Console.ReadLine());

			while(n>0)
			{
				temp = n % 10;
				sum = sum * 10 + temp;
				n = n / 10;
			}

			if (sum == n)
				Console.WriteLine(" PalinDrome Number");
			else
				Console.WriteLine(" Not Palindrome Number ");

		}
	}
}

