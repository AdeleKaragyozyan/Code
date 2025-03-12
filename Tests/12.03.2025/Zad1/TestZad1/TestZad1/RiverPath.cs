using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_test
{
    internal class RiverPath
    {
        public RiverPath()
        {
            Stones = StoneCreator.CreateStones(20);
        }
        public List<Stone> Stones { get; set; }
    }
}