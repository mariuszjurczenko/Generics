using System.Collections.Generic;

namespace Rozdz_3
{
    public interface IMyCollection<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        bool IsFull { get; }
        void WriteElement(T element);
        T ReadElement();
        T CheckElement();
        void DisplayAll();
    }
}
