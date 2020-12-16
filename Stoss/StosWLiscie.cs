using System;
using System.Collections.Generic;
using System.Text;

namespace Stoss
{
    public class StosWLiscie<T> : IStos<T>
    {
        // Nie zrobiony
        private List<T> list;

        public StosWLiscie()
        {
            list = new List<T>();
        }
        
        public T Peek => throw new NotImplementedException();

        public int Count => list.Count;

        public bool IsEmpty => list.Count == 0;

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T value)
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            throw new NotImplementedException();
        }

        public T this[int index] => throw new NotImplementedException();

    }
}
