/**
Properties
x1. Capacity
x2. Count
x3. Item
Operations
x1. Add
x2. Clear
x3. Contains
x4. IndexOf
x5. Insert
x6. Remove
x7. RemoveAt
x8. Reverse
x9. Sort
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Containers
{
    public class ArrayList<T>
    {
        T[] items;
        private int capacity;
        public virtual int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private int count;
        public int Count { get { return count; } }

        public virtual T this[int index] {
            get { return items[index]; }
            // set { items }  // 
        }

        public ArrayList()
        {
            capacity = Int32.MaxValue / 2;
            count = 0;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count + 1 > capacity)
            {
                throw new System.ArgumentOutOfRangeException("Max capacity is reached.");
            }
            items[count] = item;
            count++;
        }

        public void Clear()
        {
            count = 0;
            items = new T[capacity];
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > capacity)
            {
                throw new System.ArgumentOutOfRangeException("Index out of bounds!");
            }
            if (index == count)
            {
                Add(item);
            } else 
            {
                for (int i = count; i > index; i--)
                {
                    items[i] = items[i - 1];
                }
                items[index] = item;
                count++;
            }
        }
        

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item)) {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item, int startIndex, int bound)
        {
            if ((startIndex < 0 || startIndex > count) || (bound < 0) ||
                (bound < startIndex) || (startIndex + bound > count))
            {
                throw new System.ArgumentOutOfRangeException("Start and bound not valid!");
            }


            for (int i = startIndex; i < bound; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item)) {
                    return i;
                }
            }
            return -1;
        }

        public int IndexOf(T item)
        {
            return IndexOf(item, 0, count);
        }

        public void Remove(T item)
        {
            int index = IndexOf(item);
            if (index < 0) { return; }

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new System.ArgumentOutOfRangeException("Index to remove is out of bounds!");
            }

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }

        public void Reverse() {
            for (int i = 0, j = count - 1; i < count / 2; i++, j--)
            {
                T temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
        }

        public void Sort() {
            QuickSort(items, 0, count - 1);
        }

        private void QuickSort(T[] arr, int left, int right) {
            // Dutch National Flag implementation of quick sort
            if (arr.Length < 2) {
                return;
            }
            int i = left;
            int j = right;
            T pivot = arr[left + (right - left) / 2];
            Comparer<T> comparer = Comparer<T>.Default;

            while (i <= j) {
                while (comparer.Compare(arr[i], pivot) < 0) i++;
                while (comparer.Compare(arr[j], pivot) > 0) j--;

                if (i <= j) {
                    T tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j--;
                }
            }

            if (left < j) QuickSort(arr, left, j);
            if (i < right) QuickSort(arr, i, right);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(items[i]).Append(",");
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
