using System;
using System.Collections.Generic;

namespace ComputerScienceTest
{
    class Node<T>
    {
        private T value;
        private Node<T> nextNode;

        public Node(T x)
        {
            this.value = x;
            this.nextNode = null;
        }

        public Node(T x, Node<T> y)
        {
            this.value = x;
            this.nextNode = y;
        }

        public T GetValue()
        {
            return this.value;
        }

        public Node<T> GetNext()
        {
            return this.nextNode;
        }

        public bool HasNext()
        {
            return this.nextNode != null;
        }

        public void SetValue(T x)
        {
            this.value = x;
        }

        public void SetNext(Node<T> y)
        {
            this.nextNode = y;
        }
        
		public override string ToString()
        {
            return ("Value : " + this.value + " has next node : " + (this.nextNode == null));
        }
    }
}
