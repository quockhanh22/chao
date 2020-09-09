using System;
using System.Text;

namespace welcome
{
    class Program
    {
    

        static void Main(string[] args)
        {
          chao();
        }
        static void chao()
        {
            Console.WriteLine("What is your name ?");
            String name = Console.ReadLine();
            Console.WriteLine("Hello {0} ! ", name);
        }
    }
}