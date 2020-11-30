using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test__Interface__1
{
    abstract class Calculator
    {
        public String cal { get; set; }
        public String power { get; set; }

        public Calculator() { }
        public Calculator(String cal, String power)
        {
            this.cal = cal;
            this.power = power;
        }
        public void ShowInfo()
        {
            Console.WriteLine("The calculator name is: " + cal);
            Console.WriteLine("The Power of the calculator is: " + power);
        }
    }
}
