using System;

namespace StackGeneric
{
    public class Stack<T>
    {
        private T[] _stack;
        private int _top;

        public int Count => _top + 1;
        public bool IsEmpty => _top == -1;
        public void Clear() => _top = -1;

        public Stack(int size = 10)
        {
            _stack = new T[size];
            _top = -1; // empty
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack was empty");
            }

            return _stack[_top];
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack was empty");
            }

            return _stack[_top--];
        }

        public void Push(T value)
        {
            if (IsFull())
            {
                Array.Resize(ref _stack, _stack.Length * 2);
            }

            _stack[_top++] = value;
        }

        private bool IsFull()
        {
            return _top == _stack.Length - 1;
        }
    }
}
