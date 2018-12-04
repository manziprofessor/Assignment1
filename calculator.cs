using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class calculator
    {
        public double a;
        public double b;

        public double add(double a, double b)
        {
            return (a + b);
        }

        public double subtract(double a, double b)
        {
            return (a - b);
        }
        public double multiply(double a, double b)
        {
            return (a * b);
        }
        public double devide(double a, double b)
        {
            if (b == 0)
                Console.WriteLine("invalid operation");

            return (a / b);

        }

    }  
            
    
}
