
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_test
{
    internal class Chase
    {
        public List<Stone> path;

        public Chase(List<Stone> stones)
        {
            this.path = stones;
        }

        public void FindStone(int target)
        {
            Sort();
            int result = BinarySearch(path, target);
            if (result != -1)
            {
                if (path[result].Color == "green")
                {
                    Console.WriteLine("\nStone found: ");
                    Console.WriteLine(path[result]);
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("No such stone found.");
        }
        private void Sort()
        {
            path.Sort((x, y) => x.Distance.CompareTo(y.Distance));
        }
        private int BinarySearch(List<Stone> list, int target)
        {
            int left = 0;
            int right = list.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid].Distance == target)
                    return mid;
                if (list[mid].Distance < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
