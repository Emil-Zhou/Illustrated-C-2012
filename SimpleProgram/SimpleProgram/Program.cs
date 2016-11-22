using System;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args) // a class
        {
            Console.WriteLine("Hi there! Emil");

            int var1 = 5;
            Console.WriteLine("The value of var1 is {0}", var1);

            Console.Write("This is text1");
            Console.Write("This is text2");
            Console.Write("This is text3");


            Console.WriteLine("This is text1");
            Console.WriteLine("This is text2");
            Console.WriteLine("This is text3");

            Console.WriteLine("Two sample integers are {0} and {1}.", 3, 6);

            Console.WriteLine("Three integers are {1},{0} and {1}.", 3, 6);

            Console.WriteLine("The value: {0}.", 500);
            Console.WriteLine("The value: {0:C}.", 500);

            Console.WriteLine("{0,10}", 500);


            int myInt = 500;

            Console.WriteLine("|{0,10}|",myInt);
            Console.WriteLine("|{0,-10}|",myInt);


            double myDouble = 12.345678;

            Console.WriteLine("{0,-10:G} -- General",myDouble);
            Console.WriteLine("{0,-10} -- Default, same as General",myDouble);
            Console.WriteLine("{0,-10:F4} -- Fixed Point, 4 dec places",myDouble);
            Console.WriteLine("{0,-10:c} -- Currency",myDouble);
            Console.WriteLine("{0,-10:E3} -- Sci. Notation, 3 dec places",myDouble);
            Console.WriteLine("{0,-10:X} -- Hexadecimal integer",1194719);

            Console.WriteLine("{0:C}", 12.5);
            Console.WriteLine("{0:D4}", 12);
            Console.WriteLine("{0:F4}", 12.345678);
            Console.WriteLine("{0:G4}", 12.345678);
            Console.WriteLine("{0:x}", 180026);
            Console.WriteLine("{0:N2}", 12345678.54321);
            Console.WriteLine("{0:P22}", 0.1221897);
            Console.WriteLine("{0:R}",1234.21897);
            Console.WriteLine("{0:e4}",12.3456789);

            Console.ReadKey(true);
        }
    }
}
