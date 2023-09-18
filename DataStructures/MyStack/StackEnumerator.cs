using System.Collections;

namespace DataStructuresLibrary.MyStack
{
    public class StackEnumerator<T> : IEnumerator<T>
    {
        private StackNode<T> Head;
        private StackNode<T> _current;
        public T Current => _current.Value;

        object IEnumerator.Current => _current;
        public StackEnumerator(StackNode<T> head)
        {
            Head= head;
            _current = null;
        }

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = Head;
                return true;
            }
            else
            {
                _current = _current.Prev;
                return _current != null ? true : false;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}