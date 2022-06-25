using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 3, 4, 5 };
            int i;

            Console.WriteLine("--- for loop ---\r\n");
            for (i = 0; i <5; i++)
            {
                Console.WriteLine(intarray[i]);
            }

            Console.WriteLine("--- while loop (i = 0) ---\r\n");
            i = 0;
            while (i < 5)
            {
                Console.WriteLine(intarray[i]);
                i++;
            }

            Console.WriteLine("--- do..while loop( i= 0) ---\r\n");
            i = 0;
            do
            {
                Console.WriteLine(intarray[i]);
                i++;
            }while (i < 5);

            Console.WriteLine("--- while lop (i =2) ---\r\n"); // not print anything
            i = 2;
            while (i < 2)
            {
                Console.WriteLine(intarray[i]);
                i++;
            }

            Console.WriteLine("--- fo..while loop (i = 2)---\r\n"); // i+1 before while reach
            i = 2;
            do
            {
                Console.WriteLine(intarray[i]);
                i++;
            } while (i < 2);
        }
    }
}