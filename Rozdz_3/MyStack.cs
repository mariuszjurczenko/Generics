using System;
using System.Collections;
using System.Collections.Generic;

namespace Rozdz_3
{
    public class MyStack<T> : IMyCollection<T>
    {
        private Stack<T> stack;
        private int _capaciy;

        public MyStack(int capacity = 5)
        {
            _capaciy = capacity;
            stack = new Stack<T>(capacity);
        }

        public bool IsEmpty => stack.Count == 0;

        public bool IsFull => stack.Count == _capaciy;

        public void WriteElement(T element)
        {
            stack.Push(element);
        }
        public T ReadElement()
        {
            return stack.Pop();
        }
        public T CheckElement()
        {
            return stack.Peek();
        }
        public void DisplayAll()
        {
            if (IsEmpty)
                Console.WriteLine("No elements to display");

            var i = 0;
            foreach (var item in stack)
            {
                Console.WriteLine("Element{0} : {1}", (++i), item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in stack)
            {
                // ...
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
