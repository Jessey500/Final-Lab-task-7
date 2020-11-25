using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__Interface__1
{
    class BasicCalculator : BasicCalculatorInterface 
    {
       
        int r;
        public int sum(int n1, int n2)
        {
            r = n1 + n2;
            return r;
        }
        public int sub(int n1, int n2)
        {
            r = n1 - n2;
            return r;
        }
        public int multiplication(int n1, int n2)
        {
            r = n1 * n2;
            return r;
        }
        public int division(int n1, int n2)
        {
            r = n1 / n2;
            return r;
        }
        public void ShowResult()
        {
            Console.WriteLine("result  : " + r);
        }
    }
}
