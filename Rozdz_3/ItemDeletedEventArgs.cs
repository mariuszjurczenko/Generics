using System;

namespace Rozdz_3
{
    public class ItemDeletedEventArgs<T> : EventArgs
    {
        public ItemDeletedEventArgs(T itemDeleted, T itemNew)
        {
            ItemDeleted = itemDeleted;
            ItemNew = itemNew;
        }

        public T ItemDeleted { get; set; }
        public T ItemNew { get; set; }
    }
}
