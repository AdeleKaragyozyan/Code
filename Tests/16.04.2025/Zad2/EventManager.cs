using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04._2025_Test_Zad2
{
    internal class EventManager
    {
        private readonly HashSet<string> namesHashSet = new HashSet<string>();
        private readonly Queue<ParticipantRequest> namesQueue = new Queue<ParticipantRequest>();

        public void ProcessRegistrations(int numberOfRegistrations)
        {
            for (int i = 0; i < numberOfRegistrations; i++)
            {
                Console.WriteLine("Enter participant name:");
                string requestName = Console.ReadLine();

                if (!namesHashSet.Contains(requestName))
                {
                    namesHashSet.Add(requestName);
                    namesQueue.Enqueue(new ParticipantRequest { Name = requestName });
                }
            }

            Console.WriteLine("\nProcessing registrations...");
            while (namesQueue.Count > 0)
            {
                namesQueue.Dequeue().Register();
            }
        }
    }
}
