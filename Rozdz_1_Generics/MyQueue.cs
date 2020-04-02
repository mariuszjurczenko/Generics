using System;
using System.Collections;
using System.Collections.Generic;

namespace Rozdz_1_Generics
{
    public class MyQueue<T> : IMyCollection<T>
    {
        protected Queue<T> queue;

        public MyQueue()
        {
            queue = new Queue<T>();
        }

        public bool IsEmpty => queue.Count == 0;

        public virtual bool IsFull => false;

        public virtual void WriteElement(T element)
        {
            queue.Enqueue(element);
        }
        public T ReadElement()
        {
            return queue.Dequeue();
        }
        public T CheckElement()
        {
            return queue.Peek();
        }

        public void DisplayAll()
        {
            if (IsEmpty)
                Console.WriteLine("No elements to display");

            var i = 0;
            foreach (var item in queue)
            {
                Console.WriteLine("Element{0} : {1}", (++i), item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in queue)
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