using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Task
{
    class MyStack<T>
    {
        List<T> Stack = new List<T>();
        
        public bool isEmpty()
        {
            return Stack.Count == 0;
        }

        public void Push(T value)
        {
            Stack.Add(value);
        }

        public void Print()
        {
            for (int i = Stack.Count -1;  i >= 0; i--)
            {
                Console.WriteLine(Stack[i]);
            }
        }

        public T Pop()
        {
            T Removed = Stack[Stack.Count - 1];
            Stack.RemoveAt(Stack.Count - 1);
            return Removed;
        }

        public T Peek()
        {
            T Last = Stack[Stack.Count - 1];
            return Last;
        }

        public int Size()
        {
            return Stack.Count;
        }
    }
}
