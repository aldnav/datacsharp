```
ArrayList<int> arr = new ArrayList<int>();

System.Console.WriteLine(arr);
// System.Console.WriteLine(arr.Capacity);
// System.Console.WriteLine(arr.Count);
arr.Add(5);
arr.Add(4);
arr.Add(3);
arr.Add(2);
arr.Add(1);
arr.Add(0);
// System.Console.WriteLine(arr.Count);

// arr.Clear();
// System.Console.WriteLine(arr.Count);
// System.Console.WriteLine(arr[3]);

System.Console.WriteLine(arr);
System.Console.WriteLine(arr.Count);

arr.Insert(2, 10);
System.Console.WriteLine(arr);
System.Console.WriteLine(arr.Count);

arr.Insert(7, 9);
System.Console.WriteLine(arr);
System.Console.WriteLine(arr.Count);

System.Console.WriteLine(arr.Contains(5));
System.Console.WriteLine(arr.Contains(50));
System.Console.WriteLine(arr.IndexOf(4));
System.Console.WriteLine(arr.IndexOf(4, 2, 4));
// try
// {
//     System.Console.WriteLine(arr.IndexOf(4, 4, 3));
// }
// catch (System.Exception e)
// {
//     System.Console.WriteLine(e);
// }
// try
// {
//     System.Console.WriteLine(arr.IndexOf(4, 5, 15));
// }
// catch (System.Exception e)
// {
//     System.Console.WriteLine(e);
// }

arr.Remove(3);
System.Console.WriteLine(arr);
System.Console.WriteLine(arr.Count);

arr.RemoveAt(4);
System.Console.WriteLine(arr);
System.Console.WriteLine(arr.Count);

System.Console.WriteLine(arr);
arr.Reverse();
System.Console.WriteLine(arr);

arr.Add(2);
arr.Sort();
System.Console.WriteLine(arr);
```