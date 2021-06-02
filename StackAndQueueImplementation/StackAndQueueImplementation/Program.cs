using System;

namespace StackAndQueueImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.Push(70);
            //linkedListStack.Push(30);
            //linkedListStack.Push(56);
            linkedListStack.Peek();
            linkedListStack.Display();
        }
    }
}