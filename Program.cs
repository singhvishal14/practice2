using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ID;
            string Employee_Name;
            char Employee_Gender;
            double Employee_Salary;
            DateTime doj;
            Console.WriteLine("Enter Employee ID");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            Employee_Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender");
            Employee_Gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            Employee_Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter DateTime");
            doj = DateTime.Parse(Console.ReadLine());
            if(Employee_Salary>90000)
            {
                Console.WriteLine("You Have to Pay 30% tax");
            }
            else
            {
                Console.WriteLine("you have to pay 15% tax");
            }
            Console.WriteLine("ID: \t" + ID + "\n Employee_name: \t" + Employee_Name + "\n Employee_Gender: \t" + Employee_Gender + "\n Employee_Salary: \t" +
                Employee_Salary + "\n DateTime \t" + doj);

            Console.ReadKey();


        }
    }
}
