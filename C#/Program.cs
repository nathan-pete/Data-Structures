// Creating a LinkedIn list of type T
//CountNum - return the number of items in the list 
using System;
public class LinkedList<Type>
{
    private class Vector
    {
        public Type Value { get; set; }
        public Vector Next { get; set; }

        public Vector(Type value)
        {
            Value = value;
        }

        private int countNum;
        private Vector start; // head
        private Vector end; // tail 

        public void addFirst(Type first)
        {
            Vector vector = new Vector(first);
            Vector temporary = start;
            start = vector;
            start.Next = temporary;
            countNum++;

            if (countNum == 1)
            {
                end = start;
            }
        }

        public void AddLast(Type last)
        {
            Vector vector = new Vector(last);
            if (countNum == 0)
            {
                start = vector;
            }
            else
            {
                end.Next = vector;
            }
            end = vector;
            countNum++;
        }

        public void RemoveFirst()
        {
            if (countNum != 0)
            {
                start = start.Next;
                countNum--;
                if (countNum == 0)
                {
                    end = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (countNum != 0)
            {
                if (countNum == 1)
                {
                    start = null;
                    end = null;
                }
                else
                {
                    Vector current = start;
                    while (current.Next != end)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    end = current;
                }
                countNum--;
            }
        }


        public int lengthOfList()
        {
            int count = 0;
            Vector current = start;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

    }
}
