class Node:
    def __init__(self, data):
        self.data = data
        self.next = None


class LinkedList:
    def __init__(self):
        self.head = None

    def add_to_tail(self, data):
        new_node = Node(data)
        if self.head is None:
            self.head = new_node
            return
        current = self.head
        while current.next:
            current = current.next
        current.next = new_node


linked_list = LinkedList()

# Add five nodes to the linked list
linked_list.add_to_tail(1)
linked_list.add_to_tail(2)
linked_list.add_to_tail(3)
linked_list.add_to_tail(4)
linked_list.add_to_tail(5)

while linked_list.head:
    print(linked_list.head.data)
    linked_list.head = linked_list.head.next
