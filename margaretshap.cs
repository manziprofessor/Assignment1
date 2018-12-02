using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace margret
{
    class Program
    {
        class employee
        {
            public string name;
            private int id;

            public employee(string n, int i)
            {
                n = name;
                i = id;
            }
            public void print()
            {
                Console.WriteLine("__________________");
                Console.WriteLine("1.monthly_________");
                Console.WriteLine("2.temporaly________");
                Console.WriteLine("3.evening__________");
                Console.WriteLine("___________________");
            }

            public void print(int choice)
            {
                int choose;
                Console.WriteLine("choose type");
                choose = Convert.ToInt32(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                        double GS;
                        double netsalary;
                        Console.WriteLine("enter gross salary");
                        GS = Convert.ToInt32(Console.ReadLine());
                        netsalary = 0.79 * GS;
                        Console.WriteLine("netsalary: {0} rwf", netsalary);
                        break;

                    case 2:
                        double GW;
                        double netwage;
                        int hour;
                        Console.WriteLine("enter hours worked");
                        hour = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter gross wage");
                        GW = Convert.ToInt32(Console.ReadLine());
                        netwage = 0.79 * GW*hour;
                        Console.WriteLine("netwage: {0} rwf", netwage);
                        break;

                    case 3:
                        double GB;
                        double netbalance;
                        int hours;
                        Console.WriteLine("enter hours worked");
                        hours = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter gross balance");
                        GB = Convert.ToInt32(Console.ReadLine());
                        netbalance = 0.8215 * GB * hours;
                        Console.WriteLine("netbalance: {0} rwf", netbalance);
                        break;

                    default:
                        Console.WriteLine("wrong choice");
                        break;




                }

            }

        }
        static void Main(string[] args)
        {

            string empname;
            int empid;
            Console.WriteLine("please enter your full names");
            empname = Console.ReadLine();

            Console.WriteLine("please enter your ID");
            empid = Convert.ToInt32( Console.ReadLine());

            // calling methos

            employee mag = new employee(empname, empid);
            mag.print();
            mag.print(3);


            Console.ReadLine();


        }
    }
}
