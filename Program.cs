using System;
using Containers;

namespace DataCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> arr = new LinkedList<int>();

            arr.AddLast(5);
            arr.AddLast(4);
            arr.AddLast(3);
            arr.AddLast(2);
            arr.AddLast(1);
            arr.AddFirst(6);
            arr.Insert(4, 7);
            // arr.Clear();

            System.Console.WriteLine(arr.Count);
            System.Console.WriteLine(arr);
            System.Console.WriteLine(arr.Contains(7));

            // arr.Remove(7);
            arr.RemoveFirst();
            System.Console.WriteLine(arr);
            System.Console.WriteLine(arr.Count);

            arr.RemoveLast();
            System.Console.WriteLine(arr);
            System.Console.WriteLine(arr.Count);

            System.Console.WriteLine("Find First 4: " + arr.IndexOf(4));
            System.Console.WriteLine("Find Last 4: " + arr.LastIndexOf(4));
            arr.Insert(4, 4);
            System.Console.WriteLine(arr);
            System.Console.WriteLine("Find First 4: " + arr.IndexOf(4));
            System.Console.WriteLine("Find Last 4: " + arr.LastIndexOf(4));
        }
    }
}
