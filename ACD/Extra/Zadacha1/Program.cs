using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashno_Informatika
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterQueue printerQueue = new PrinterQueue();
            string command;

            do
            {
                Console.Write("Въведете команда (add <title> <pages>, print, history, exit): ");
                command = Console.ReadLine();
                string[] parts = command.Split(' ');

                switch (parts[0].ToLower())
                {
                    case "add":
                        if (parts.Length < 3 || !int.TryParse(parts[2], out int pages))
                        {
                            Console.WriteLine("Невалидна команда за добавяне. Използвайте: add <title> <pages>");
                            break;
                        }
                        string title = string.Join(" ", parts, 1, parts.Length - 2);
                        printerQueue.AddDocument(title, pages);
                        break;
                    case "print":
                        printerQueue.PrintDocument();
                        break;
                    case "history":
                        printerQueue.ShowHistory();
                        break;
                    case "exit":
                        Console.WriteLine("Изход от програмата.");
                        break;
                    default:
                        Console.WriteLine("Невалидна команда.");
                        break;
                }
            } while (command.ToLower() != "exit");
        }
    }
}
