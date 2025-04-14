using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp12
{
    internal class RequestManager
    {
        private readonly HashSet<string> filesHashSet = new HashSet<string>(); 
        private readonly Queue<FileRequest> filesQueue = new Queue<FileRequest>(); 

        public void ProcessRequests(int numberOfRequests)
        {
            for (int i = 0; i < numberOfRequests; i++)
            {
                Console.WriteLine("Enter request name:");
                string requestName = Console.ReadLine();

                if (!filesHashSet.Contains(requestName))
                {
                    filesHashSet.Add(requestName); 
                    filesQueue.Enqueue(new FileRequest { Name = requestName });
                }
            }

            Console.WriteLine("\nProcessing requests...");
            while (filesQueue.Count > 0)
            {
                filesQueue.Dequeue().MakeRequest();
            }
        }
    }
}
