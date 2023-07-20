using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment1
{
    internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Employee ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Employee Gender:");
                string gender = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary:");
                decimal salary = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Date of Joining (DOJ) (dd/MM/yyyy):");
                DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.WriteLine();
                Console.WriteLine("ID\tEmployee Name\tEmployee Gender\tEmployee Salary\tDOJ");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine($"{id}\t{name}\t\t{gender}\t\t{salary}\t\t{doj.ToString("dd/MM/yyyy")}");
                Console.WriteLine();

                decimal taxPercentage = (salary > 90000) ? 0.3m : 0.15m;
                decimal taxAmount = salary * taxPercentage;

                Console.WriteLine("You have to pay:");
                Console.WriteLine($"Tax: {taxAmount}");

                Console.ReadLine();
            }
        }
    }

    

