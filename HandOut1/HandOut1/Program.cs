using System;

namespace HandOut1
{
    class Name
    {
        static void Main(string[] args)
        {
            String  name;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
}
