using System;
using System.Collections;

namespace Week3Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> testStack = new MyStack<int>();
            Console.WriteLine(testStack.isEmpty());
            testStack.Push(4);
            testStack.Push(9);
            testStack.Push(35);
            Console.WriteLine(testStack.isEmpty());
            testStack.Print();
            Console.WriteLine();
            Console.WriteLine(testStack.Pop());
            Console.WriteLine();
            testStack.Print();
            Console.WriteLine(testStack.Size());
            Console.WriteLine(testStack.Peek());

        }
    }
}
