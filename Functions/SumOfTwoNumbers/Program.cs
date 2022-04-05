using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            int sum;

            Console.WriteLine("Enter first number:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            n2 = Convert.ToInt32(Console.ReadLine());


            sum = addition(n1,n2);

            Console.WriteLine("Sum is: " + sum);

        }
        
        static int addition(int n1 , int n2){
            return (n1+n2);
        }
    }
}
