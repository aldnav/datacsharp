

using System.Collections.Generic;
using System.Text;
/**
Properties
* Count
* First
* Last
Operations
x* AddAfter
x* AddBefore
x* AddFirst
x* AddLast
x* Insert
x* Clear
* Contains
* Find
* FindLast
* Remove
* RemoveFirst
* RemoveLast
* ToString
*/
namespace Containers
{
    public class Node<T>
    {
        Node<T> prev;
        Node<T> next;
        public T item;

        public Node(T item)
        {
            this.item = item;
        }

        public Node(T item, Node<T> prevNode)
        {
            this.item = item;
            prev = prevNode;
            prev.next = this;
        }

        public Node<T> Next { get => next; set => next = value; }
        public Node<T> Prev { get => prev; set => prev = value; }
    }

    public class LinkedList<T>
    {
        private Node<T> head;
        public Node<T> First { get => head; }
        private Node<T> tail;
        public Node<T> Last { get => tail; }
        private int count;
        public int Count { get => count; }
        private Node<T> current;

        public LinkedList()
        {   
            head = null;
            tail = null;
            count = 0;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddLast(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
                tail = head;
            }
            else
            {
                Node<T> newNode = new Node<T>(item, tail);
                tail = newNode;
            }
            count++;
        }

        public void AddFirst(T item) => Insert(0, item);

        public void AddAfter(T item, Node<T> refNode)
        {
            int index = IndexOf(refNode);
            if (index < 0) { return; }

            Insert(index, item);
        }

        public void AddBefore(T item, Node<T> refNode)
        {
            int index = IndexOf(refNode);
            if (index < 0) { return; }

            Insert(index, item);
        }


        public void Insert(int index, T item)
        {
            if (index >= count + 1 || index < 0)
            {
                throw new System.ArgumentOutOfRangeException("Out of range!");
            }
            count++;

            Node<T> newNode = new Node<T>(item);
            int currentIndex = 0;
            current = head;
            Node<T> prevItem = null;
            while (currentIndex < index)
            {
                prevItem = current;
                current = current.Next;
                currentIndex++;
            }
            if (index == 0)
            {
                // is first item
                newNode.Prev = head.Prev;
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
            else if (index == count - 1) {
                // is last item
                newNode.Prev = tail;
                tail.Next = newNode;
                newNode = tail;
            }
            else
            {
                newNode.Next = prevItem.Next;
                prevItem.Next = newNode;
                newNode.Prev = current.Prev;
                current.Prev = newNode;
            }
        }

        public int IndexOf(Node<T> refNode)
        {
            int index = 0;
            Node<T> currentItem = head;
            while (currentItem != null)
            {
                if (((currentItem.item != null) && EqualityComparer<T>.Default.Equals(refNode.item, currentItem.item)) ||
                    ((currentItem.item == null) && (refNode == null)))
                {
                    return index;
                }
                index++;
                currentItem = currentItem.Next;
            }
            return -1;
        }

        public int IndexOf(T item)
        {
            int index = 0;
            Node<T> currentItem = head;
            while (currentItem != null)
            {
                if (((currentItem.item != null) && EqualityComparer<T>.Default.Equals(item, currentItem.item)) ||
                    ((currentItem.item == null) && (item == null)))
                {
                    return index;
                }
                index++;
                currentItem = currentItem.Next;
            }
            return -1;
        }

        public bool Contains(T item) => IndexOf(item) >= 0;

        public void Remove(T item)
        {
            int currentIndex = 0;
            current = head;
            Node<T> prevItem = null;
            while (current != null)
            {
                if (((current.item != null) && EqualityComparer<T>.Default.Equals(item, current.item)) ||
                    ((current.item == null) && (item == null)))
                {
                    break;
                }
                prevItem = current;
                current = current.Next;
                currentIndex++;
            }
            if (current == null) { return; }
            
            count--;
            if (count == 0)
            {
                head = null;
            }
            else if (prevItem == null)
            {
                head = current.Next;
                head.Prev = null;
            }
            else if (current == tail)
            {
                current.Prev.Next = null;
                this.tail = current.Prev;
            }
            else
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            Node<T> currentItem = head;
            while (currentItem != null)
            {   
                builder.Append(currentItem.item).Append(",");
                currentItem = currentItem.Next;
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
