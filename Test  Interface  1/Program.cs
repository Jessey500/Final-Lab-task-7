using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__Interface__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator Interface");
            Console.WriteLine();
            BasicCalculator c = new BasicCalculator("Abacus", "100");
            Console.WriteLine("Summation is :");
            Console.WriteLine();
            c.sum(8, 7);
            c.ShowResult();
            Console.WriteLine("Subtraction is :");
            Console.WriteLine();
            c.sub(8, 7);
            c.ShowResult();
            Console.WriteLine("Multiplication is :");
            Console.WriteLine();
            c.multiplication(8, 7);
            c.ShowResult();
            Console.WriteLine("Division is :");
            Console.WriteLine();
            c.division(8, 7);
            c.ShowResult(); 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Scientific Calculator Interface ");
            Console.WriteLine();
            ScientificCalculator s = new ScientificCalculator("Casio", " fx-991EX");
            Console.WriteLine();
            s.ShowInfo();
            s.factorial(5);
            s.XtoY(2, 6);
            s.sum(7, 10);
            s.sub(9, 5);
            s.multiplication(14, 10);
            s.division(8, 12);

          

        }
    }
}
