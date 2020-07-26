using System;
using System.Collections.Generic;
using System.Text;

namespace Queues
{
    public class Node<T>
    {
        public T Value { get; private set; }

        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
        public Node(T val)
        {
            this.Value = val;
        }
    }
    public class Queue<T>
    {
        public Node<T> Head { get; private set;}

        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }
        public Queue()
        {
            Count = 0;
            Head = null;
        }

        public void Enqueue(T Value) 
        {
            Count++;
            if(IsEmpty())
            {
                Head = new Node<T>(Value);
                Tail = Head;

                return;
            }
            Node<T> NewNode = new Node<T>(Value);

            Tail.Next = NewNode;
            Tail = NewNode;
        }
        public void Dequeue() //remove Head of list
        { 
            if(IsEmpty())
            {
                throw new Exception("Queue is Empty");
            }

            Head = Head.Next;
            //Head.Prev=
            Count--;

            //return Head.Prev.Value;
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue is Empty");
            }

            return Head.Value;
        }

        public bool IsEmpty()
        {
            if(Head==null)
            {
                return true;
            }
            return false;
        }
    }
   
}
