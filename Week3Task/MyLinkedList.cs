﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Week3Task
{
    // NODE CLASS
    class Node<T>
    {
        public Node(T val)
        {
            Value = val;
            this.Next = null;
            this.Previous = null;
        }
        /// <summary>
        /// node value
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// next node
        /// </summary>
        public Node<T> Next { get; set; }
        /// <summary>
        /// previous node
        /// </summary>
        public Node<T> Previous { get; set; }

    }

    // DOUBLY LINKED LIST CLASS
    class MyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Size { get; private set; }
        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }
        // METHOD TO ADD NODE TO LINKED LIST
        public int AddAtEnd(T val)
        {
            Node<T> newNode = new Node<T>(val);
            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
            } else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
            Size++;
            return Size;
        }
        // METHOD TO CHECK FOR VALUE IN LIST
        public bool Check(T val)
        {
            if (Size == 0) return false;
            if (Search(val) != null) return true;
            return false;
        }
        // METHOD TO FIND VALUE IN LIST
        public object Search(T val)
        {
            Node<T> current = Head;
            while(current != null)
            {
                if (current.Value.Equals(val)) return current.Value;
                else current = current.Next;
            }
            return null;
        }
        // METHOD TO RETURN NODE AT PARTICULAR INDEX
        public Node<T> Get(int index)
        {
            Node<T> current = Head;
            int count = 0;
            while(current != null)
            {
                if (index == count) return current;
                current = current.Next;
                count++;
            }
            return null;
        }

        // CHECK IF LIST IS EMPTY
        public bool isEmpty()
        {
            return Size == 0;
        }

        // GET SIZE OF LIST
        public int GetSize()
        {
            return Size;
        }
        //METHOD TO FIND INDEX OF A VALUE IN LIST
        public int IndexOf(T val)
        {
            Node<T> currentNode = Head;
            int count = 0;
            while(currentNode != null)
            {
                if (currentNode.Value.Equals(val)) return count;
                currentNode = currentNode.Next;
                count++;
            }
            return -1;
        }

        // METHOD TO INSERT NODE INTO LIST
        public bool Insert(int index, T val)
        {
            Node<T> newNode = new Node<T>(val);
            Node<T> currentHead = Head;
            Node<T> previous = null;
            if (index < 0 || index >= Size) throw new IndexOutOfRangeException();
            if (index == Size - 1)
            {
                Node<T> current = Get(index);
                Node<T> prev = current.Previous;
                prev.Next = newNode;
                newNode.Next = current;
                current.Previous = newNode;
                newNode.Previous = prev;
                return true;
            }
            if(index == 0)
            {
                Node<T> current = Get(index);
                current.Previous = newNode;
                newNode.Next = current;
                Head = newNode;
                return true;

            }
            int count = 0;
            while(count < index)
            {
                previous = currentHead;
                currentHead = currentHead.Next;
                count++;
            }
            Node<T> Next = previous.Next;
            previous.Next = newNode;
            newNode.Previous = previous;
            newNode.Next = Next;
            Next.Previous = newNode;
            return true;

            
        }

        // METHOD TO REMOVE NODE FROM LIST
        public void Remove(int index)
        {
            Node<T> current = Head;
            int count = 0;
            while(count != index)
            {
                current = current.Next;
                count++;
            }
            Node<T> prev = current.Previous;
            Node<T> next = current.Next;
            prev.Next = next;
            next.Previous = prev;
        }

        // LOG OUT LIST ITEMS
        public void Print()
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
