﻿using System.Collections.Generic;

namespace Rozdz_1_Generics
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