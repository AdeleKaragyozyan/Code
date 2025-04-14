using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of requests:");
            int numberOfRequests = int.Parse(Console.ReadLine());

            RequestManager manager = new RequestManager();
            manager.ProcessRequests(numberOfRequests);
            Console.ReadKey();
        }
    }
}
