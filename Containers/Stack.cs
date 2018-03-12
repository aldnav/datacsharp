
using System.Text;

namespace Containers
{
    class Stack<T>
    {

        private ArrayList<T> elements;
        private int currentIndex;
        public int Count { get => elements.Count; }

        public Stack()
        {
            elements = new ArrayList<T>();
            currentIndex = 0;
        }

        public void Clear()
        {
            elements = new ArrayList<T>();
            currentIndex = 0;
        }

        public bool Contains(T item) => elements.Contains(item);

        public T Peek()
        {
            return elements[currentIndex - 1];
        }

        public T Pop()
        {
            T toPop;
            try
            {
                toPop = elements[currentIndex - 1];
            }
            catch (System.IndexOutOfRangeException)
            {
                
                throw new System.InvalidOperationException("Stack is empty");
            }
            if (toPop != null)
            {
                elements.RemoveAt(currentIndex - 1);
                currentIndex--;
                return toPop;
            }
            throw new System.InvalidOperationException("Stack is empty");
        }

        public void Push(T item)
        {
            elements.Insert(currentIndex, item);
            currentIndex++;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = Count - 1; i >= 0; i--)
            {
                builder.Append(elements[i]).Append(",");
            }
            try
            {
                builder.Length -= 1; 
            }
            catch (System.Exception) { }
            
            return builder.ToString();
        }

    }
}
