using System;

class Object
{
    public int value;
    public Object next;

    public Object(int value)
    {
        this.value = value;
        this.next = null;
    }
}

class LinkedList
{
    private Object start;

    public LinkedList()
    {
        this.start = null;
    }

    public void addValue(int value)
    {
        Object newObject = new Object(value);

        if (start == null)
        {
            start = newObject;
        }
        else
        {
            Object current = start;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newObject;
        }
    }

    public void removeValue(int value)
    {
        if (start == null)
        {
            return;
        }

        if (start.value == value)
        {
            start = start.next;
            return;
        }

        Object current = start;
        while (current.next != null)
        {
            if (current.next.value == value)
            {
                current.next = current.next.next;
                return;
            }
            current = current.next;
        }
    }

    public int Length()
    {
        int count = 0;
        Object current = start;
        while (current != null)
        {
            count++;
            current = current.next;
        }
        return count;
    }

    public void PrintList()
    {
        Object current = start;
        while (current != null)
        {
            Console.Write(current.value + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        list.addValue(1);
        list.addValue(2);
        list.addValue(3);
        list.addValue(4);
        list.addValue(5);

        Console.WriteLine("Linked list after adding elements:");
        list.PrintList();

        list.removeValue(3);

        Console.WriteLine("Linked list after removing an element:");
        list.PrintList();

        Console.WriteLine("Length of the linked list: " + list.Length());
    }
}


