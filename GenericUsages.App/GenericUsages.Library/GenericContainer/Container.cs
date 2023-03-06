using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUsages.Library.GenericContainer
{
    public class Container<T> : IEnumerable<T>
    {
        private protected Node<T> _head;
        private protected Node<T> _tail;
        private protected int _count;

        public int Count{ get { return _count; } }
        public bool IsEmpty { get { return Count == 0; } }

        public T First
        {
            get
            {
                if(IsEmpty)
                    throw new InvalidOperationException();
                return _head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return _tail.Data;
            }
        }

        public Container() { }

        public virtual void Add(T item) 
        {

        }

        public virtual void Delete(T data)
        {

        }

        public virtual void Clear() 
        {
            _count = 0;
            _head.Next = null;
            _head = null;
            _tail = null;
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
