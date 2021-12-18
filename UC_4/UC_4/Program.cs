using System;

namespace ReverseNumber
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (num != 0)
            {
                int rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse of a number is:" + reverse);
        }
    }
}