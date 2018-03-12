Stack<int> myStack = new Stack<int>();
            
myStack.Push(5);
myStack.Push(10);
myStack.Push(15);
System.Console.WriteLine("Stack: " + myStack);

System.Console.WriteLine("Peek: " + myStack.Peek());
System.Console.WriteLine("Pop: " + myStack.Pop());
System.Console.WriteLine("Stack: " + myStack);
System.Console.WriteLine("Pop: " + myStack.Pop());
System.Console.WriteLine("Pop: " + myStack.Pop());
try
{
    System.Console.WriteLine("Pop: " + myStack.Pop());
}
catch (System.InvalidOperationException e)
{
    
    System.Console.WriteLine(e);
}