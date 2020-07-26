using System;

//using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            Console.WriteLine(queue.IsEmpty());

            queue.Enqueue(1);

            queue.Enqueue(2);

            queue.Enqueue(3);

            Console.WriteLine(queue.Count);

            Console.WriteLine(queue.Peek());

            queue.Dequeue();

            Console.WriteLine(queue.Count);


        }
    }
}
