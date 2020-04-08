using System;

namespace Rozdz_3
{
    public class MyOverwriteQueue<T> : MyQueue<T>
    {
        int _capacity;
        public MyOverwriteQueue(int capacity = 3)
        {
            _capacity = capacity;
        }

        public override void WriteElement(T element)
        {
            base.WriteElement(element);

            if (queue.Count > _capacity)
            {
                var deleted = queue.Dequeue();
                OnItemDeleted(deleted, element);
            }
        }

        private void OnItemDeleted(T deleted, T element)
        {
            if (ItemDeleted != null)
            {
                var args = new ItemDeletedEventArgs<T>(deleted, element);
                ItemDeleted(this, args);
            }
        }

        public override bool IsFull => queue.Count == _capacity;

        public event EventHandler<ItemDeletedEventArgs<T>> ItemDeleted;
    }
}
