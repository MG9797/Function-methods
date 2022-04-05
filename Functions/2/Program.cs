using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please enter your name:");
            string pName = Console.ReadLine();
            Welcome(pName);
        }
           static void Welcome(string name)
        {

          Console.WriteLine("Have a nice day!" + name);

        
        }
        
    
    }
    
}
