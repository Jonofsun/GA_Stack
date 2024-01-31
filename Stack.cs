using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Stack
{
    class Stack<T>
    {
        // Nested class StackNode representing elements in the stack.
        class StackNode<T>
        {
            public T Value { get; set; }                    // Data stored in the node.
            public StackNode<T> Next { get; set; }          // Reference to the next node.

            public StackNode(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private StackNode<T> top;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public Stack()
        {
            top = null;
            count = 0;
        }

        public void Push(T value)
        {
            StackNode<T> newNode = new StackNode<T>(value);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public T Pop()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty.");

            T value = top.Value;
            top = top.Next;
            count--;
            return value;
        }

        public T Peek()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty.");

            return top.Value;
        }

        public void Clear()
        {
            top = null;
            count = 0;
        }
    }

}
