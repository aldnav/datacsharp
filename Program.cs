using System;
using Containers;

namespace DataCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQ = new Queue<int>();

            myQ.Enqueue(5);
            myQ.Enqueue(6);
            myQ.Enqueue(8);
            System.Console.WriteLine("Queue: " + myQ);

            System.Console.WriteLine("Peek: " + myQ.Peek());
            System.Console.WriteLine("Deque: " + myQ.Dequeue());
            System.Console.WriteLine("Queue: " + myQ);

            System.Console.WriteLine("Deque: " + myQ.Dequeue());
            System.Console.WriteLine("Queue: " + myQ);

            myQ.Enqueue(9);
            System.Console.WriteLine("Queue: " + myQ);

            System.Console.WriteLine("Deque: " + myQ.Dequeue());
            System.Console.WriteLine("Queue: " + myQ);

            myQ.Dequeue();
            System.Console.WriteLine("QSize: " + myQ.Count);
            System.Console.WriteLine("Queue: " + myQ);
        }
    }
}
