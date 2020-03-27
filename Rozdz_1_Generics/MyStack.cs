using System;

namespace Rozdz_1_Generics
{
    public class MyStack
    {
        private object[] elementsStack;
        private int topOfTheStack;

        public MyStack() : this(capacity: 5)
        {
        }

        public MyStack(int capacity)
        {
            elementsStack = new object[capacity];
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

        public void WriteElement(object element)
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

        public object ReadElement()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty !");
                return 0;
            }
            else
                return elementsStack[topOfTheStack--];
        }

        public object CheckElement()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack is empty !");
                return 0;
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

        public object SumOfElements()
        {
            var sum = 0.0;

            for (int i = topOfTheStack; i > -1; i--)
            {
                var value = elementsStack[i];
                if (value is double)
                {
                    sum += (double)elementsStack[i];
                }
            }             

            return sum;
        }
    }
}
