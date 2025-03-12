using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_test
{
    internal class Program
    {
        public static void PrintPath(List<Stone> path)
        {
            foreach (var stone in path)
                Console.WriteLine(stone.ToString());
        }

        static void Main(string[] args)
        {
            RiverPath riverPath = new RiverPath();
            Console.WriteLine("Unsorted Stones:");
            Console.WriteLine();
            
            PrintPath(riverPath.Stones);
            Chase chase = new Chase(riverPath.Stones);
            Console.WriteLine();
            
            int targetDistance = 50;
            chase.FindStone(targetDistance);
            Console.WriteLine();
            
            Console.WriteLine("Sorted Stones:");
            PrintPath(chase.path);

            Console.ReadKey();
        }
    }
}