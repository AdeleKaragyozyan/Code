using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_test
{
    internal class Stone
    {
        public int Distance { get; set; }
        public string Color { get; set; }

        public Stone(int distance, string color)
        {
            Distance = distance;
            Color = color;
        }
        public override string ToString()
        {
            return $"{Color} stone, {Distance}cm away";
        }
    }
}