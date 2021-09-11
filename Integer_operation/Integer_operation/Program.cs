using System;

namespace Integer_operation
{
    class IntegerOperation
    {
        static void Main(string[] args)
        {
            int x, y, sum, sub, mul;
            float div; 
        
            Console.WriteLine("Input x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x = " + x);
            Console.WriteLine("Input y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y = " + y);

            sum = x + y;
            sub = x - y;
            mul = x * y;
            div = (float) x / y;

            Console.WriteLine("Sum\t = " + sum);
            Console.WriteLine("Subtract = " + sub);
            Console.WriteLine("Multiply = " + mul);
            Console.WriteLine("Divide\t = " + div);
            Console.ReadLine();
        }
    }
}
