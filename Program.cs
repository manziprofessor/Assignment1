using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realpayment
{
    class Program
    {
        class employee                              // class employee is created
        {
            private string empname;
            public int empid;
            public employee(string name, int id)    // two parameter constructor is created
            {
                name = empname;
                id = empid;

                
            }
            public void show()                       //  show method
            {

                Console.WriteLine("-------------------- ");
                Console.WriteLine("1.monthly_employee ");
                Console.WriteLine("2.temporary_employee ");
                Console.WriteLine("3.evening_employee");
                Console.WriteLine("--------------------- ");

            }
            public void show(int choose)             // overloading show method
            {
                Console.WriteLine("CHOOSE EMPLOYEE TYPE PLEASE ");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        double salary;
                        Console.WriteLine("ENTER YOUR SALARY PLEASE");
                        salary = Convert.ToInt32(Console.ReadLine());
                        double netsalary;
                        netsalary = salary - 0.18 * salary - 0.03 * salary;
                        Console.WriteLine("NETSALARY: {0}", netsalary);
                        break;

                    case 2:
                        double balance;
                        Console.WriteLine("ENTER YOUR HOURLY BALANCE ");
                        balance = Convert.ToInt32(Console.ReadLine());
                        double netbalance;
                        netbalance = balance - 0.18 * balance;
                        Console.WriteLine("NETBALANCE: {0}", netbalance);
                        break;

                    case 3:
                        double ebalance;
                        Console.WriteLine("ENTER YOUR HOURLY BALANCE");
                        ebalance = Convert.ToInt32(Console.ReadLine());
                        double netebalance;
                        netebalance = ebalance - 0.18 * ebalance + 0.0015 * ebalance;
                        Console.WriteLine("NETEBALANCE: {0}", netebalance);
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }

            }


        }
        static void Main(string[] args)
        {

            string employeename;
            int employeeid;
            Console.WriteLine("ENTER EMPLOYEE NAME PLEASE");
            employeename = Console.ReadLine();
            Console.WriteLine("ENTER EMPLOYEE ID PLEASE");
            employeeid = Convert.ToInt32(Console.ReadLine());     

            employee employee1 = new employee(employeename, employeeid);        //calling a two parameter constructor
            employee1.show();                                                   // calling show method
            employee1.show(1);                                                  // calling overloaded method
           


            Console.ReadLine();
        }
    }
}
