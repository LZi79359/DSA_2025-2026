using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProject
{
    public class DNode<T>
    {
        public T Element { get; set; }
        public DNode<T>? Next { get; set; }
        public DNode<T>? Prev { get; set; }
    }
    public class ListQueue<T> : IQueueADT<T>
     {
        private DNode<T>? head;
        private DNode<T>? tail;
        public int Size{get; private set;}
        

        public void Enqueue(T item)
        {
            DNode<T> newNode = new DNode<T>() { Element = item };

            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Prev = tail;
                newNode.Next = null;
                tail.Next = newNode;
                tail = newNode;
            }
            Size++;
        }

        public T Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException("You cannot dequeue from an empty Queue!");
            }

            T toBeRemoved = head.Element;
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Next;
                head.Prev = null;

            }

            Size--;
            return toBeRemoved;
        }

        public T Peek()
        {
            return head != null ? head.Element : throw new InvalidOperationException("You cannot peek in an empty Queue!");
        }
     }

}
