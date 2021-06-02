using System;

namespace StackAndQueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Dequeue();
            Console.WriteLine("After Deleting one element from the queue is  : ");
            linkedListQueue.Display();
        }
    }
}