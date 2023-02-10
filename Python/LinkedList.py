
begin = input("Begin? Please type 'Yes' or 'No': ")

if begin == "Yes":

    print("To add a node to the beginning of the list, type 'add_first'")
    print("To add a node to the end of the list, type 'add_last'")
    print("To remove a node from the beginning of the list, type 'remove_first'")
    print("To remove a node from the end of the list, type 'remove_last'")

    call = input("Call a Function: ")


    class Node:
        def __init__(self, data):
            self.data = data
            self.next = None


    class LinkedList:
        def __init__(self):
            self.tail = None
            self.head = None
            self.size = 5

        def add_first(self, data):
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

        def length(self):
            current = self.head
            count = self.size
            while current:
                count += 1
                current = current.next
            return count

    if __name__ == '__main__':
        linked_list = LinkedList()
        linked_list.add_first(1)
        linked_list.add_first(2)
        linked_list.add_first(3)
        linked_list.add_first(4)
        linked_list.add_first(5)

        length = linked_list.length()

    if call == "add_first":
        LinkedList.add_first()
        LinkedList.length()

    elif call == "add_last":
        LinkedList.add_last()
        LinkedList.length()

    elif call == "remove_first":
        LinkedList.remove_first()
        LinkedList.length()

    elif call == "remove_last":
        LinkedList.remove_last()
        LinkedList.length()

else:
    print("Exiting...")
    exit()
