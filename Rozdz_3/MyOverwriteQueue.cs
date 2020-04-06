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
                queue.Dequeue();
            }
        }

        public override bool IsFull => queue.Count == _capacity;
    }
}
