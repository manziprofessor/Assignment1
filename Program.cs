using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            string p;
            Console.WriteLine("ENTER number 1");
              x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("ENTER number ");
              y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("please choose an operation");
              p = Console.ReadLine();
              var calc = new calculator();
              calc.a = x;
              calc.b = y;


            switch(p)
            {
                case "+":

                    Console.WriteLine("result= {0}", calc.add(x, y));

                    break;
                case "-":

                    Console.WriteLine("result= {0}", calc.subtract(x, y));

                    break;
                case "*":

                    Console.WriteLine("result= {0}", calc.multiply(x, y));

                    break;

                case "/":

                    Console.WriteLine("result= {0}", calc.devide(x, y));

                    break;
                default:
                    Console.WriteLine("invali");
                    break;
            }

              Console.ReadLine();
        }
    }
}
