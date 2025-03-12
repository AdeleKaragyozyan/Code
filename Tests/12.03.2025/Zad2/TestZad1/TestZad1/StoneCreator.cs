using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace zad1_test
{
    internal class StoneCreator
    {
        private static readonly ImmutableList<string> Colors = ImmutableList.Create(
        "Green", "Red", "Blue", "Yellow", "Orange",
        "Purple", "Pink", "Brown", "Black", "White"
        );

        private static readonly Random random = new Random(Environment.TickCount);
        public static List<Stone> CreateStones(int count)
        {
            List<Stone> stones = new();
            for (int i = 0; i < count; i++)
            {
                string color = Colors[random.Next(Colors.Count)];
                int distance = random.Next(0, 101);
                stones.Add(new Stone(distance, color));
            }
            return stones;
        }
    }
}