using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04._2025_Test_Zad2
{
    internal class ParticipantRequest
    {
        public string Name { get; set; }
        public ParticipantRequest() { }
        public ParticipantRequest(string name) { this.Name = name; }
        public void Register()
        {
            Console.WriteLine($"Registration accepted: {Name}");
        }
    }
}
