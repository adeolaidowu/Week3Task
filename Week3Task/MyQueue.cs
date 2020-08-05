using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Task
{
    // QUEUE CLASS
    class MyQueue<T>
    {
        List<T> Queue = new List<T>();

        // CHECK IF EMPTY
        public bool isEmpty()
        {
            return Queue.Count == 0;
        }

        // GET SIZE OF QUEUE
        public int Size()
        {
            return Queue.Count;
        }

        // PRINT QUEUE ITEMS TO CONSOLE
        public void Print()
        {
            foreach (var item in Queue)
            {
                Console.WriteLine(item);
            }
        }

        // ADD TO THE END OF QUEUE
        public void Enqueue(T value)
        {
            Queue.Add(value);
        }

        // REMOVE FROM FRONT OF QUEUE
        public T Dequeue()
        {
            T Dequeued = Queue[0];
            Queue.RemoveAt(0);
            return Dequeued;
        }
    }
}
