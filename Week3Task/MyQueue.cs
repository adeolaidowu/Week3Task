using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Task
{
    class MyQueue<T>
    {
        List<T> Queue = new List<T>();

        public bool isEmpty()
        {
            return Queue.Count == 0;
        }

        public int Size()
        {
            return Queue.Count;
        }

        public void Print()
        {
            foreach (var item in Queue)
            {
                Console.WriteLine(item);
            }
        }

        public void Enqueue(T value)
        {
            Queue.Add(value);
        }

        public T Dequeue()
        {
            T Dequeued = Queue[0];
            Queue.RemoveAt(0);
            return Dequeued;
        }
    }
}
