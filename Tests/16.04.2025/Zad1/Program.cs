using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04._2025_Test_Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Stack<string>> requests = new Dictionary<string, Stack<string>>();
            string input = "", user = "", documentName = "";
            string[] commands = input.Split(' ');

            while (true)
            {
                
                input = Console.ReadLine();
                commands = input.Split(' ');
                if (input == "END")
                    break;

                switch (commands[0])
                {
                    default:
                        Console.WriteLine("Please enter a command from the following: OPEN, CLOSE, LIST and END.");
                        break;
                    case "OPEN":
                        user = commands[1];
                        documentName = commands[2];

                        if (!requests.ContainsKey(user))    
                            requests[user] = new Stack<string>();

                        requests[user].Push(documentName);

                        Console.WriteLine($"{user} opened {documentName}");

                        break;
                    case "LIST":
                        user = commands[1];

                        Console.WriteLine($"Opened documents by {user}:");

                        if (requests.ContainsKey(user) && requests[user].Count>0)
                            foreach (var item in requests[user])
                                Console.WriteLine($">{item}");

                        break;
                    case "CLOSE":
                        user = commands[1];

                        if (requests.ContainsKey(user))
                            Console.WriteLine($"{user} closed {requests[user].Pop()}");

                        break;
                    case "END":
                        Console.WriteLine($"Ending program...");

                        break;
                }
            }
        }
    }
}
