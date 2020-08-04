using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Task
{
    class MyStack<T>
    {
        // CREATE NEW STACK
        List<T> Stack = new List<T>();
        
        // CHECK IF STACK IS EMPTY
        public bool isEmpty()
        {
            return Stack.Count == 0;
        }

        //ADD ITEMS TO STACK
        public void Push(T value)
        {
            Stack.Add(value);
        }

        //LOG OUT ALL ITEMS IN STACK
        public void Print()
        {
            foreach (var item in Stack)
            {
                Console.WriteLine(item);
            }
        }

        //REMOVE AND RETURN LAST ITEM FROM STACK
        public T Pop()
        {
            T Removed = Stack[Stack.Count - 1];
            Stack.RemoveAt(Stack.Count - 1);
            return Removed;
        }

        // RETURN LAST ITEM ADDED TO STACK
        public T Peek()
        {
            T Last = Stack[Stack.Count - 1];
            return Last;
        }

        // RETURN LENGTH OF STACK
        public int Size()
        {
            return Stack.Count;
        }
    }
}
