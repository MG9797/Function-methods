using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please Enter a sentence:");
            string sentence = Console.ReadLine();
            int count = SpaceCount(sentence);
            Console.WriteLine("The amount of spaces in your sentence was:");
        }

        static int SpaceCount(string sentence)
        {
            int count =0;
            foreach (char i in sentence)
            {
                if (i == ' ')
                count++;

            }
             return count;
        }
    }
}
