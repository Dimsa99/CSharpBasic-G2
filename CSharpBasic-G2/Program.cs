using System;

namespace CSharpBasic_G2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.WriteLine("Zdr grupa 2");

            //Console.WriteLine(1);

            //Console.WriteLine(1.11);
            //Console.WriteLine(-1);
            //Console.WriteLine("Zdravo grupa 2 \nova e primer vo nova linija");
            // triangle
            Console.WriteLine("    *");
            Console.WriteLine("   * *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("   * \n  * * \n  *** \n ******  \n********");




            // stick man
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine(" *  *  *");
            Console.WriteLine("    *");
            Console.WriteLine("    *");
            Console.WriteLine("  *   *");
            Console.WriteLine(" *     *");

            Console.WriteLine("Please write some text");
            var input = Console.ReadLine();
            Console.WriteLine(input);
        }
    }
}
