using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04._2025_Test_Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of registrations:");
            int numberOfRegistrations = int.Parse(Console.ReadLine());

            EventManager manager = new EventManager();
            manager.ProcessRegistrations(numberOfRegistrations);
            Console.ReadKey();
        }
    }
}
