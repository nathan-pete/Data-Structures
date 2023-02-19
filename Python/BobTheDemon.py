begin = input("Begin? Please type 'y' or 'n': ")

if begin == "y":

    print("To add a node to the beginning of the list, type 'add_first'")
    print("To add a node to the end of the list, type 'add_last'")
    print("To remove a node from the beginning of the list, type 'remove_first'")
    print("To remove a node from the end of the list, type 'remove_last'")


    class Node:
        def __init__(self, data):
            self.data = data
            self.next = None


    class LinkedList:
        def __init__(self):
            self.tail = None
            self.head = None
            self.size = 0

        def add_first(self, data):
            new_node = None
            if self.length() == 0:
                new_node = Node(1)
            else:
                new_node = Node(data)

            new_node.next = self.head
            self.head = new_node

        def add_last(self, data):
            new_node = Node(data)
            new_node.next = None
            self.tail.next = new_node
            self.tail = new_node
            self.size += 1

        def remove_first(self):
            if self.head is None:
                return "List is empty"
            self.head = self.head.next
            self.size -= 1

        def remove_last(self):
            if self.head is None:
                return "List is empty"
            current = self.head
            while current.next is not self.tail:
                current = current.next
            self.tail = current
            self.tail.next = None
            self.size -= 1

        def print_list(self):
            current = self.head
            while current:
                print(current.data)
                current = current.next

        def clear(self):
            self.head = None
            self.tail = None
            self.size = 0

        def length(self):
            current = self.head
            count = self.size
            while current:
                count += 1
                current = current.next
            return count


    otherlist = LinkedList()

    while True:
        call = input("Call a Function: ")

        if call == "clear":
            otherlist.clear()
            print("List has been cleared")

        if call == "add_first":  # self       data
            LinkedList.add_first(otherlist, input())
            otherlist.length()

        elif call == "add_last":
            otherlist.add_last(input())
            otherlist.length()

        elif call == "remove_first":
            otherlist.remove_first()
            otherlist.length()

        elif call == "remove_last":
            otherlist.remove_last()
            otherlist.length()

        elif call == "exit":
            break


else:
    print("Exiting...")
    exit()

while otherlist.head:
    print(otherlist.head.data)
    otherlist.head = otherlist.head.next
