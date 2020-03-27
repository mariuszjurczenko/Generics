using System;

namespace Rozdz_1_Generics
{
    public class MyStack<T>
    {
        private T[] elementsStack;
        private int topOfTheStack;

        public MyStack() : this(capacity: 5)
        {
        }

        public MyStack(int capacity)
        {
            elementsStack = new T[capacity];
            topOfTheStack = -1;
        }

        public int Capacity
        {
            get { return elementsStack.Length; }
        }

        public bool IsEmpty
        {
            get { return topOfTheStack == -1; }
        }

        public bool IsFull
        {
            get { return topOfTheStack == (Capacity - 1); }
        }

        public void WriteElement(T element)
        {
            if (IsFull)
            {
                Console.WriteLine("Stack is full !");
                Console.WriteLine("Element not added !");
            }
            else
            {
                elementsStack[++topOfTheStack] = element;
                Console.WriteLine("Element has been successfully added !");
            }
        }

        public T ReadElement()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty !");
                return default;
            }
            else
                return elementsStack[topOfTheStack--];
        }

        public T CheckElement()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty !");
                return default;
            }
            else
                return elementsStack[topOfTheStack];
        }

        public void DisplayAll()
        {
            if (IsEmpty)
                Console.WriteLine("No elements to display");

            for (int i = topOfTheStack; i > -1; i--)
                Console.WriteLine("Element {0} : {1}", (i + 1), elementsStack[i]);
        }
    }
}
