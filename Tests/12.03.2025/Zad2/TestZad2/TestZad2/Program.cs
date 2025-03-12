using zad2_test;

namespace TestZad2
{
    internal class Program
    {
        static void PrintList2(SinglyLinkedList<int> list)
        {
            Node<int> current = list.Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            for (int i = 2; i <= 30; i+= 2)
                if (i%2 == 0)
                    list.AddLast(i);
            list.PrintList();
            Console.ReadKey();
        }
    }
}
