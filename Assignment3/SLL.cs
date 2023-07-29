using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class SLL : ILinkedListADT
    {
        private Node head;
        private int listSize;

        public SLL()
        {
            head = null;
        }

        public bool Contains(User target)
        {
            Node tempNode = head;
            while (tempNode!=null)
            {
                if(tempNode.Equals(target)) 
                    return true;

                tempNode = tempNode.Next;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else return false;
        }
        public User GetValue(int index)
        {
            Node tempNode = head;
            if (tempNode == null || (listSize - 1) < index || index < 0)
                return null;

            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.Next;
            }

            return (User)tempNode.Data;
        }

        public void Add(User value, int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            
            if (index == 0)
            {
                listSize++;
                AddFirst(value);
                return;
            }

            Node node = new Node(value);
            Node currentNode = head;
            Node previous = null;
            Node next = null;
            for (int i = 0; i < index; i++)
            {
                previous = currentNode;
                currentNode = currentNode.Next;
            }
            previous.Next = node;
            node.Next = currentNode;
            listSize++;
        }
        public void AddFirst(User value)
        {
            listSize++;
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
        }

        public void AddLast(User data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }
            Node currentNode = head;
            while (currentNode.Next!=null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
            listSize++;
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= listSize)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (index == 0)
            {
                listSize--;
                RemoveFirst();
                return;
            }

            Node currentNode = head;
            Node previousNode = null;
            int currentIndex = 0;

            while (currentIndex < index)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;

                previousNode.Next = currentNode.Next;
                listSize--;
            }
        }
        public void RemoveLast()
        {

            if (head == null)
            {
                return;
            }

            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node previousNode = null;
            Node currentNode = head;
            while (currentNode != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            listSize--;
        }

        public void RemvoveAt(int index)
        {

            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (index == 0)
            {
                listSize--;
                RemoveFirst();
                return;
            }

            Node currentNode = head;
            Node previousNode = null;
            int currentIndex = 0;
            while (currentIndex < index)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            previousNode.Next = currentNode.Next;
            listSize--;

        }

        public void RemoveFirst()
        {
            listSize--;
            if (head == null)
            {
                return;
            }

            head = head.Next;
        }


        public void Clear()
        {
            head = null;
        }

        public void Replace(User value, int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            Node node = new Node(value);
            Node currentNode = head;
            Node previous = null;
            Node next = null;
            for (int i = 0; i < index; i++)
            {
                previous = currentNode;
                currentNode = currentNode.Next;
            }
            previous.Next = node;
            node.Next = currentNode.Next;

        }

        public int IndexOf(User target)
        {
            if (head == null)
            {
                return -1;
            }

            int index = 0;
            for (Node tempNode = head; tempNode != null; tempNode = tempNode.Next)
            {
                if (tempNode.Data.ToString() == target.ToString())
                {
                    return index;
                }
                index++;
            }
            return -1;

        }

        public int Count()
        {
            if (head is null)
            {
                return 0;
            }

            return listSize;
        }
    }
}
