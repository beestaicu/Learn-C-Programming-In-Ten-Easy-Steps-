using System;

namespace stringinterpolation
{
    class Program
    {

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            string s = "";
            string mystring = "Test";

            // Format strings
            s = String.Format("{0} of String.Format(): 1+2 = {1}. {2}. {3}", mystring, 1+2, "hello world".ToString(), Multiply(10,5));
            Console.WriteLine(s);
            s = String.Format("{5} {4} {3} {2} {1} {0} {5} {4} {3}", 1, 2, 3, 4, 5, 6);
            Console.WriteLine(s);

            // String interpolation
            s = $"(a) {mystring} of string interpolation: 1+2 = {1 + 2}. {"hello world".ToUpper()}. {Multiply(10, 5)}";
            Console.WriteLine(s);

            // Console.WriteLine(): Format strings are automatically evaluated
            Console.WriteLine("(b) {0} (format string): 1+2 = {1}. {2}. {3}", mystring, 1 + 2, "hello world".ToUpper(), Multiply(10, 5));

            // but interpolated strings are not automatically evaluated, we use $ to evaluate interpolated strings
            Console.WriteLine($"(d) {mystring} of string interpolation: 1+2 = {1 + 2}. {"hello world".ToUpper()}. {Multiply(10, 5)}");

            s = "\nThis is a \t{mystring}\n"; // regular string
            Console.WriteLine(s);

            s = $"\nThis is a \t{mystring}\n"; // string interpolation
            Console.WriteLine(s);

            s = @"\nThis is a \t{mystring}\n"; // verbatim string
            Console.WriteLine(s);

        }
    }
}