using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_test
{
    internal class SinglyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }

        public SinglyLinkedList()
        {
            Head = null;
            Tail = null;
        }


        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            newNode.Next = Head;
            Head = newNode;
        }

        public T RemoveFirst()
        {
            if (Head == null)
                throw new InvalidOperationException("Списъкът е празен");

            T removedData = Head.Data; 
            Head = Head.Next; 
            return removedData;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        public T RemoveLast()
        {
            if (Head == null)
                throw new InvalidOperationException("Списъкът е празен");

            if (Head == Tail)
            {
                T data = Head.Data;
                Head = null;
                Tail = null;
                return data;
            }

            Node<T> current = Head;
            while (current.Next != Tail)
            {
                current = current.Next;
            }

            T removedData = Tail.Data;
            Tail = current;
            Tail.Next = null;
            return removedData;
        }


        // Търсене на елемент по стойност
        public bool Contains(T value)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(value)) 
                    return true;
                current = current.Next; 
            }
            return false;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void PrintList()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}