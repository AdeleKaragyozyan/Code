using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domashno_Informatika
{
    internal class PrinterQueue
    {
        private Queue<Document> queue = new Queue<Document>();
        private Stack<Document> history = new Stack<Document>();

        public void AddDocument(string title, int pages)
        {
            queue.Enqueue(new Document(title, pages));
            Console.WriteLine($"Документът \"{title}\" бе добавен в опашката.");
        }

        public void PrintDocument()
        {
            if (queue.Count > 0)
            {
                Document doc = queue.Dequeue();
                history.Push(doc);
                if (history.Count > 3)
                {
                    history = new Stack<Document>(new Stack<Document>(history).Take(3));
                }
                Console.WriteLine($"Отпечатан документ: {doc}");
            }
            else
            {
                Console.WriteLine("Няма документи в опашката за печат.");
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Последни три отпечатани документа:");
            foreach (var doc in history)
            {
                Console.WriteLine(doc);
            }
        }
    }
}
